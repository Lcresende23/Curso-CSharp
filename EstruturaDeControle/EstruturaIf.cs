using System;


namespace CursoCSharp.EstruturaDeControle {
     class EstruturaIf {
        public static void Executar() {

            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Posssui bom comportamento? (S/N):  ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //    bomComportamento = true;

            //bomComportamento = entrada == "s" || entrada == "s";

            bomComportamento = entrada.ToLower() == "s";

            //Quando a variavel for bool, não ha necessidade de comparar ela, exemplo: bomComportamento == true;
            //Pois ela so vai executrar se for TRUE. Para negar o bool, precisa fazer: !bomComportamento "!" faz a negação
            if (nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}
