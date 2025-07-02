using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Productos
    {
        public List<BE.Productos> ListarProductos()
        {
            List<BE.Productos> lista = new List<BE.Productos>();
            Conexion db = new Conexion();

            DataTable dt = db.LeerPorStoreProcedure("usp_listar_productos");

            foreach (DataRow fila in dt.Rows)
            {
                var producto = new BE.Productos
                {
                    ID = Convert.ToInt32(fila["Id"]),
                    Nombre = fila["Nombre"].ToString(),
                    Descripcion = fila["Descripcion"].ToString(),
                    Precio = Convert.ToDecimal(fila["Precio"]),
                    Categoria = fila["Categoria"].ToString(),
                    Stock = Convert.ToInt32(fila["Stock"])
                };

                lista.Add(producto);
            }

            return lista;
        }

    }
}
