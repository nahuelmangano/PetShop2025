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

        public List<BE.Medicamento> ListarMedicamentos()
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[] { };
                DataTable tabla = conexion.LeerPorStoreProcedure("usp_listar_medicamentos", parametros);
                List<BE.Medicamento> listaMedicamentos = new List<BE.Medicamento>();

                foreach (DataRow fila in tabla.Rows)
                {
                    BE.EstadoStock estado = new BE.EstadoStock
                    {
                        ID = Convert.ToInt32(fila["EstadoStockId"]),
                        Descripcion = fila["EstadoStock"].ToString()
                    };

                    BE.Medicamento unMedicamento = new BE.Medicamento
                    {
                        ID = Convert.ToInt32(fila["Id"]),
                        Nombre = fila["Nombre"].ToString(),
                        Descripcion = fila["Descripcion"].ToString(),
                        StockActual = Convert.ToInt32(fila["StockActual"]),
                        StockMinimo = Convert.ToInt32(fila["StockMinimo"]),
                        Estado = estado
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

        public bool InsertarMedicamento(BE.Medicamento unMedicamento) {
            
                string nombreStoreProcedure = "usp_insertar_medicamento";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    conexion.crearParametro("@Nombre",unMedicamento.Nombre.Trim()),
                   
                    conexion.crearParametro("@StockActual",unMedicamento.StockActual),
                    conexion.crearParametro("@StockMinimo", unMedicamento.StockMinimo),
                    conexion.crearParametro("@EstadoStockId",unMedicamento.Estado.ID),
                    conexion.crearParametro("@Descripcion", unMedicamento.Descripcion.Trim())
                };
                //REFACTURE: Validar antes de escribir que el ingreso no se encuentre en la DB.
                int filasAfectadas = conexion.EscribirPorStoreProcedure(nombreStoreProcedure, parametros);
                return filasAfectadas > 0;
            }
           
        }
    }

