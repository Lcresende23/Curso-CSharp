using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class CalculadoraComum {

        public int Somar(int a, int b) {
            return a + b;
        }

        public int Subtrair(int a, int b) {
            return a - b;
        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }

        public int Divisao(int a, int b) {
            return a / b;
        }
    }

    class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;   // THIS retorna a propria instancia que eu estou usando
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria;
        }
    }

    class MetodosComRetorno {
        public static void Executar() {

            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);
            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(2, 7));
            Console.WriteLine(calculadoraComum.Multiplicar(4, 4));
            Console.WriteLine(calculadoraComum.Divisao(5, 2));


            //Calculadora cadeia, varias chamadas em cadeia
            var calculadoraCadeia = new CalculadoraCadeia();
            // Toda vez que eu faço uma chamada como Somar(3) ele retorna o proprio objeto/instancia e por isso é possivel fazer chamadas em cadeia com a NOTAÇÃO PONTO.
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

            // Na função abaixo, armazena em RESULTADO o resultado da operação. A partir do momento que chamar a função resultado, nao tem mais como fazer chamadas em cadeia pois ela é do
            // tipo INT
            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);
        }
    }
}
