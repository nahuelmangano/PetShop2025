using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Vacuna
    {
        Conexion conexion = new Conexion();

        public List<BE.Vacuna> ListarVacunas()
        {
            try
            {
                List<BE.Vacuna> lista = new List<BE.Vacuna>();

                DataTable dt = conexion.LeerPorStoreProcedure("usp_listar_vacunas");

                foreach (DataRow fila in dt.Rows)
                {
                    BE.Vacuna vacuna = new BE.Vacuna
                    {
                        ID = Convert.ToInt32(fila["Id"]),
                        Nombre = fila["Nombre"].ToString(),
                        CantidadDosis = Convert.ToInt32(fila["CantidadDosis"])
                    };

                    lista.Add(vacuna);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener vacunas", ex);
            }
        }

        public int InsertarVacuna(BE.Vacuna vacuna)
        {
            try
            {
                List<SqlParameter> parametros = new List<SqlParameter>
                {
                    conexion.crearParametro("@Nombre", vacuna.Nombre),
                    conexion.crearParametro("@CantidadDosis", vacuna.CantidadDosis)
                };

                return conexion.EscribirPorStoreProcedure("usp_insertar_vacuna", parametros.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar vacuna", ex);
            }
        }
    }
}
