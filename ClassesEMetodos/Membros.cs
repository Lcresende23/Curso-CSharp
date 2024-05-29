using System;


namespace CursoCSharp.ClassesEMetodos {
     class Membros {
        public static void Executar() {
            // Exemplo de uma Instancia de objeto Pessoa
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            //Poderia apresentar assim, porém é melhor apresentar das maneiras abaixo
            Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos!");

            // Método apresentar no console Criado a partir da classe Pessoa; Método nao muito aconselhado a se usar
            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            // Instancia de outra pessoa com VAR fazendo inferencia
            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            //Maneira mais adequada para poder apresentar a Pessoa no console
            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
