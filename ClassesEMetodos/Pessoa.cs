using CursoCSharp.EstruturaDeControle;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    // Classes tem atributos e métodos. Nesse exemplo abaixo comtém os dois. Dois comportamentos: Um retorna uma string de apresentação e o outro coloca diretamente no console
    class Pessoa {
        // Criamos a classe Pessoa, que tem como atributos: Nome e Idade
        public string Nome;
        public int Idade;

        // Criados o método apresentar pra poder Apresentar a pessoa instanciada
        public string Apresentar() {
            if (Nome == null || Idade <= 0) {
                return string.Format("Nome e/ou Idades não preenchidos");
            }
            else {
            // .Format é um metodo pra formatar a String, parecido com o WriteLine, porem ele apenas formata a string
            return string.Format($"Olá, me chamo {Nome} e tenho {Idade} anos.");
            }
        }

        //Console.WriteLine não é interessante dentro de uma classe.
        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }

        public void Zerar() {
            Nome = "";
            Idade = 0;
        }

    }
}
