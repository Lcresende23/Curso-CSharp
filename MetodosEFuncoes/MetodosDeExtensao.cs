using CursoCSharp.Colecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro
    {
        public static int Soma(this int num, int outroNum) // this quer dizer a instancia atual quando for usar a função soma
        {
            return num + outroNum;
        }

        public static int Sub(this int num, int outroNum)
        {
            return num - outroNum;
        }
    }

    class MetodosDeExtensao
    {
        public static void Executar()
        {
            int numero = 5;

            Console.WriteLine("Resultado: " + numero.Soma(5));
            Console.WriteLine("Resultado " + numero.Sub(6));

            Console.WriteLine("Resultado: " + 2.Soma(6));
            Console.WriteLine("Resultado: " + 2.Sub(4));
        }
    }
}
