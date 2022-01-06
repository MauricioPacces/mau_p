using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegradeNegocio;

namespace WebApi.Controllers.Bloco
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtualizarBloco : ControllerBase
    {

        [HttpGet(Name = "AtualizarBloco")]

        public bool Atualizar(string nome, int IdCondominio, int Id)
        {
            BlocoNegocio BN = new BlocoNegocio();
            return BN.atualiza(IdCondominio, nome,Id);
        }

    }
}
