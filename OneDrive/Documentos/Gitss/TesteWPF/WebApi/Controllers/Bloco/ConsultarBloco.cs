using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegradeNegocio;

namespace WebApi.Controllers.Bloco
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultarBloco : ControllerBase
    {

        [HttpGet(Name = "ConsultarBloco")]

        public Models.Bloco Consultar(int Id)
        {
            BlocoNegocio AN = new BlocoNegocio();
            return AN.consultar(Id);
        }

    }
}
