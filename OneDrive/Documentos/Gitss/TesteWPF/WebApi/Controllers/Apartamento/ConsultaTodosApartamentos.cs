using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegradeNegocio;

namespace WebApi.Controllers.Apartamento
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaTodosApartamentos : ControllerBase
    {

        [HttpGet(Name = "ConsultaTodosApartamentos")]

        public List<Models.Morador> ConsutarTodos(int Id)
        {
            MoradorNegocio AN = new MoradorNegocio();
            return AN.consultarTodos();
        }

    }
}
