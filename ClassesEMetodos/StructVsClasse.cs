using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public struct SPonto {
        public int X;
        public int Y;
    }

    public class CPonto {
        public int X;
        public int Y;
    }
    class StructVsClasse {
        public static void Executar() {
            //Struct
            SPonto ponto1 = new SPonto { X = 4, Y = 5 }; // Em Struct, é realizada a atribuição POR VALOR.
                                                      // Dois espaços de memorias diferentes
            SPonto copiaPonto1 = ponto1;
            ponto1.X = 1;

            Console.WriteLine("X = {0}", ponto1.X);
            Console.WriteLine("X = {0}", copiaPonto1.X);


            //Classe
            CPonto ponto2 = new CPonto {  X = 2, Y = 1 }; // Em uma classe, é realizada a atribuição por REFERENCIA.
                                                       // Divide mesmo espaço de memoria
            CPonto copiaPonto2 = ponto2;
            ponto2.X = 19;

            Console.WriteLine("X = {0}", ponto2.X);
            Console.WriteLine("X = {0}", copiaPonto2.X);
        }
    }
}
