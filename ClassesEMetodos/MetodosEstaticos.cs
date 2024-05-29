using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class MetodosEstaticos {

        public class CalculadoraEstatica {

            // A partir do momento em que usamos STATIC no método, significa que ele nao faz mais parte do OBJETO
            // e sim faz parte da CLASSE. Desssa maneira, posso chama-lo sem criar um objeto 
          
            public static int Multiplicar(int a, int b) {
                return a * b;
            }


            public int Somar(int a, int b) { // Método acessivel apenas a partir da instancia
                return a + b;
            }
        }
        public static void Executar() {
            // Segue exempli de como fica a chamada do método sem antes ter que instanciar o objeto
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            // Exemplo sem o ESTATIC NO MÉTODO 
            CalculadoraEstatica calc = new CalculadoraEstatica(); 
            Console.WriteLine(calc.Somar(2, 2));
        
        }
    }
}
