using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Interpolar strings nada mais é que "Concatenar" variaveis junto das strings.
 * Podemos usar o "+" para concatenar, podemos usar "{0}" indicando o indice das
 * variaveis e podemos tambem usar "$" antes de abrir aspas para colocar a  variavel
 * direto dentro da frase. Exemplos abaixo.
 */


namespace CursoCSharp.Fundamentos {
     class Interpolacao {
        public static void Executar() {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa R$" + preco + ".");
            Console.WriteLine("O {0} da marca {1} custa R${2}.", nome, marca, preco);
            Console.WriteLine($"A marca {marca} é ótima!");
            Console.WriteLine($" 1 + 1 = {1 + 1}");



        }
    }
}
