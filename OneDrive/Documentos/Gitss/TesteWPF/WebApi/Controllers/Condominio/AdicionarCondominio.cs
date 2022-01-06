using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegradeNegocio;

namespace WebApi.Controllers.Condominio
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdicionarCondominio : ControllerBase
    {
        [HttpGet(Name = "AdicionarCondominio")]

        public bool incluir(string Telefone, string Nome, string EmailSindico)
        { 
        
            CondominioNegocio AN = new CondominioNegocio();
            return AN.incluir(Telefone, Nome, EmailSindico);
        }

    }
}
