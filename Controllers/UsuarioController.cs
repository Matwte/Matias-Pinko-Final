using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Manejadores;
using WebApplication4.Modelos;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpPut]
        public void Actualizar([FromBody] Usuario usuario)
        {
            ManejadorUsuario.UpdateUsuario(usuario);
        }

        [HttpGet("{usuario}/{passw}")]
        public Usuario Login(string usuario, string passw)
        {
            return ManejadorUsuario.Login(usuario, passw);
        }

        [HttpPost]
        public void InsertarUsuario(Usuario user)
        {
            ManejadorUsuario.InsertarUsuario(user);
        }

        [HttpGet("{id}")]
        public Usuario traerUsuario(long id)
        {
            return ManejadorUsuario.ObtenerUsuario(id);
        }

        [HttpDelete("{id}")]
        public void EliminarUsuario(long id)
        {
            ManejadorUsuario.DeleteUsuario(id);
        }
    }
}
