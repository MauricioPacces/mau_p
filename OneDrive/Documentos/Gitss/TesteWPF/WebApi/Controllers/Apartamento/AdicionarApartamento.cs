using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegradeNegocio;

namespace WebApi.Controllers.Apartamento
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdicionarApartamento : ControllerBase
    {
        [HttpGet(Name = "AdicionarApartamento")]

        public bool incluir(string Andar, string Numero, int IdBloco)
        {
            ApartamentoNegocio AN = new ApartamentoNegocio();
            return AN.incluir(Andar, Numero, IdBloco);
        }

    }
}
