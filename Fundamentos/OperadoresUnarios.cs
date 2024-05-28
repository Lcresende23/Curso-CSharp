using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
     class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            // - antes da variavel converte o valor para o contrario dele. Negativo vira positivo, etc
            Console.WriteLine(-valorNegativo);
            //Negação lógica
            Console.WriteLine(!booleano);

            //Opeador pos fixado, depois da variavel
            numero1++;
            Console.WriteLine(numero1);

            // opeardor pre fixado, antes da variavel
            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2);
        }
    }
}
