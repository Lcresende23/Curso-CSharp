using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    // Os parametros por referencia indicam como o valor será colocado dentro da função como no exemplo abaixo, onde
    // o parametro por REF adiciona o valor passado para a variavel INT A e ele faz a manipulação do mesmo. Pode ser
    // iniciado antes como no exemplo. Parametro passado com OUT não podem ser passados 2x, pois é uma via de mão unica, ele
    // precisa realizar o calculo e devolver para a variavel, então nao necessita que inicie a varaivel INT B já com valores definidos. 
    class ParametrosPorReferencia {

        public static void AlterarRef(ref int numero) {
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero) {
            numero = 0;
            numero = numero + 15;
        }

        public static void Executar() {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            //int b = 3;
            AlterarOut(out int b);
            Console.WriteLine(b);
            b += 1;
            Console.WriteLine(b);
        }

    }
}
