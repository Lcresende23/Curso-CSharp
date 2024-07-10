using System;


namespace Encapsulamento
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amiga = new SubCelebridade(); // Como não tem herança, precisamos ter um composição para referenciar a classe SUBCELEBRIDADES criando a instancia

        public void MeusAcessos()
        {
            Console.WriteLine("AmigoProximo...");

            Console.WriteLine(amiga.InfoPublica);
            // Console.WriteLine(amiga.CorDoOlho); Atributos que são do tipo Protected só são transmitidos por herança
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);
            // Console.WriteLine(amiga.SegredoFamiliar); 
            // Console.WriteLine(amiga.UsaMuitoPhotoshop);

        }
    }
}
