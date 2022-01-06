using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegradeNegocio;

namespace WebApi.Controllers.Morador
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultarMorador : ControllerBase
    {

        [HttpGet(Name = "ConsultarMorador")]

        public Models.Morador Consutar(int Id)
        {
            MoradorNegocio AN = new MoradorNegocio();
            return AN.consultar(Id);
        }

    }
}
