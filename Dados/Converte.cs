using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Converte
    {
        public static filmes ToFilme(FilmeVO filmeVo)
        {
            return new filmes()
            {
                id = filmeVo.id,
                nome = filmeVo.nome,
                genero = filmeVo.genero,
                anoLancamento = filmeVo.anoLancamento
            };
        }

        public static FilmeVO ToFilmeVO(filmes filme)
        {
            return new FilmeVO()
            {
                id = filme.id,
                nome = filme.nome,
                genero = filme.genero,
                anoLancamento = (int)filme.anoLancamento

            };
        }
    }
}


