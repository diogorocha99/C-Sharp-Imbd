// Autor: Diogo Rocha
// Email: a16966@alunos.ipca.pt
// Data: 2020/06/03
// Versão: 1
// Comentários: Classe de Filmes

using BO;
using System;
using System.Collections.Generic;
using System.IO;

namespace DL
{
    ///classe Filmes
    public class Filmes
    {
        #region ESTADO

        static List<Filme> listaFilmes;
        public Filmes()
        {
            listaFilmes = new List<Filme>();
            LoadData();
        }
        #endregion

        #region CONSTRUTORES
        /// <summary>
        /// Construtor para filmes
        /// </summary>
        static Filmes()
        {
            listaFilmes = new List<Filme>();

        }

        public static bool InsereFilme(string novoFilme)
        {
            throw new NotImplementedException();
        }

        #region PROPRIEDADES
        /// <summary>
        /// Função que define ou entao devolve a l
        /// </summary>
        public static List<Filme> ListaFilmes
        {
            get { return listaFilmes; }
            set { listaFilmes = value; }
        }


        #endregion

        #endregion

        #region METODOS PUBLICOS FILMES
        /// <summary>
        /// Insere uma novo filme
        /// </summary>
        /// <param name="novoFilme"></param>
        /// <returns></returns>
        public static bool InsereFilme(Filme novoFilme)
        {
            bool x = false;

            try
            {
                listaFilmes.Add(novoFilme);

                x = true;
            }
            catch (Exception f)
            {
                throw new Exception("Não foi possível adicionar", f);

            }

            return x;
        }
        /// <summary>
        /// Função que vê se esse filme já existe na database
        /// </summary>
        /// <param name="filme"></param>
        /// <returns></returns>
        /// 
        public static bool ExisteFilme(string filme)
        {
            foreach (Filme f in listaFilmes)
            {

                if (f.Titulo == filme)
                return true;
            }

            return false;
        }
        /// <summary>
        /// Mostra as informações que pretendemos de determinado filme
        /// </summary>
        /// <param name="nomefilme"></param>
        /// <returns></returns>
        public static string MostraDadosFilme(string nomefilme)
        {
            foreach (Filme f in listaFilmes)
            {
                if (f.Titulo == nomefilme);

                string x = f.Titulo + f.AnoFilme + f.Diretor + f.Genero + f.IdFilme + f.MesFilme + f.MinutosFilmme + f.Rating + f.Titulo;
                return x;
            }
            return null;
        }
        /// <summary>
        /// função que permitirá um filme
        /// </summary>
        /// <param name="IDFilme"></param>
        /// <returns></returns>
        /// função editada
        public static bool RemoveFilme(int IDFilme)
        {
            bool result = false;
            
                foreach (Filme f in listaFilmes)
                {
                    if (f.IdFilme == IDFilme)
                    {
                     listaFilmes.Remove(f);
                    break; 
                    }
                }
            return result;
        }

        /// <summary>
        /// Função que insere filme nos favoritos e mostra no fim quantos estão nos favoritos
        /// </summary>
        /// <param name="novoFilme"></param>
        /// <returns></returns>
        /// função editada
        public static List<Filme> RegistaFavoritoFilme(string novoFilme)
        {
            List<Filme> conjuntoFilmesFavoritos = new List<Filme>();

            foreach (Filme f in listaFilmes)
            {
                if (f.Titulo == novoFilme)
                {

                    conjuntoFilmesFavoritos.Add(f);
                }
            }
            return conjuntoFilmesFavoritos;
        }

        #endregion

        #region METODOS PRIVADOS FILMES
        /// <summary>
        /// Carrega ficheiro que terá a informação em binário
        /// </summary>
        private static void LoadData()
        {
            string dirFicheiro;
            Stream stream;

            dirFicheiro = Environment.CurrentDirectory + "//filmes.dat";


            // Se o ficheiro alvo não existir, ignorar o resto das iterações do presente método
            if (File.Exists(dirFicheiro) == false) return;

            // Inicializar stream de leitura através da abertura do ficheiro onde os dados estão guardados  
            stream = File.Open(dirFicheiro, FileMode.Open);

            var serializador = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();


            // Carregar binário para lista
            listaFilmes = (List<Filme>)serializador.Deserialize(stream);
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
            dirFicheiro = Environment.CurrentDirectory + "//filmes.dat";


            // Inicializar stream de escrita
            stream = File.Create(dirFicheiro);

            var serializador = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            // Serializar objecto
            serializador.Serialize(stream, listaFilmes);

            stream.Close();
        }

        #endregion
    }
}

