using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Manejadores;
using WebApplication4.Modelos;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpPost("{idusuario}")]
        public void CrearVenta(List<Producto> productos, long idUsuario)
        {
            ManejadorVenta.InsertarVenta(productos, idUsuario);
        }

        [HttpGet("{idUsuario}")]
        public List<Venta> TraerVentas(long idUsuario)
        {
            return ManejadorVenta.ObtenerVentas(idUsuario);
        }
    }
}
