using System;

// ESSE USING É UTILIZADO PARA CASOS ONDE QUEREMOS USAR VALORES DOUBLE/FLOAT COM CASAS DECIMAIS. DESSA MANEIRA, DECLARADA ABAIXO
// O SISTEMA NÃO DIFERENCIA PONTO E VIRGULA, AMBOS PODEM SER UTILIZADOS, INDEPENDENTE DO IDIOMA DO SEU SISTEMA OPERACIONAL
// USA O PONTO COMO SEPARADOR DE MILHAR NA LINGUAGEM PT-BR
using System.Globalization;


namespace CursoCSharp.Fundamentos {
     class LendoDados {
        public static void Executar() {
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Nome: {nome}; Idade: {idade}; Salário R${salario};");
        }
    }
}
