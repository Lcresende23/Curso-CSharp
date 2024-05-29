using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {


    // Construtor recebe o mesmo nome da classe
    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        // Construtor Carro passando parametros pros atributos da classe Carro
        public Carro(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        //Definido abaixo de maneira EXPLICITA uma forma de usar o construtor padrão e o personalizado
        public Carro() {
        
            
        }
    }
     class Construtores {
        public static void Executar() {
            // Construtor Padrão - Sem parametro nos parenteses.

            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            // Instancia de um objeto com uma linha de comando atraves de um construtor persnalizado de classe. Quando há construtores personalizados, o construtor padrao:
            // var carro1 = new Carro(); deixa de funcionar. Para ele funcionar, precisa ser feito de maneira EXPLICITA dentro da classe. Exemplo la em cima na classe

            var carro2 = new Carro("KA", "Ford", 2018);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            // Terceira forma de Instanciar um objeto usando o construtor Padrão setando os valores dentro do par de chaves e com ";" na chave de fechamento

            var carro3 = new Carro() {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");
        }
    }
}
