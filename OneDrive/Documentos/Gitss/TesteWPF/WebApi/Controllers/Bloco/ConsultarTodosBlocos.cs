using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegradeNegocio;

namespace WebApi.Controllers.Bloco
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultarTodosBlocos : ControllerBase
    {
        [HttpGet(Name = "ConsultarTodosBlocos")]

        public List<Models.Bloco> Atualizar()
        {
            BlocoNegocio AN = new BlocoNegocio();
            return AN.consultarTodos();
        }
    }
}
