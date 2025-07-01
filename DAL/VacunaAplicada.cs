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
                    conexion.crearParametro("@MascotaID", idMascota)
                };

                DataTable dt = conexion.LeerPorStoreProcedure("usp_listar_vacunas_aplicadas_por_mascota", parametros);

                foreach (DataRow fila in dt.Rows)
                {
                    BE.VacunaAplicada va = new BE.VacunaAplicada
                    {
                        ID = Convert.ToInt32(fila["Id"]),
                        NumeroDosis = Convert.ToInt32(fila["NumeroDosis"]),
                        FechaAplicacion = Convert.ToDateTime(fila["FechaAplicacion"]),
                        Vacuna = new BE.Vacuna
                        {
                            ID = Convert.ToInt32(fila["VacunaId"]),
                            Nombre = fila["Nombre"].ToString(),
                            CantidadDosis = Convert.ToInt32(fila["CantidadDosis"])
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

        public int InsertarVacunaAplicada(BE.VacunaAplicada vacunaAplicada)
        {
            try
            {
                List<SqlParameter> parametros = new List<SqlParameter>
                {
                    conexion.crearParametro("@NumeroDosis", vacunaAplicada.NumeroDosis),
                    conexion.crearParametro("@FechaAplicacion", vacunaAplicada.FechaAplicacion),
                    conexion.crearParametro("@MascotaId", vacunaAplicada.Mascota.ID),
                    conexion.crearParametro("@VacunaId", vacunaAplicada.Vacuna.ID)
                };

                return conexion.EscribirPorStoreProcedure("usp_insertar_vacuna_aplicada", parametros.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar vacuna aplicada", ex);
            }
        }
    }
}
