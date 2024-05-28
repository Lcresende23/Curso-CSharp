using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            //Converte o valor pra 1 casa decimal
            Console.WriteLine(valor.ToString("F1"));
            //Converte o valor para MOEDA, DINHEIRO
            Console.WriteLine(valor.ToString("C"));
            //Converte o valor para Percentual, multiplica por 100 e adiciona % no fim
            Console.WriteLine(valor.ToString("P"));
            //Converte o valor para ter 2 casas Decimais, variação do primeiro F1
            Console.WriteLine(valor.ToString("#.##"));

            //Codigo abaixo cria uma variavel que recebe o valor de CultureInfo pt-BR, se mudar o pt-BR para outra como en-US, converte em ingles
            CultureInfo cultura = new CultureInfo("en-US");
            //Código abaixo usa 'C0' -> Valor em dinheiro sem casa decimal, passa cultura tambem
            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 256;
            //Código retorna a impressão do valor adicionando zeros a frente até completar 10 casas
            Console.WriteLine(valor.ToString("D10"));
        }
    }
}
