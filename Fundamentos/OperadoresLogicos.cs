using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
     class OperadoresLogicos {
        public static void Executar() {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            //Operador && lógico é o AND
            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a TV de 50? {0}", comprouTv50);
            // Operador logico || é o OR
            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine($"Comprou sorvete? {comprouSorvete}");
            // Operador Lógico ^ é o OR exclusivo
            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou TV de 32? {0}", comprouTv32);

            //Operador ! é um operador unário, usa apenas um operando. Inverte o valor booleano, se for falso vira verdadeiro
            //e vice e versa
            Console.WriteLine("Mais saudavel? {0}", !comprouSorvete);

        }
    }
}
