using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegradeNegocio;

namespace WebApi.Controllers.Condominio
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultarCondominio : ControllerBase
    {

        [HttpGet(Name = "ConsultarCondominio")]

        public Models.Condominios Consutar(int Id)
        {
            CondominioNegocio AN = new CondominioNegocio();
            return AN.consultar(Id);
        }

    }
}
