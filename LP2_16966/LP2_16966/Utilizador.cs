// Autor: Diogo Rocha
// Email: a16966@alunos.ipca.pt
// Data: 2020/06/03
// Versão: 1
// Comentários: Classe de Utilizador

using System;

namespace BO
{
    //classe Utilizador
    [Serializable]
    public class Utilizador
    {
        #region VARIAVEIS
        int idade;
        string username, password;
        #endregion VARIAVEIS

        #region PROPRIEDADES

        public string Username { get => username; set => username = value; }

        public string Password { get => password; set => password = value; }

        public int Idade
        {

            get { return idade; }

            set
            {

                if (idade > 18)
                {

                    idade = value;

                }

            }
        }

        #endregion PROPRIEADADES

        #region CONSTRUTORES
        /// <summary>
        /// Construtor default da classe
        /// </summary>
        public Utilizador()
        {
            this.Username = default(string);
            this.Password = default(string);
            this.Idade = default(int);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="idade"></param>
        public Utilizador(string username, string password, int idade)
        {

            this.Username = username;
            this.Password = password;
            this.Idade = idade;

        }
        #endregion CONSTRUTORES

        #region OPERADORES

        /// <summary>
        /// Função que compara dois utilizadores
        /// </summary>
        /// <param name="obj">Objeto do tipo serie</param>
        /// <returns>Verdadeiro caso sejam iguais</returns>
        public override bool Equals(object obj)
        {
            Utilizador aux = (Utilizador)obj;
            return (this.Username == aux.Username);
        }

        /// <summary>
        /// Função para verificar se dois utlizadores são diferentes
        /// </summary>
        /// <param name="utilizador1">Serie 1</param>
        /// <param name="utilizador2">Serie 2</param>
        /// <returns>Verdadeiro caso seja</returns>
        public static bool operator !=(Utilizador utilizador1, Utilizador utilizador2)
        {
            return (!(utilizador1.Equals(utilizador2)));
        }

        /// <summary>
        /// Função para verificar se dois utilizadores são iguais
        /// </summary>
        /// <param name="utilizador1">Serie 1</param>
        /// <param name="utilizador2">Serie 2</param>
        /// <returns>Verdadeiro caso seja</returns>
        public static bool operator ==(Utilizador utilizador1, Utilizador utilizador2)
        {
            return (utilizador1.Equals(utilizador2));
        }

        public static implicit operator string(Utilizador v)
        {
            throw new NotImplementedException();
        }
        #endregion OPERADORES
    }


}

