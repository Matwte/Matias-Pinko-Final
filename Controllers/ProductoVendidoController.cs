using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Manejadores;
using WebApplication4.Modelos;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet("{idUsuario}")]
        public List<Producto> TraerProductosVendidos(long idUsuario)
        {
            return ManejadorProductoVendido.ObtenerProductosVendidos(idUsuario);
        }
    }
}
