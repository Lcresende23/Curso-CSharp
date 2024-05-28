using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
     class UsandoBreak {
        public static void Executar() {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O número que queremos é o {0}", numero);

            for (int i = 1; i <=50; i++) {
                Console.Write("{0} é o número que queremos? ", i);
                if (i == numero) {
                    Console.WriteLine("SIM!");
                    break;
                }
                else {
                    Console.WriteLine("NÃO!");
                }
            }
            var corAnterior = Console.BackgroundColor;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Encontramos o número! Programa Encerrado!");
            Console.BackgroundColor = corAnterior;
        }
    }
}
