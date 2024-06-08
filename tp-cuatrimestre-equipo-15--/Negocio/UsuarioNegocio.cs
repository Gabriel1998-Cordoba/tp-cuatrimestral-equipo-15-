using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
   public class UsuarioNegocio
    {
        private AccesoDatos accesoDatos = new AccesoDatos();
        public List<Usuario> listar()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            try
            {
                accesoDatos.setearConsulta(
                 "     SELECT U.Id,U.NombreUsuario,U.Contrasenia,U.Email,U.Tipo from Usuarios U " 
                );
                accesoDatos.ejecutarLectura();
                while (accesoDatos.Lector.Read())
                {
                 Usuario usuario = new Usuario();

                   usuario.ID = (int)accesoDatos.Lector["U.Id"];
                   usuario.Nombre = (string)accesoDatos.Lector["U.NombreUsuario"];
                    usuario.Contraseña = (string)accesoDatos.Lector["U.Contrasenia"];
                   usuario.Email = (string)accesoDatos.Lector["U.Email"];
                    usuario.TipoUsuario = (bool)accesoDatos.Lector["U.Tipo"];
           
                    listaUsuarios.Add(usuario);
                }
                return listaUsuarios;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

        public void Agregar(Usuario usuario)
        {
           
            try
            {
                accesoDatos.setearConsulta(
                    "INSERT INTO Usuarios (NombreUsuario,Email,Contrasenia, Tipo) " +
                    "VALUES (@NombreUsuario, @Email, @Contrasenia, @Tipo)"
                );
               
                accesoDatos.setearParametros("@NombreUsuario", usuario.Nombre);
                accesoDatos.setearParametros("@Email", usuario.Email);
                accesoDatos.setearParametros("@Contrasenia",usuario.Contraseña);
                accesoDatos.setearParametros("@Tipo", usuario.TipoUsuario);              
              accesoDatos.ejecutarAccion ();
              
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
        public void Modificar(Usuario usuario)
        {
            try
            {
                accesoDatos.setearConsulta("UPDATE Usuarios SET NombreUsuario=@NombreUsuario, Email=@Email,Contrasenia=@Contrasenia,Tipo=@Tipo WHERE ID =" + usuario.ID);

                accesoDatos.setearParametros("@NombreUsuario", usuario.Nombre);
                accesoDatos.setearParametros("@Email", usuario.Email);
                accesoDatos.setearParametros("@Contrasenia", usuario.Contraseña);
                accesoDatos.setearParametros("@Tipo", usuario.TipoUsuario);
                accesoDatos.ejecutarAccion();

            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
        public void eliminar(Usuario usuario)
        {
            try
            {
                accesoDatos.setearConsulta("DELETE FROM Usuarios WHERE ID = @ID");
                accesoDatos.setearParametros("@ID", usuario.ID);
                accesoDatos.ejecutarAccion();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
