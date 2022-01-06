using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegradeNegocio;

namespace WebApi.Controllers.Condominio
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcluirCondominio : ControllerBase
    {

        [HttpGet(Name = "ExcluirCondominio")]

        public bool Consutar(int Id)
        {
            CondominioNegocio AN = new CondominioNegocio();
            return AN.excluir(Id);
        }

    }
}
