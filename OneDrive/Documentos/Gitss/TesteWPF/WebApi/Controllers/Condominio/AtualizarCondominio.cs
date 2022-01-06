using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using RegradeNegocio;

namespace WebApi.Controllers.Condominio
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtualizarCondominio : ControllerBase
    {

        [HttpGet(Name = "AtualizarCondominio")]

        public bool atualiza(string Telefone, string Nome, string EmailSindico, int Id)
        {

            CondominioNegocio AN = new CondominioNegocio();
            return AN.atualiza(Telefone, Nome, EmailSindico,Id);
                //(Telefone, Nome, EmailSindico, Id);
        }

    }
}
