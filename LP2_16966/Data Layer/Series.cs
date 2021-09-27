// Autor: Diogo Rocha
// Email: a16966@alunos.ipca.pt
// Data: 2020/06/03
// Versão: 1
// Comentários: Classe de Séries

using BO;
using System;
using System.Collections.Generic;
using System.IO;

namespace DL
{
    public class Series
    {
        #region ESTADO

        static List<Serie> listaSeries;

        public Series()
        {
            listaSeries = new List<Serie>();
            LoadData();
        }
        #endregion

        #region CONSTRUTORES
        /// <summary>
        /// Construtor para series
        /// </summary>
        static Series()
        {
            listaSeries = new List<Serie>();

        }

        public static bool InsereSerie(string novaSerie)
        {
            throw new NotImplementedException();
        }

        #region PROPRIEDADES
        /// <summary>
        /// Função que define ou entao devolve a l
        /// </summary>
        public static List<Serie> ListaSeries
        {
            get { return listaSeries; }
            set { listaSeries = value; }
        }

        #endregion

        #endregion

        #region METODOS PUBLICOS SERIES
        /// <summary>
        /// Insere uma nova serie
        /// </summary>
        /// <param name="novaserie"></param>
        /// <returns></returns>
        public static bool InsereSerie(Serie novaSerie)
        {
            bool x = false;
            try
            {
                listaSeries.Add(novaSerie);
                x = true;

            }
            catch (Exception s)
            {
                throw new Exception("Não foi possível adicionar",s);

            }

            return x;
        }
        /// <summary>
        /// Função que vê se esse série já existe na database
        /// </summary>
        /// <param name="filme"></param>
        /// <returns></returns>
        public static bool ExisteSerie(string serie)
        {
            foreach (Serie s in listaSeries)
            {
                if (s.TituloSerie == serie)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Mostra as informações que pretendemos de determinada serie
        /// </summary>
        /// <param name="nomeserie"></param>
        /// <returns></returns>
        public static string MostraDadosSeries(string nomeserie)
        {
            foreach (Serie s in listaSeries)
            {
                if (s.TituloSerie == nomeserie) {

                    string x = s.AnoSerie + s.DiretorSerie + s.GeneroSerie + s.IdSerie + s.MesSerie + s.MinutosEpisodio + s.NumeroTemporadas + s.RatingSerie + s.TituloSerie;
                return x;
                }
            }
            return null;
        }
        /// <summary>
        /// função que permitirá um filme
        /// </summary>
        /// <param name="IDSerie"></param>
        /// <returns></returns>
        public static bool RemoveSerie(int IDSerie)
        {
            bool result = false;

            foreach (Serie f in listaSeries)
            {
                if (f.IdSerie == IDSerie)
                {
                    ListaSeries.Remove(f);
                    break;
                }
            }
            return result;
        }




        /// <summary>
        /// Função que insere serie nos favoritos e mostra no fim quantos estão nos favoritos
        /// </summary>
        /// <param name="novaSerie"></param>
        /// <returns></returns>
        /// 
        public static List<Serie> RegistaFavoritoSerie(string novaSerie)
        {
            List<Serie> conjuntoSeriesFavoritas = new List<Serie>();

            foreach (Serie s in listaSeries)
            {
                if (s.TituloSerie == novaSerie)
                {
                            conjuntoSeriesFavoritas.Add(s);

                break;
                }
            }
            return conjuntoSeriesFavoritas;
        }

        #endregion

        #region METODOS PRIVADOS SERIES
        /// <summary>
        /// Carrega ficheiro que terá a informação em binário
        /// </summary>
        private static void LoadData()
        {
            string dirFicheiro;
            Stream stream;

            dirFicheiro = Environment.CurrentDirectory + "//series.dat";


            // Se o ficheiro alvo não existir, ignorar o resto das iterações do presente método
            if (File.Exists(dirFicheiro) == false) return;

            // Inicializar stream de leitura através da abertura do ficheiro onde os dados estão guardados  
            stream = File.Open(dirFicheiro, FileMode.Open);

            var serializador = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();


            // Carregar binário para lista
            listaSeries = (List<Serie>)serializador.Deserialize(stream);
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
            dirFicheiro = Environment.CurrentDirectory + "//series.dat";


            // Inicializar stream de escrita
            stream = File.Create(dirFicheiro);

            var serializador = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            // Serializar objecto
            serializador.Serialize(stream, listaSeries);

            stream.Close();

            #endregion
        }
    }
}
