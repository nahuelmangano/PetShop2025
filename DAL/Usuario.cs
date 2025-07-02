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
     

        /*
         * METODO VIEJO DE CREAR USUARIO
        public void crear(BE.Usuario usuario)
        {
            Conexion db = new Conexion();
            string query = string.Format("INSERT INTO T_Usuario([nombre_Usuario],[apellido_Usuario], [mail_Usuario],[password_Usuario],[perfil_Usuario])" +
                "VALUES('{0}', '{1}', '{2}', '{3}', {4})", usuario.Nombre, usuario.Apellido, usuario.Email, usuario.Password, usuario.Perfil);
            db.EscribirPorComando(query);


        }
        */
        public bool CrearUsuario(BE.Usuario usuario)
        {
            string nombreStoreProcedure = "sp_insertar_usuario";
            SqlParameter[] parametros = new SqlParameter[5];
            Conexion objConexion = new Conexion();

            parametros[0] = objConexion.crearParametro("@nombre", usuario.Nombre);
            parametros[1] = objConexion.crearParametro("@apellido", usuario.Apellido);
            parametros[2] = objConexion.crearParametro("@email", usuario.Email);
            parametros[3] = objConexion.crearParametro("@password", usuario.Password);
            parametros[4] = objConexion.crearParametro("@perfil", usuario.Perfil.ID);

            // Ejecutar el SP. Suponiendo que tenés un método que devuelve filas afectadas:
           
            int filasAfectadas = objConexion.EscribirPorStoreProcedure(nombreStoreProcedure, parametros);

            return filasAfectadas > 0; // True si se insertó correctamente
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
                usuarioAuxiliar.Email = fila["email"].ToString();
                usuarioAuxiliar.Password = fila["Password"].ToString();
                usuarioAuxiliar.Perfil = new BE.Perfil();
                usuarioAuxiliar.Perfil.ID = int.Parse(fila[0].ToString());
                usuarioAuxiliar.Perfil.Descripcion = fila[1].ToString();

                listaDeRetorno.Add(usuarioAuxiliar);
            }


            return listaDeRetorno;


        }

        public BE.Usuario ValidarUsuario(string email, string password)
        {
            string nombreStoreProcedure = "usp_validar_usuario";
            SqlParameter[] parametros = new SqlParameter[2];
            Conexion objConexion = new Conexion();
            parametros[0] = objConexion.crearParametro("@Email", email);
            parametros[1] = objConexion.crearParametro("@Password", password);

            DataTable dt = objConexion.LeerPorStoreProcedure(nombreStoreProcedure, parametros);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            BE.Usuario usuarioDeRetorno = new BE.Usuario();
            int primeraFila = 0;
            usuarioDeRetorno.ID = int.Parse(dt.Rows[primeraFila]["Id"].ToString());
            usuarioDeRetorno.Email = dt.Rows[primeraFila]["Email"].ToString();
            usuarioDeRetorno.Password = password;

            usuarioDeRetorno.Perfil = new BE.Perfil();
            usuarioDeRetorno.Perfil.ID = int.Parse(dt.Rows[primeraFila]["PerfilId"].ToString());
            usuarioDeRetorno.Perfil.Descripcion = dt.Rows[primeraFila]["Descripcion"].ToString();

            return usuarioDeRetorno;
        }

        public bool ActualizarUsuario(BE.Usuario usuario) {
            string nombreStoreProcedure = "sp_EditarUsuario";
            SqlParameter[] parametros = new SqlParameter[6];
            Conexion objConexion = new Conexion();

            parametros[0] = objConexion.crearParametro("@id", usuario.ID);
            parametros[1] = objConexion.crearParametro("@nombre", usuario.Nombre);
            parametros[2] = objConexion.crearParametro("@apellido", usuario.Apellido);
            parametros[3] = objConexion.crearParametro("@email", usuario.Email);
            parametros[4] = objConexion.crearParametro("@password", usuario.Password);
            parametros[5] = objConexion.crearParametro("@perfil", usuario.Perfil.ID);

            // Ejecutar el SP. Suponiendo que tenés un método que devuelve filas afectadas:

            int filasAfectadas = objConexion.EscribirPorStoreProcedure(nombreStoreProcedure, parametros);

            return filasAfectadas > 0; // True si se insertó correctamente



        }



    }
}
