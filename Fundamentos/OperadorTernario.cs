using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
     class OperadorTernario {
        public static void Executar() {
            // Operador ternário -> Atribuição condicional, se for verdeiro atribui um operando
            // se for falso, atribui outro operando. Atribuição condicional.

            var nota = 4.0;
            bool bomComportamento = true;
            string resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
