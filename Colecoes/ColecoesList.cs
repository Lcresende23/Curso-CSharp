using System;
using System.Collections.Generic; // A notação <> informa qual tipo de Item irá ser armazenado na
                                  // lista. Poderia ser <int> ou <string>, no exemplo abaixo usamos a classe
                                  // como referencia.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {

    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        //Equal feito pelo proprio c#
        public override bool Equals(object obj) {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        //GetHase feito pelo proprio c#
        public override int GetHashCode() {
            int hashCode = -347481536;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + Preco.GetHashCode();
            return hashCode;
        }
        // Override Equal feito na mão 
        //public override bool Equals(object obj) {
        //    var outroProduto = (Produto)obj;
        //    bool mesmoNome = Nome == outroProduto.Nome;
        //    bool mesmoPreco = Preco == outroProduto.Preco;
        //    return mesmoNome && mesmoPreco;
        //}
        // GetHash feito na mão
        //public override int GetHashCode() {
        //    return Nome.Length;
        //}
    }
    class ColecoesList {
        public static void Executar() {
            // Criei a instancia da classe Produto abaixo
            var livro = new Produto("Game of Thrones", 49.9);
            // Criei uma nova lista que recebe itens do tipo PRODUTO, ou seja, apenas itens da classe Produto
            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("Camisa",29.9),
                new Produto("8 temporada Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };
            // AddRange(combo) é pra adicionar todos os produtos criados e armazenados na lista COMBO
            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach (var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" - Produto: {item.Nome}. Preço: R${item.Preco}");
            }

            Console.WriteLine(carrinho.Count());
            carrinho.Add(livro);
            Console.WriteLine(carrinho.LastIndexOf(livro));

        }
    }
}
