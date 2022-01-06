using Banco;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegradeNegocio
{
    public class ApartamentoNegocio
    {
        public bool incluir(string Andar,string Numero,int IdBloco)
        {
            Apartamento apartamentoincluir = new Apartamento();
            apartamentoincluir.andar = Andar;
            apartamentoincluir.numero = Numero;
            apartamentoincluir.IdBloco = IdBloco;

            ApartamentoBanco ABanco = new ApartamentoBanco();
            return ABanco.incluir(apartamentoincluir);
            
        }
        public bool excluir(int Id)
        {
            ApartamentoBanco ABanco = new ApartamentoBanco();
            return ABanco.excluir(Id);
        }
        public Apartamento consultar(int Id)
        {
            ApartamentoBanco ABanco = new ApartamentoBanco();
            return ABanco.consultar(Id);
            
        }
        public bool atualiza(string Andar, string Numero, int stringIdBloco, int Id)
        {

            Apartamento apartamentoAtualizar = new Apartamento();
            apartamentoAtualizar.andar = Andar;
            apartamentoAtualizar.numero = Numero;
            apartamentoAtualizar.IdBloco = stringIdBloco;
            apartamentoAtualizar.Id = Id;

            ApartamentoBanco ABanco = new ApartamentoBanco();
            return ABanco.atualiza(apartamentoAtualizar);
        }
        public List<Apartamento> consultarTodos()
        {
            ApartamentoBanco ABanco = new ApartamentoBanco();
            return ABanco.consultarTodos();

        }
    }
}
