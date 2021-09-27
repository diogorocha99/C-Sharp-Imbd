// Autor: Diogo Rocha
// Email: a16966@alunos.ipca.pt
// Data: 2020/06/03
// Versão: 1
// Comentários: Classe de Filme


using System;

namespace BO
{
    //classe Filme
    public enum TIPOFILME { Drama, Comedia, Acao, Aventura };
    [Serializable]
    public class Filme
    {
        #region VARIAVEIS
        string titulo, diretor;
        TIPOFILME genero;
        float rating;
        int mesFilme, minutosFilme, anoFilme, idFilme;


        #endregion VARIAVEIS

        #region PROPRIEDADES
        public string Titulo { get => titulo; set => titulo = value; }
        public string Diretor { get => diretor; set => diretor = value; }
        public TIPOFILME Genero { get => genero; set => genero = value; }

        public float Rating
        {

            get { return rating; }

            set
            {

                if (rating > 0 && rating <= 10)
                {

                    rating = value;

                }

            }

        }
        public int MesFilme { get => mesFilme; set => mesFilme = value; }
        public int MinutosFilmme { get => minutosFilme; set => minutosFilme = value; }
        public int AnoFilme { get => anoFilme; set => anoFilme = value; }

        public int IdFilme
        {
            get { return idFilme; }

            set
            {
                if ((value.ToString()).Length == 4)
                {
                    Random rnd = new Random();
                    int aux = rnd.Next(1, 9999);
                    aux = idFilme;
                    idFilme = value;

                }

            }
        }


        #endregion PROPRIEDADES

        #region CONSTRUTORES

        /// <summary>
        /// Construtor default da classe
        /// </summary>
        public Filme()
        {

            this.Titulo = default(string);
            this.Diretor = default(string);
            this.Genero = default(TIPOFILME);
            this.Rating = default(float);
            this.MesFilme = default(int);
            this.MinutosFilmme = default(int);
            this.AnoFilme = default(int);
            this.IdFilme = default(int);


        }
        
        public Filme(string titulo, string diretor, TIPOFILME genero, float rating, int mesfilme, int minutosfilme, int anofilme, int idfilme)
        {
            this.Titulo = titulo;
            this.Diretor = diretor;
            this.Genero = genero;
            this.Rating = rating;
            this.MesFilme = mesfilme;
            this.MinutosFilmme = minutosfilme;
            this.AnoFilme = anofilme;
            this.IdFilme = idfilme;
        }
        #endregion CONSTRUTORES

        #region OPERADORES

        /// <summary>
        /// Função que compara dois filmes
        /// </summary>
        /// <param name="obj">Objeto do tipo filme</param>
        /// <returns>Verdadeiro caso sejam iguais</returns>
        public override bool Equals(object obj)
        {
            Filme aux = (Filme)obj;
            return (this.IdFilme == aux.IdFilme);
        }

        /// <summary>
        /// Função para verificar se dois filmes são diferentes
        /// </summary>
        /// <param name="filme1">Filme 1</param>
        /// <param name="filme2">Filme 2</param>
        /// <returns>Verdadeiro caso seja</returns>
        public static bool operator !=(Filme filme1, Filme filme2)
        {
            return (!(filme1.Equals(filme2)));
        }

        /// <summary>
        /// Função para verificar se dois filmes são iguais
        /// </summary>
        /// <param name="filme1">Filme 1</param>
        /// <param name="filme2">Filme 2</param>
        /// <returns>Verdadeiro caso seja</returns>
        public static bool operator ==(Filme filme1, Filme filme2)
        {
            return (filme1.Equals(filme2));
        }


        #endregion
    }
}
