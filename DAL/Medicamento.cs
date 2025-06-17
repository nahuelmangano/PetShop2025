using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Medicamento
    {
        private Conexion conexion = new Conexion();

        public List<BE.Medicamento> Listar()
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[] { };
                DataTable tabla = conexion.LeerPorStoreProcedure("SP_Medicamento_Listar", parametros);
                List<BE.Medicamento> listaMedicamentos = new List<BE.Medicamento>();
                foreach (DataRow fila in tabla.Rows)
                {
                    BE.Medicamento unMedicamento = new BE.Medicamento
                    {
                        ID = Convert.ToInt32(fila["Id"]),
                        Nombre = fila["Nombre"].ToString(),
                        StockActual = Convert.ToInt32(fila["StockActual"]),
                        StockMinimo = Convert.ToInt32(fila["StockMinimo"]),
                        //Estado = (BE.Medicamento.EstadoStock)Convert.ToInt32(fila["Estado"])
                    };
                    listaMedicamentos.Add(unMedicamento);
                }
                return listaMedicamentos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar medicamentos", ex);
            }
        }

        public bool Insertar(BE.Medicamento unMedicamento) {
            try
            {
                string nombreStoreProcedure = "SP_Medicamento_Insertar";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    conexion.crearParametro("@Nombre",unMedicamento.Nombre.Trim()),
                    conexion.crearParametro("@Descripcion","NADA"),
                    conexion.crearParametro("@StockActual",unMedicamento.StockActual),
                    conexion.crearParametro("@StockMinimo", unMedicamento.StockMinimo),
                    conexion.crearParametro("@Estado",unMedicamento.Estado.Descripcion)
                };
                //REFACTURE: Validar antes de escribir que el ingreso no se encuentre en la DB.
                int filasAfectadas = conexion.EscribirPorStoreProcedure(nombreStoreProcedure, parametros);
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar medicamento", ex);
            }
        }
    }
}
