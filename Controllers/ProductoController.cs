using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Manejadores;
using WebApplication4.Modelos;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpPost]
        public void IngresarProducto(Producto producto)
        {
            ManejadorProducto.InsertarProducto(producto);
        }

        [HttpPut]
        public void Actualizar([FromBody] Producto producto)
        {
            ManejadorProducto.UpdateProducto(producto);
        }

        [HttpDelete("{id}")]
        public void EliminarProducto(long id)
        {
            ManejadorProducto.DeleteProducto(id);
        }

        [HttpGet("{id}")]
        public Producto GetProducto(long id)
        {
            return ManejadorProducto.ObtenerProducto(id);
        }
    }
}
