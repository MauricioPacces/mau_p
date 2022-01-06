using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegradeNegocio;

namespace WebApi.Controllers.Morador
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtualizarMorador : ControllerBase
    {
        [HttpGet(Name = "AtualizarMorador")]
        public bool Atualiza(string Nome, int IdApartamento, string nascimento, string CPF, string Email, string Telefone,int Id)
        {

            MoradorNegocio AN = new MoradorNegocio();
            return AN.Atualizar(Nome, IdApartamento, nascimento, CPF, Email, Telefone, Id);   
        }

}
}
