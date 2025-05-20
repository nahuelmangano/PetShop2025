using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BE.Usuario;

namespace DAL
{
    public class Usuario
    {
        public bool Alta(string nombre_usuario, string apellido_Usuario, string mail_Usuario, string password_Usuario, int perfil_Usuario)
        {

            Conexion db = new Conexion();
            string query = string.Format("INSERT INTO T_Usuario([nombre_Usuario],[apellido_Usuario], [mail_Usuario],[password_Usuario],[perfil_Usuario])" +
                "VALUES('{0}', '{1}', '{2}', '{3}', {4})", nombre_usuario, apellido_Usuario, mail_Usuario, password_Usuario, perfil_Usuario

                );
            db.EscribirPorComando(query);
            return true;
        }

        public void crear(BE.Usuario usuario)
        {
            Conexion db = new Conexion();
            string query = string.Format("INSERT INTO T_Usuario([nombre_Usuario],[apellido_Usuario], [mail_Usuario],[password_Usuario],[perfil_Usuario])" +
                "VALUES('{0}', '{1}', '{2}', '{3}', {4})", usuario.Nombre, usuario.Apellido, usuario.Email, usuario.Password, usuario.Perfil);
            db.EscribirPorComando(query);


        }

        public void modificar(BE.Usuario usuario)
        {
            Conexion db = new Conexion();
            string query = string.Format("INSERT INTO T_Usuario([nombre_Usuario],[apellido_Usuario], [mail_Usuario],[password_Usuario],[perfil_Usuario])" +
                "VALUES('{0}', '{1}', '{2}', '{3}', {4})", usuario.Nombre, usuario.Apellido, usuario.Email, usuario.Password, usuario.Perfil);
            db.EscribirPorComando(query);


        }

        public List<BE.Usuario> Listar()
        {

            Conexion db = new Conexion();

            List<BE.Usuario> usuarios = new List<BE.Usuario>();


            DataTable dt = db.LeerPorComando("Select mail_Usuario, password_Usuario From T_Usuario");


            foreach (DataRow fila in dt.Rows)
            {
                BE.Usuario unUsuario = new BE.Usuario();

                unUsuario.Password = fila["password_Usuario"].ToString();
                unUsuario.Email = fila["mail_Usuario"].ToString();

                usuarios.Add(unUsuario);



            }
            return usuarios;
        }



    }
}
