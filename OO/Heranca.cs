using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO { // Exemplo pratico da aplicação de Herança dentro de um código

    public class Carro {
        protected readonly int VelocidadeMaxima;
        int velocidadeAtual;

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = velocidadeAtual + delta;
            // Validações no métodod AlterarVelocidade para que a velocidade nao fique negativa e nem ultrapasse a velocidade Maxima do carro.

            if (novaVelocidade < 0) {
                velocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima) {
                velocidadeAtual = VelocidadeMaxima;
            }
            else {
                velocidadeAtual = novaVelocidade;
            }
            return velocidadeAtual;
        }

        // O modificador Virtual permite que a o metodo pode ser sobreescrito em outras classes
        public virtual int Acelerar() {
            return AlterarVelocidade(5);
        }

        public int Frear() {
            return AlterarVelocidade(-5);
        }

        // Abaixo o construtor da classe UNO com herança na classe "BASE()" que referencia a classe do
        // construtor carro. Quando não usamos construtor padrão na classe, precisamos usar da maneira abaixo.
    }
    public class Uno : Carro {
        public Uno() : base(200) {

        }
    }
    public class Ferrari : Carro {
        public Ferrari() : base(350) {

        }
        // Sobreescrevendo o método acelerar da classe Carro pra classe ferrari
        public override int Acelerar() {
            return AlterarVelocidade(15);
        }

        // Maneira de ocultar o métdo da classe pai (carro)
        public new int Frear() {
            return AlterarVelocidade(-15);
        }
    }
    public class Lamborghini : Carro {
        public string Cor;
        public Lamborghini() : base(320) {
        }
    }

    public class Bugatti : Carro {
        public string Modelo;
        public string Cor;
        public int Ano;
        public Bugatti(string modelo, string cor, int ano) : base(400) {
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
        }
    }

    class Heranca {
        public static void Executar() {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();

            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("\nFerrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            // Exemplo abaixo mostra a diferenca entre usar o modificador OVERRIDE que sobrescreve o método e o
            // NEW que oculta o método da classe pai
            Console.WriteLine("Ferrari usando tipo Carro...");
            Carro carro5 = new Ferrari();

            Console.WriteLine(carro5.Acelerar());
            Console.WriteLine(carro5.Acelerar());
            Console.WriteLine(carro5.Frear());
            Console.WriteLine(carro5.Frear());
            Console.WriteLine(carro5.Frear());

            Console.WriteLine("Uno usando tipo Carro...");
            carro5 = new Uno(); // Polimorfismo - Mesmo objeto assumindo formas diferentes
            Console.WriteLine(carro5.Acelerar());
            Console.WriteLine(carro5.Acelerar());
            Console.WriteLine(carro5.Frear());
            Console.WriteLine(carro5.Frear());
            Console.WriteLine(carro5.Frear());



            Console.WriteLine("\nLamborghini...");
            var carro3 = new Lamborghini();

            carro3.Cor = "Amarela";

            Console.WriteLine("Cor:" + carro3.Cor);
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("\nBugatti...");
            var carro4 = new Bugatti("Chiron", "Preta", 2022);

            Console.WriteLine("Modelo" + carro4.Modelo);
            Console.WriteLine("Cor: " + carro4.Cor);
            Console.WriteLine("Ano: " + carro4.Ano);
            Console.WriteLine(carro4.Acelerar());
            Console.WriteLine(carro4.Acelerar());
            Console.WriteLine(carro4.Acelerar());
            Console.WriteLine(carro4.Frear());
            Console.WriteLine(carro4.Frear());
            Console.WriteLine(carro4.Frear());
            Console.WriteLine(carro4.Frear());
            Console.WriteLine(carro4.Frear());
        }
    }
}
