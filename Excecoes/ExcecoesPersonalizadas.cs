using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{

    public class NegativoException : Exception  // Criar excecoes personalizadas para direcionar melhor os erros e os usuarios da aplicação
                                                // saber o que houve, conseguindo entrar em contato com o suporte de uma maneira mais inteligente
    {
        public NegativoException() { }
        public NegativoException(string message) : base(message) { }

        public NegativoException(string message, Exception inner) : base(message, inner) { } // inner é pra jogar a except dentro da personalizada


    }
    public class ImparException : Exception
    {

        public ImparException(string message) : base(message) { }
    }
    class ExcecoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random random = new Random();
            int valor = random.Next(-30, 30);

            if (valor < 0)
            {
                throw new NegativoException("O valor é negativo.");
            }
            if (valor % 2 == 1)
            {
                throw new ImparException("O valor é impar.");
            }
            return valor;
        }
        public static void Executar()
        {
            try
            {
                Console.WriteLine(PositivoPar());
            }
            catch (NegativoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ImparException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
