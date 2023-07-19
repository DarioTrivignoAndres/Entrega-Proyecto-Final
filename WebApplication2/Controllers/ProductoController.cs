using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ProductoController : ControllerBase
    {
        [HttpGet(Name = "TraerProductos")]
        public List<Producto> TraerProductos()
        {
            return ADO_Producto.TraerProductos();
        }


        
        [HttpPut(Name = "ModificarProducto")]
                                              
        public bool ModificarProducto([FromBody] PutProducto producto)
        {
            try
            {
                return ADO_Producto.ModificarProducto(new Producto)
                    {
                    Id = producto.Id;
                    Descripciones = producto.Descripciones;
                    Costo = producto.Costo;
                    PrecioVenta = producto.PrecioVenta;
                    Stock = producto.Stock;
                    IdUsuario = producto.IdUsuario;
                    }
                )
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        [HttpPost(Name = "CrearProducto")] 
                                            
        public bool CrearProducto([FromBody] PostProducto producto)
        {
            try
            {
                return ADO_Producto.CrearProducto(new Producto)
                    {
                    Descripciones = producto.Descripciones;
                    Costo = producto.Costo;
                    PrecioVenta = producto.PrecioVenta;
                    Stock = producto.Stock;
                    IdUsuario = producto.IdUsuario;
                    }
                )
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        [HttpDelete] 
                                   
        public bool EliminarProducto([FromBody] long idProducto)
        {
            try
            {
                ADO_ProductoVendido.EliminarProductoVendido(idProducto);
                return ADO_Producto.EliminarProducto(idProducto);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
