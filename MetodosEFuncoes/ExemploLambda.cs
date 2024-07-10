using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
     class ExemploLambda //Funcoes Anonimas
    {
        public static void Executar()
        {
            Action algoNoConsdole = () =>
            {
                Console.WriteLine("Lambda em C#!");
            };
            
            algoNoConsdole();

            Func<int> jogarDado = () =>
            {
                Random randon = new Random();
                return randon.Next(1, 7);
            };
            Console.WriteLine(jogarDado());


            // A Função pode ser definida nos exemplos abaixo como bloco de código ou tudo na mesma linha

            //Func<int, string> conversorHex = numero =>
            //{
            //    return numero.ToString("X");
            //};

            // Todos paramentros tem que ser especificados o tipo no Generics e quando for um parametro so nao precisa de parenteses
            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            //Func com mais de 1 parametro de entrada 
            Func<int, int, int, string> formatarData = (dia, mes, ano) => string.Format("{0:D2}/{1:D2}/{2:D2}", dia, mes, ano);
            Console.WriteLine(formatarData(1, 1, 2019));
        }
    }
}
