using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
     class Conversoes {
        public static void Executar() {
            //Conversão implicita -> Quando é possivel realizar a conversão de um tipo de variavel para outro automaticamente
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);


            //Cast(Conversão explicita) -> quando devemos realizar a conversão de forma manual de tipos quando pode ocorrer perda de dados
            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota Truncada {0}" ,notaTruncada);

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteira = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteira);

            //ToInt32 poiis o valor inteiro tem 4 bytes, 32 bits
            idadeInteira = Convert.ToInt32(idadeString);
            Console.WriteLine("Idade: {0}", idadeInteira);

            //Codigo mostra a conversão de string para int com OUT, ou seja, jogue o valor string dentro da variavel INT NUMERO
            //Try Parse, tenta fazer um Parse/converter. Se não conseguir, passa valor 0
            Console.Write("Digite um número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine("Numero 1: {0}", numero);

            //Exemplo anterior de forma otimizada
            Console.Write("Digite outro número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Numero 2: {0}", numero2);
        }
    }
}
