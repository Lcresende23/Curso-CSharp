using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    // Propriedades
    public class CarroOpcional {
        double desconto = 0.1;

        string nome;
        public string Nome {
            get {
                return "Opcional1: " + nome;
            }
            set {
                nome = value;

            }

        }
        // propriedade autoimplementada -> Ela automaticamente faz o get e o set no atributo respectivo
        public double Preco { get; set; }

        // Somente de leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco); // Lambda
        }

        public CarroOpcional() {

        }

        public CarroOpcional(string nome, double preco) {
            Nome = nome;// Joga pra dentro do método SET criado na propriedade PUBLIC SSTRING NOME { }
            Preco = preco;
        }
    }
    class Props {
        public static void Executar() {

            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.PrecoComDesconto);

            op1.Preco = 7000;
            op1.Nome = "";
            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Hidraulica";
            op2.Preco = 2455.8;
            Console.WriteLine(op2.Nome);
        }
    }
}
