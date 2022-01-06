using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegradeNegocio;

namespace WebApi.Controllers.Bloco
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdicionarBloco : ControllerBase
    {

        [HttpGet(Name = "AdicionarBloco")]

        public bool incluir(string nome, int IdCondominio)
        {
            BlocoNegocio BN = new BlocoNegocio();
            return BN.incluir(IdCondominio, nome);
        }

    }
}
