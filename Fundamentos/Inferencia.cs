using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
     class Inferencia {
        public static void Executar() {
            var nome = "Leonardo";
            Console.WriteLine(nome);
            var idade = 32;
            Console.WriteLine(idade);
            // Váriavel declarada com VAR não podem ser declaradas sem serem incializadas
            // e não podem ser substituidas por variaveis de outros tipos, apos a inferencia 
        }
    }
}
