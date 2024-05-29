using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    // Exercicio utilizando a palavra reservada ENUM que basicamente cria uma
    // lista ordenada que pode conter generos de filmes, dias da semana, meses etc.
    // Dessa maneira, organizando melhor o programa em geral.
    public enum Genero { Acao, Suspense, Terror, Comedia, Romance }

    public class Filmes {
        public string Titulo;
        public Genero GeneroFilme;
    }
    class ExemploEnum {
        public static void Executar() {
            int id = (int)Genero.Acao;
            Console.WriteLine(id);

            var FilmeParaFamilia = new Filmes();

            FilmeParaFamilia.Titulo = "MIB";
            FilmeParaFamilia.GeneroFilme = Genero.Comedia;

            Console.WriteLine($"O Filme {FilmeParaFamilia.Titulo} é de {FilmeParaFamilia.GeneroFilme}");

            
        }
    }
}
