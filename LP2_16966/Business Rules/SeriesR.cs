// Autor: Diogo Rocha
// Email: a16966@alunos.ipca.pt
// Data: 2020/06/03
// Versão: 1
// Comentários: Classe de Series



using BO;
using DL;
using System.Collections.Generic;


namespace BR
{
    public class SeriesR
    {
        /// <summary>
        /// função que insere um nova serie, caso exista dá return false
        /// </summary>
        /// <param name="novaSerie"></param>
        /// <returns></returns>
        public static bool InsereSerie(string novaSerie)
        {
            //verifica se o determinado filme já existe
            if (Series.ExisteSerie(novaSerie))
                return false;

            return Series.InsereSerie(novaSerie);
        }

        /// <summary>
        /// Função que mostrará os dados da Serie
        /// </summary>
        /// <param name="nomeserie"></param>
        /// <returns></returns>
        public static string MostraDadosSeries(string nomeserie)
        {
            return Series.MostraDadosSeries(nomeserie);
        }
        /// <summary>
        /// A função que remove a serie
        /// </summary>
        /// <param name="IDFilme"></param>
        /// <returns></returns>
        public static bool RemoveSerie(int IDSerie)
        {
            return Series.RemoveSerie(IDSerie);
        }

        /// <summary>
        /// Adicionar Favoritos
        /// </summary>
        /// <param name="novoFilme"></param>
        /// <returns></returns>
        public static List<Serie> RegistaFavoritoSerie(string novaSerie)
        {
            return Series.RegistaFavoritoSerie(novaSerie);
        }
    }
}
