// Autor: Diogo Rocha
// Email: a16966@alunos.ipca.pt
// Data: 2020/06/03
// Versão: 1
// Comentários: Classe de Serie

using System;

namespace BO
{
    //classe Serie
    public enum TIPOSERIE { Drama, Comedia, Acao, Aventura };
    [Serializable]
    public class Serie
    {
        #region VARIAVEIS
        string tituloSerie, diretorSerie;
        float ratingSerie;
        int mesSerie, minutosEpisodio, anoSerie, idSerie, numeroEpisodios, numeroTemporadas;
        TIPOSERIE generoSerie;

        #endregion VARIAVEIS

        #region PROPRIEDADES
        public string TituloSerie { get => tituloSerie; set => tituloSerie = value; }
        public string DiretorSerie { get => diretorSerie; set => diretorSerie = value; }

        public TIPOSERIE GeneroSerie { get => generoSerie; set => generoSerie = value; }

        public float RatingSerie
        {

            get { return ratingSerie; }

            set
            {

                if (ratingSerie > 0 && ratingSerie <= 10)
                {

                    ratingSerie = value;

                }

            }

        }
        public int MesSerie { get => mesSerie; set => mesSerie = value; }
        public int MinutosEpisodio { get => minutosEpisodio; set => minutosEpisodio = value; }
        public int AnoSerie { get => anoSerie; set => anoSerie = value; }
        public int NumeroEpisodios { get => numeroEpisodios; set => numeroEpisodios = value; }
        public int NumeroTemporadas { get => numeroTemporadas; set => numeroTemporadas = value; }

        public int IdSerie
        {
            get { return idSerie; }

            set
            {
                if ((value.ToString()).Length == 4)
                {
                    Random rnd = new Random();
                    int aux = rnd.Next(1, 9999);
                    aux = idSerie;
                    idSerie = value;

                }

            }
        }
 
        #endregion PROPRIEDADES

        #region CONSTRUTORES
        public Serie()
        {

            this.TituloSerie = default(string);
            this.DiretorSerie = default(string);
            this.GeneroSerie = default(TIPOSERIE);
            this.RatingSerie = default(float);
            this.MesSerie = default(int);
            this.MinutosEpisodio = default(int);
            this.AnoSerie = default(int);
            this.NumeroEpisodios = default(int);
            this.NumeroTemporadas = default(int);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tituloserie"></param>
        /// <param name="diretorserie"></param>
        /// <param name="generoserie"></param>
        /// <param name="ratingserie"></param>
        /// <param name="messerie"></param>
        /// <param name="minutosEpisodio"></param>
        /// <param name="anoserie"></param>
        /// <param name="numeroepisodios"></param>
        /// <param name="numerotemporadas"></param>
        /// <param name="idserie"></param>
        public Serie(string tituloserie, string diretorserie, TIPOSERIE generoserie, float ratingserie, int messerie, int minutosEpisodio, int anoserie, int numeroepisodios, int numerotemporadas)
        {
            this.TituloSerie = tituloserie;
            this.DiretorSerie = diretorserie;
            this.GeneroSerie = generoserie;
            this.RatingSerie = ratingserie;
            this.MesSerie = messerie;
            this.MinutosEpisodio = minutosEpisodio;
            this.AnoSerie = anoserie;
            this.NumeroEpisodios = numeroepisodios;
            this.NumeroTemporadas = numerotemporadas;
           
        }
        #endregion CONSTRUTORES

        #region OPERADORES

        /// <summary>
        /// Função que compara duas séries
        /// </summary>
        /// <param name="obj">Objeto do tipo serie</param>
        /// <returns>Verdadeiro caso sejam iguais</returns>
        public override bool Equals(object obj)
        {
            Serie aux = (Serie)obj;
            return (this.IdSerie == aux.IdSerie);
        }

        /// <summary>
        /// Função para verificar se duas séries são diferentes
        /// </summary>
        /// <param name="serie1">Serie 1</param>
        /// <param name="serie2">Serie 2</param>
        /// <returns>Verdadeiro caso seja</returns>
        public static bool operator !=(Serie serie1, Serie serie2)
        {
            return (!(serie1.Equals(serie2)));
        }

        /// <summary>
        /// Função para verificar se duas series são iguais
        /// </summary>
        /// <param name="serie1">Serie 1</param>
        /// <param name="serie2">Serie 2</param>
        /// <returns>Verdadeiro caso seja</returns>
        public static bool operator ==(Serie serie1, Serie serie2)
        {
            return (serie1.Equals(serie2));
        }
        #endregion OPERADORES

    }

}
