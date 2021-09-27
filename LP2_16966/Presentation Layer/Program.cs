// Autor: Diogo Rocha
// Email: a16966@alunos.ipca.pt
// Data: 2020/06/03
// Versão: 1
// Comentários: Main


using BO;
using BR;
using System;

namespace Presentation_Layer
{
    class Program
    {
        static void Main(string[] args)
        {
            //criar objetos
            BO.Filme filme = new BO.Filme();
            BO.Utilizador utilizador = new BO.Utilizador();
            filme.Titulo = "Superhomem";
            filme.Genero = TIPOFILME.Acao;
            utilizador.Username = "Joao95";

            //registar Filme e Utilizador
            Console.WriteLine("Registar Utilizador: {0}", UtilizadoresR.InsereUtilizador(utilizador));
            Console.WriteLine("Registar Filme: {0}", FilmesR.InsereFilme(filme.Titulo));

            //tentar criar o mesmo filme ou utilizador
            Console.WriteLine("Registar o mesmo filme: {0}", FilmesR.InsereFilme(filme.Titulo));
            Console.WriteLine("Registar o mesmo filme: {0}", UtilizadoresR.InsereUtilizador(utilizador));

            //Tenta adicionar filme aos favoritos
            Console.WriteLine("Registar o mesmo filme nos favoritos: {0}", FilmesR.RegistaFavoritoFilme(filme.Titulo));

            utilizador.Password = "4549";
            utilizador.Idade = 21;
            //Editar dados utilizador
            Console.WriteLine("Editar Utilizador: {0}", UtilizadoresR.ChangeUserData(utilizador, "Joao96", "3124123", 21));
            filme.IdFilme = 3124;
            //Eliminar Filme
            Console.WriteLine("Eliminar Filme Utilizador: {0}", FilmesR.RemoveFilme(3124));


        }
    }
}
