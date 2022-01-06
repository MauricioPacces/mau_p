using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegradeNegocio;

namespace WebApi.Controllers.Apartamento
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtualizarApartamento : ControllerBase
    {
        [HttpGet(Name = "AtualizarApartamento")]

        public bool Atualizar(string Andar, string Numero, int IdBloco, int Id)
        {
            ApartamentoNegocio AN = new ApartamentoNegocio();
            return AN.atualiza(Andar, Numero, IdBloco, Id);
        }
    }
}
