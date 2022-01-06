using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegradeNegocio;

namespace WebApi.Controllers.Apartamento
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcluirApartamento : ControllerBase
    {

        [HttpGet(Name = "ExcluirApartamento")]

        public bool Atualizar(int Id)
        {
            ApartamentoNegocio AN = new ApartamentoNegocio();
            return AN.excluir(Id);
        }

    }
}
