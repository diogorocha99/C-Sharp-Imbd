// Autor: Diogo Rocha
// Email: a16966@alunos.ipca.pt
// Data: 2020/06/03
// Versão: 1
// Comentários: Classe de Utilizadores

using BO;
using System;
using System.Collections.Generic;
using System.IO;


namespace DL
{
    public class Utilizadores
    {
        #region ESTADO

        static List<Utilizador> listaUtilizadores;

        public Utilizadores()
        {
            listaUtilizadores = new List<Utilizador>();
            LoadData();
        }
        #endregion

        #region CONSTRUTORES
        /// <summary>
        /// Construtor para utilizadores
        /// </summary>
        static Utilizadores()
        {
            listaUtilizadores = new List<Utilizador>();

        }

        #region PROPRIEDADES
        /// <summary>
        /// Função que define ou entao devolve a l
        /// </summary>
        public static List<Utilizador> ListaUtilizadores
        {
            get { return listaUtilizadores; }
            set { listaUtilizadores = value; }
        }

        #endregion

        #endregion

        #region METODOS PUBLICOS UTILIZADOR

        /// <summary>
        /// Regista um novo cliente
        /// </summary>
        /// <param name="novoUtilizador"></param>
        /// <returns></returns>
        public static bool InsereUtilizador(Utilizador novoUtilizador)
        {
            bool x = false;
            try
            {

                listaUtilizadores.Add(novoUtilizador);
                x = true;

            }
            catch (Exception s)
            {
                throw new Exception("Já existe uma conta", s);

            }

            return x;
        }
        /// <summary>
        /// VÊ se a determinada pessoa existe
        /// </summary>
        /// <param name="utilizador"></param>
        /// <returns></returns>
        public static bool ExisteUtilizador(string username)
        {
            try
            {
                foreach (Utilizador u in listaUtilizadores)
                {
                    if (u.Username == username)      
                        return true;
                }

                return false;
            }
            catch (Exception s)
            {

                throw new Exception("Já existe utilizador", s);
            }
        }
        /// <summary>
        /// Função que permitirá alterar a data do utilizador, username e password
        /// </summary>
        /// <param name="u"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static public bool ChangeUserData(Utilizador u, string username, string password, int idade)
        {

            bool x = false;
            try
            {
                if (u.Username == username && u.Password == password && u.Idade== idade) 
                {
                    return false;
                }
            }
            catch (Exception s)
            {
                throw new Exception("Voce inseriu o mesmo username ou o username de outra pessoa assim como a password", s);

            }

            foreach (Utilizador e in listaUtilizadores)
            {

                if (e == u)
                { 
                    e.Username = username;
                    e.Password = password;
                    e.Idade = idade;

                    u.Username = e.Username;
                    u.Password = e.Password;
                    u.Idade = e.Idade;
                    x = true;
                    break;
                }
            }
            return x;
        }



        #endregion METODOS PUBLICOS UTILIZADOR

        #region METODOS PRIVADOS UTILIZADOR
        /// <summary>
        /// Carrega ficheiro que terá a informação em binário
        /// </summary>
        private static void LoadData()
        {
            string dirFicheiro;
            Stream stream;

            dirFicheiro = Environment.CurrentDirectory + "//utilizadores.dat";


            // Se o ficheiro alvo não existir, ignorar o resto das iterações do presente método
            if (File.Exists(dirFicheiro) == false) return;

            // Inicializar stream de leitura através da abertura do ficheiro onde os dados estão guardados  
            stream = File.Open(dirFicheiro, FileMode.Open);

            var serializador = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();


            // Carregar binário para lista
            listaUtilizadores = (List<Utilizador>)serializador.Deserialize(stream);
            stream.Close();
        }
        /// <summary>
        /// Escreve e guarda as informações do ficheiro
        /// </summary>
        private static void WriteData()
        {
            // Declaração de variáveis locais
            string dirFicheiro;
            Stream stream;

            // Definir diretorio onde o ficheiro sera manipulado
            dirFicheiro = Environment.CurrentDirectory + "//utilizadores.dat";


            // Inicializar stream de escrita
            stream = File.Create(dirFicheiro);

            var serializador = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            // Serializar objecto
            serializador.Serialize(stream, listaUtilizadores);

            stream.Close();
        }
        #endregion METODOS PRIVADOS UTILIZADOR
    }
}

