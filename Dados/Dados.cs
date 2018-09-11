using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Dados
    {
        public bool Inserir(FilmeVO filmeVO)
        {
            FilmeEntities context = new FilmeEntities();
            context.filmes.Add(Converte.ToFilme(filmeVO));
            int retorno = context.SaveChanges(); // irá retornar qts linhas foram afetadas

            if (retorno == 1) // caso afetar uma linha return verdadeiro
                return true;

            return false; // senão retorna falso
        }
    }
}
