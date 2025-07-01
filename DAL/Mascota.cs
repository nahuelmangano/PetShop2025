using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mascota
    {
        Conexion conexion = new Conexion();

        public bool InsertarMascota(BE.Mascota unaMascota)
        {
            // Aquí deberías implementar la lógica para insertar la mascota en tu base de datos
            // Por ahora, retornaremos true como ejemplo
            return true;
        }

        public List<BE.Mascota> ListarMascotas()
        {
            List<BE.Mascota> listaMascotas = new List<BE.Mascota>();

            Conexion conexion = new Conexion();
            DataTable tabla = conexion.LeerPorStoreProcedure("usp_listar_mascotas");

            foreach (DataRow fila in tabla.Rows)
            {
                BE.Mascota mascota = new BE.Mascota
                {
                    ID = Convert.ToInt32(fila["MascotaId"]),
                    Nombre = fila["MascotaNombre"].ToString(),
                    Sexo = fila["Sexo"].ToString(),
                    Peso = Convert.ToInt32(fila["Peso"]),
                    FechaNacimiento = Convert.ToDateTime(fila["FechaNacimiento"]),
                    Especie = fila["Especie"].ToString(),
                    Raza = fila["Raza"].ToString(),
                    Color = fila["Color"].ToString(),
                    Esterilizada = Convert.ToBoolean(fila["Esterilizada"]),
                    Propietario = new BE.Cliente
                    {
                        ID = Convert.ToInt32(fila["UsuarioId"]),
                        Nombre = fila["UsuarioNombre"].ToString(),
                        Apellido = fila["UsuarioApellido"].ToString(),
                        Email = fila["Email"].ToString(),
                        DNI = Convert.ToInt32(fila["ClienteDNI"]),
                        Perfil = new BE.Perfil
                        {
                            ID = Convert.ToInt32(fila["PerfilId"])
                        }
                    }
                };

                listaMascotas.Add(mascota);
            }

            return listaMascotas;
        }
    }
}
