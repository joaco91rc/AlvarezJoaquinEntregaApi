using CapaEntidad;
using CapaNegocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CapaDatos;
using System.Configuration;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [HttpGet(Name = "GetUsuarios") ]
        public IEnumerable<Usuario> GetUsuarios()
        {
            

                // Aquí puedes utilizar la cadena de conexión y consultar la lista de usuarios
                List<Usuario> usuarios = new CN_Usuario().ListarUsuarios();

                return usuarios.ToArray();
            
            
        }
    }
}
