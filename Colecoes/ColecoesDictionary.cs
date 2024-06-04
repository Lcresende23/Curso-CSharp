using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
     class ColecoesDictionary {
        public static void Executar() {
            var filmes = new Dictionary<int, string>(); // Dicionário tem chave valor, ou seja, recebe 2 parametros no generics

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incriveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: " + filmes[2004]);
            }
            Console.WriteLine(filmes.ContainsValue("Amnesia"));

            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"Filme {filme2006}");


            // Quatro maneiras de percorrer valores e chaves no dicionario.
            foreach (var chave in filmes.Keys) {
                Console.WriteLine($"Ano: {chave}");
            }

            foreach (var filme in filmes.Values) {
                Console.WriteLine($"Filme: {filme}");
            }

            foreach(KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }

            foreach(var filme in filmes) {
                Console.WriteLine($"{filme.Value} é do ano {filme.Key}");
            }
        }
    }
}
