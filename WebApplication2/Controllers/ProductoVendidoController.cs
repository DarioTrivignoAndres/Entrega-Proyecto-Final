using Microsoft.AspNetCore.Mvc;
using WebApplication2.Controllers;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ProductoVendidoController : ControllerBase
    {

        [HttpGet(Name = "TraerProductosVendidos")]
        public List<ProductoVendido> TraerProductosVendidos_conIdUsuario(long idUsuario)
        {
            return ADO_ProductoVendido.TraerProductosVendidos_conIdUsuario(idUsuario);
        }
    }
}
