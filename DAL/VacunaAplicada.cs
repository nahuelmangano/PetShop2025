using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VacunaAplicada
    {
        Conexion conexion = new Conexion();

        public List<BE.VacunaAplicada> ListarPorMascota(int idMascota)
        {
            try
            {
                List<BE.VacunaAplicada> lista = new List<BE.VacunaAplicada>();

                var parametros = new SqlParameter[]
                {
                    conexion.crearParametro("@ID_Mascota", idMascota)
                };

                DataTable dt = conexion.LeerPorStoreProcedure("SP_VacunaAplicada_ListarPorMascota", parametros);

                foreach (DataRow fila in dt.Rows)
                {
                    BE.VacunaAplicada va = new BE.VacunaAplicada
                    {
                        ID = Convert.ToInt32(fila["Id"]),
                        NumeroDosis = Convert.ToInt32(fila["NumeroDosis"]),
                        FechaAplicacion = Convert.ToDateTime(fila["FechaAplicacion"]),
                        Vacuna = new BE.Vacuna
                        {
                            ID = Convert.ToInt32(fila["ID_Vacuna"]),
                            Nombre = fila["NombreVacuna"].ToString()
                        },
                        Mascota = new BE.Mascota { ID = idMascota }
                    };

                    lista.Add(va);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener vacunas aplicadas por mascota", ex);
            }
        }

        public int Insertar(BE.VacunaAplicada vacunaAplicada)
        {
            try
            {
                List<SqlParameter> parametros = new List<SqlParameter>
                {
                    conexion.crearParametro("@NumeroDosis", vacunaAplicada.NumeroDosis),
                    conexion.crearParametro("@FechaAplicacion", vacunaAplicada.FechaAplicacion),
                    conexion.crearParametro("@ID_Mascota", vacunaAplicada.Mascota.ID),
                    conexion.crearParametro("@ID_Vacuna", vacunaAplicada.Vacuna.ID)
                };

                return conexion.EscribirPorStoreProcedure("SP_VacunaAplicada_Insertar", parametros.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar vacuna aplicada", ex);
            }
        }
    }
}
