using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {

    // ArrayList não muito indicado em quase todos cenários pois voce tem a liberdade de adicionar tipos
    // diferentes de dados dentro do mesmo, dessa maneira, mais indicado utilizar o Generics. Lembrar de importar a
    // biblioteca System.Collections; e não System.Collections.Generic; (Usada para List<> de um só tipo de dado)
     class ColecoesArrayList {
        public static void Executar() {
            var arraylist = new ArrayList() {
                "Palavra",
                3,
                true
            };

            arraylist.Add(3.14);

            foreach(var item in arraylist) {
                Console.WriteLine($"{item} => {item.GetType()}");
            }
        }
    }
}
