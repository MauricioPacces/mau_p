using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegradeNegocio;

namespace WebApi.Controllers.Morador
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdicionarMorador : ControllerBase
    {

        [HttpGet(Name = "AdicionarMorador")]

        public bool incluir(string Nome, int IdApartamento, string nascimento, string CPF, string Email, string Telefone)
        {

            MoradorNegocio AN = new MoradorNegocio();
            return AN.incluir(Nome, IdApartamento, nascimento, CPF, Email, Telefone);   
        }

    }
}
