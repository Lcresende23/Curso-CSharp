using System;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        // Todos

        public string InfoPublica = "Tenho um instagram";

        // herança

        protected string CorDoOlho = "verde";

        // mesmo projeto ou mesmo assembly

        internal ulong NumeroCelular = 5511999999999;

        // herança ou mesmo projeto 
        protected internal string JeitoDeFalar = "Uso muitas girias";

        // mesma classe ou  herança no mesmo projeto (Funciona cima do c3 7.0
        private protected string SegredoFamiliar = "Bla bla";

        // padrão
        bool UsaMuitoPhotoshop = true;


        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamiliar);
            Console.WriteLine(UsaMuitoPhotoshop);
        }

    }
}
