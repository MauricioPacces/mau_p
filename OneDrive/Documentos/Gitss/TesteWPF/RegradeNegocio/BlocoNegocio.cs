using Banco;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegradeNegocio
{
    public class BlocoNegocio
    {
        public bool incluir(int IdCondominio, string nome)
        {
            Bloco Bl = new Bloco();
            Bl.Nome = nome;
            Bl.IdCondominios = IdCondominio;
            BlocoBanco BB = new BlocoBanco();
            return BB.incluir(Bl);
            
        }
        public bool excluir(int Id)
        {
            BlocoBanco BB = new BlocoBanco();
            return BB.excluir(Id);
        }
        public Bloco consultar(int Id)
        {
            BlocoBanco BB = new BlocoBanco();
            return BB.consultar(Id);
        }
        public bool atualiza(int IdCondominio, string nome, int Id)
        {
            Bloco Bl = new Bloco();
            Bl.Nome = nome;
            Bl.IdCondominios = IdCondominio;
            Bl.Id = Id;
            BlocoBanco BB = new BlocoBanco();
            return BB.atualiza(Bl);
        }

        public List<Bloco> consultarTodos()
        {
            BlocoBanco BB = new BlocoBanco();
            return BB.consultarTodos();
        }
    }
}
