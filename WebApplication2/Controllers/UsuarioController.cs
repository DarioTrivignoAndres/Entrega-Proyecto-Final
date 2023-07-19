using Microsoft.AspNetCore.Mvc;


namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UsuarioController : ControllerBase
    {

        [HttpGet(Name = "TraerUsuario")]
        public Usuario TraerUsuario_conNombreUsuario(string nombreUsuario)
        {
            return ADO_Usuario.TraerUsuario_conNombreUsuario(nombreUsuario);
        }



        [HttpPut(Name = "ModificarUsuario")]
        public bool ModificarUsuario([FromBody] PutUsuario usuario)
        {
            try
            {
                Usuario usuarioExistente = new Usuario();
                usuarioExistente = ADO_Usuario.TraerUsuario_conId(usuario.Id);
                if (usuarioExistente.Id <= 0)
                {
                    return false;
                }
                else
                {
                    return ADO_Usuario.usuarioExistente;
                    
                    {
                        Id = usuario.Id;
                        Nombre = usuario.Nombre;
                        Apellido = usuario.Apellido;
                        NombreUsuario = usuario.NombreUsuario;
                        Contraseña = usuario.Contraseña;
                        Mail = usuario.Mail;
                    }                    ;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        [HttpPost(Name = "CrearUsuario")]
        public bool CrearUsuario([FromBody] PostUsuario usuario)
        {
            try
            {
                return ADO_Usuario.CrearUsuario(new Usuario)
                    
                    {
                    Nombre = usuario.Nombre;
                    Apellido = usuario.Apellido;
                    NombreUsuario = usuario.NombreUsuario;
                    Contraseña = usuario.Contraseña;
                    Mail = usuario.Mail;
                    }
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        [HttpDelete(Name = "EliminarUsuario")]
        public bool EliminarUsuario([FromBody] long id)
        {
            try
            {
                return ADO_Usuario.EliminarUsuario(id);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}