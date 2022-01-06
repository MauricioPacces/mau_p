using Banco;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegradeNegocio
{
    public class CondominioNegocio
    {
        public bool incluir(string Telefone, string Nome, string EmailSindico)
        {
            Condominios apartamentoincluir = new Condominios();
            apartamentoincluir.Telefone = Telefone;
            apartamentoincluir.Nome = Nome;
            apartamentoincluir.EmailSindico = EmailSindico;
            CondominioBanco CB = new CondominioBanco();
            return CB.incluir(apartamentoincluir);
        }
        public bool excluir(int Id)
        {
            CondominioBanco CB = new CondominioBanco();
            return CB.excluir(Id);
        }
        public Condominios consultar(int Id)
        {
            CondominioBanco CB = new CondominioBanco();
            return CB.consultar(Id);
        }
        public bool atualiza(string Telefone, string Nome, string EmailSindico, int Id)
        {
            Condominios apartamentoincluir = new Condominios();
            apartamentoincluir.Telefone = Telefone;
            apartamentoincluir.Nome = Nome;
            apartamentoincluir.EmailSindico = EmailSindico;
            apartamentoincluir.Id = Id;
            CondominioBanco CB = new CondominioBanco();
            return CB.atualiza(apartamentoincluir);
        }
        public List<Condominios> consultarTodos()
        {
            CondominioBanco CB = new CondominioBanco();
            return CB.consultarTodos();
        }


    }
}
