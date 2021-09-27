// Autor: Diogo Rocha
// Email: a16966@alunos.ipca.pt
// Data: 2020/06/03
// Versão: 1
// Comentários: Classe de Validar Filmes


using BO;
using DL;
using System.Collections.Generic;

namespace BR
{
    public class FilmesR
    {
        /// <summary>
        /// função que insere um novo filme, caso exista dá return false
        /// </summary>
        /// <param name="novoFilme"></param>
        /// <returns></returns>
        public static bool InsereFilme(string novoFilme)
        {
            //verifica se o determinado filme já existe
            if (Filmes.ExisteFilme(novoFilme))
                return false;

            return Filmes.InsereFilme(novoFilme);
        }

        /// <summary>
        /// Função que mostrará os dados do filme
        /// </summary>
        /// <param name="nomefilme"></param>
        /// <returns></returns>
        public static string MostraDadosFilme(string nomefilme)
        {
            return Filmes.MostraDadosFilme(nomefilme);
        }
        /// <summary>
        /// A função que remove o filme
        /// </summary>
        /// <param name="IDFilme"></param>
        /// <returns></returns>
        public static bool RemoveFilme(int IDFilme)
        {
            return Filmes.RemoveFilme(IDFilme);
        }
        /// <summary>
        /// Adicionar Favoritos
        /// </summary>
        /// <param name="novoFilme"></param>
        /// <returns></returns>
        public static List<Filme> RegistaFavoritoFilme(string novoFilme)
        {
            return Filmes.RegistaFavoritoFilme(novoFilme);
        }
    }
}
