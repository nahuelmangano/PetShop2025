using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public List<BE.Usuario> Usuarios()
        {


            List<BE.Usuario> listaDeRetorno = new List<BE.Usuario>();
            string nombreStoreProcedure = "sp_listar_usuarios";
            Conexion objConexion = new Conexion();

            DataTable dt = objConexion.LeerPorStoreProcedure(nombreStoreProcedure);


            BE.Usuario usuarioAuxiliar;
            foreach (DataRow fila in dt.Rows)
            {
                usuarioAuxiliar = new BE.Usuario();

                usuarioAuxiliar.ID = int.Parse(fila["id"].ToString());
                usuarioAuxiliar.Nombre = fila["nombre"].ToString();
                usuarioAuxiliar.Apellido= fila["apellido"].ToString();
                usuarioAuxiliar.Perfil = new BE.Perfil();
                usuarioAuxiliar.Perfil.ID = int.Parse(fila[2].ToString());
                usuarioAuxiliar.Perfil.Descripcion = fila[3].ToString();

                listaDeRetorno.Add(usuarioAuxiliar);
            }


            return listaDeRetorno;


        }

        public BE.Usuario ValidarUsuario(string email, string password)
        {
            string nombreStoreProcedure = "sp_validar_usuario";
            SqlParameter[] parametros = new SqlParameter[2];
            Conexion objConexion = new Conexion();
            parametros[0] = objConexion.crearParametro("@Email", email);
            parametros[1] = objConexion.crearParametro("@Password", password);

            DataTable dt = objConexion.LeerPorStoreProcedure(nombreStoreProcedure, parametros);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            BE.Usuario usuarioDeRetorno = new BE.Usuario();
            int primeraFila = 0;
            usuarioDeRetorno.ID = int.Parse(dt.Rows[primeraFila]["ID"].ToString());
            usuarioDeRetorno.Email = dt.Rows[primeraFila]["Email"].ToString();
            usuarioDeRetorno.Password = password;

            usuarioDeRetorno.Perfil = new BE.Perfil();
            usuarioDeRetorno.Perfil.ID = int.Parse(dt.Rows[primeraFila]["IdPerfil"].ToString());
            usuarioDeRetorno.Perfil.Descripcion = dt.Rows[primeraFila]["Descripcion"].ToString();

            return usuarioDeRetorno;
        }



    }
}
