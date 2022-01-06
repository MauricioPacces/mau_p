using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegradeNegocio;

namespace WebApi.Controllers.Bloco
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcluirBloco : ControllerBase
    {

        [HttpGet(Name = "ExcluirBloco")]

        public bool Excluir(int Id)
        {
            BlocoNegocio AN = new BlocoNegocio();
            return AN.excluir(Id);
        }

    }
}
