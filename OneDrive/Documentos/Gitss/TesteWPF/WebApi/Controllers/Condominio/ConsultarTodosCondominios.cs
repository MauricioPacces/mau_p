using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegradeNegocio;

namespace WebApi.Controllers.Condominio
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultarTodosCondominios : ControllerBase
    {

        [HttpGet(Name = "ConsultarTodosCondominios")]

        public List<Models.Condominios> Consutar(int Id)
        {
            CondominioNegocio AN = new CondominioNegocio();
            return AN.consultarTodos();
        }

    }
}
