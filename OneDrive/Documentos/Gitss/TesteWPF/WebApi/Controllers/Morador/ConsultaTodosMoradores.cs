using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegradeNegocio;

namespace WebApi.Controllers.Morador
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaTodosMoradores : ControllerBase
    {

        [HttpGet(Name = "ConsultaTodosMoradores")]

        public List<Models.Morador> Consutar(int Id)
        {
            MoradorNegocio AN = new MoradorNegocio();
            return AN.consultarTodos();
        }

    }
}
