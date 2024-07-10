using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class DelegatesComoParametros // Usando função delegate aderente como parametro da funcao Calculadora, mesmo elas nao tendo vinculo
    {

        public delegate int Operacao(int x, int y);

        public static int Soma(int x, int y)
        {
            return x + y;
        }
        public static string Calculadora(Operacao op, int x, int y)
        {
            var resultado = op(x, y);
            return "Resultado: " + resultado;
        }
        public static void Executar()
        {
            Operacao subtracao = (int x, int y) => x - y;

            Console.WriteLine(Calculadora(subtracao, 10, 5));

            Console.WriteLine(Calculadora(Soma, 5, 5));
        }
    }
}
