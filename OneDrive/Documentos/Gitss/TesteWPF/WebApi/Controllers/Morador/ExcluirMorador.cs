using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegradeNegocio;

namespace WebApi.Controllers.Morador
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcluirMorador : ControllerBase
    {

        [HttpGet(Name = "ExcluirMorador")]

        public bool Excluir(int Id)
        {
            MoradorNegocio AN = new MoradorNegocio();
            return AN.excluir(Id);
        }


    }
}
