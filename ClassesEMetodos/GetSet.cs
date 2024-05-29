using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    // A criação de atributos privados nos traz o uso de GET E SET onde iremos pegar os valores com GET e alterar eles com
    // SET, como feito exemplo abaixo. A ideia é nao deixar os atributos visiveis e acessiveis para todos.
    // A ideia principal do uso de Get e Set é a possibilidade de criar validações onde ficam impostas regras claras
    // para que o código siga um padrão correto, sem erros como valores negativos em CILINDRADAS de MOTOS.
    // Abaixo segue exemplo comentado sobre o que falei acima, duas maneiras de criar o construtor, passando ele pela
    // validação no metodo SET e condições dentro do metodo SetCilindrada(); Mas a melhor forma de fazer isso, é usando a variavel
    // UINT que nao permite passar valores negativos.

    public class Moto {
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto(string marca, string modelo, uint cilindrada) {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;

            SetMarca(marca);// Maneira de fazer com que tudo passe pela validação colocada no método SET 
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto() {

        }

        public string GetMarca() {
            return Marca;
        }
        public void SetMarca(string marca) {
            Marca = marca;
        }

        public string GetModelo() {
            return Modelo;
        }

        public void SetModelo(string modelo) {
            Modelo = modelo;
        }

        public uint GetCilindrada() {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada) {
            
            // 1 Opção
            //if (cilindrada > 0) {
            //    Cilindrada = cilindrada;
            //}

            // 2 Opção
            //Cilindrada = Math.Abs(cilindrada);

            // Melhor opção com uso de UINT
            Cilindrada = cilindrada;
        }
    }
    class GetSet {

        public static void Executar() {

            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);

            // ****Console.WriteLine(moto1.Marca);**** Esse modelo não pode mais ser usado, não é possivel mais acessar o
            //atributo dessa forma

            Console.WriteLine($"Marca: {moto1.GetMarca()}");
            Console.WriteLine($"Modelo: {moto1.GetModelo()}");
            Console.WriteLine($"Cilindrada: {moto1.GetCilindrada()}");

            var moto2 = new Moto();

            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);

            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());


        }
    }
}

