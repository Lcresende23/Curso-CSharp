using System;
using System.Collections.Generic; // A notação <> informa qual tipo de Item irá ser armazenado na
                                  // lista. Poderia ser <int> ou <string>, no exemplo abaixo usamos a classe
                                  // como referencia.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {


    // com HASHSET não temos mais uma estrutura indexada, ou seja, nada que use indice
    // ira funcionar. Esse método não aceita duplicação.
     class ColecoesSet {
        public static void Executar() {
            
            var livro = new Produto("Game of Thrones", 49.9);
            
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa",29.9),
                new Produto("8 temporada Game of Thrones", 99.9),
                new Produto("Poster", 10),
                new Produto("Poster", 10)
            };
            
            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            // carrinho.RemoveAt(3);

            foreach (var item in carrinho) {
                // Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" - Produto: {item.Nome}. Preço: R${item.Preco}");
            }

            Console.WriteLine(carrinho.Count()); 
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count()); 
            // Console.WriteLine(carrinho.LastIndexOf(livro));

        }
    }
}
