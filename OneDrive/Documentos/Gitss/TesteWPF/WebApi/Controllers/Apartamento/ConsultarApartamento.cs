using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegradeNegocio;

namespace WebApi.Controllers.Apartamento
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultarApartamento : ControllerBase
    {

        [HttpGet(Name = "ConsultarApartamento")]

        public Models.Apartamento Atualizar(int Id)
        {
            ApartamentoNegocio AN = new ApartamentoNegocio();
            return AN.consultar(Id);
        }

    }
}
