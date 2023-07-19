using Microsoft.AspNetCore.Mvc;
using WebApplication2.Controllers;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class LoginUsuarioController : ControllerBase
    {

        [HttpGet(Name = "InicioDeSesion")]
        public Usuario InicioDeSesion(string nombreUsuario, string contraseña)
        {
            return ADO_Usuario.InicioDeSesion(nombreUsuario, contraseña);
        }
    }
}
