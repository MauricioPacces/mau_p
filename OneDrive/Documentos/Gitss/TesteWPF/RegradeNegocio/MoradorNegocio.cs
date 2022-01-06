using Banco;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegradeNegocio
{
    public class MoradorNegocio
    {

        public bool incluir(string Nome, int IdApartamento, string nascimento, string CPF, string Email, string Telefone)
        {
            Morador apartamentoincluir = new Morador();
            apartamentoincluir.Nome = Nome;
            apartamentoincluir.CPF = CPF;
            apartamentoincluir.Nascimento = nascimento;
            apartamentoincluir.telefone = Telefone;
            apartamentoincluir.Email = Email;
            MoradorBanco MB = new MoradorBanco();
            return MB.incluir(apartamentoincluir);
            
        }
        public bool excluir(int Id)
        {
            MoradorBanco MB = new MoradorBanco();
            return MB.excluir(Id);
        }
        public Morador consultar(int Id)
        {
            MoradorBanco MB = new MoradorBanco();
            return MB.consultar(Id);
        }
        public bool Atualizar(string Nome, int IdApartamento, string nascimento, string CPF, string Email, string Telefone,int Id)
        {
            Morador apartamentoincluir = new Morador();
            apartamentoincluir.Nome = Nome;
            apartamentoincluir.CPF = CPF;
            apartamentoincluir.Nascimento = nascimento;
            apartamentoincluir.telefone = Telefone;
            apartamentoincluir.Email = Email;
            apartamentoincluir.Id = Id;
            MoradorBanco MB = new MoradorBanco();
            return MB.atualiza(apartamentoincluir);

        }
        public List<Morador> consultarTodos()
        {
            MoradorBanco MB = new MoradorBanco();
            return MB.consultarTodos();
        }
        //public List<Morador> consultaTodos()
        //{

        //}
    }
}
