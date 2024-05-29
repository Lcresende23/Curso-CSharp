using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class Cliente {
        public string Nome;
        readonly DateTime Nascimento; // tipo readonly pode ser usado para iniciar a variavel com valor pelo construtor. tipo
                                      // Const apenas setando um valor inicial direto na variavel. Readonly seta um valor
                                      // imutavel   

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento() {
            return string.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    
    class Readonly {
        public static void Executar() {

            var cliente1 = new Cliente("Ana Silva", new DateTime(1998, 02, 22));

            Console.WriteLine(cliente1.Nome);
            Console.WriteLine(cliente1.GetDataDeNascimento());

        }
    }
}
