﻿using System;


namespace CursoCSharp.EstruturaDeControle {
     class EstruturaForEach {
        public static void Executar() {
            var palavra = "Opa!";

            foreach (var letra in palavra) {
                Console.WriteLine(letra);
            }

            var alunos = new String[]  { "Ana", "Bia", "Carlos" };

            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
}
