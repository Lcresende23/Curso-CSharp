using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
     class Array { // Classe criada com nome Array propositalmente para mostrar o conflito que da com nomes iguais
        public static void Executar() {
            // Criação de um array de string com 5 posições
            string[] alunos = new string[5];
            alunos[0] = "Anderson";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";
            alunos[4] = "Emanuel";
           

            foreach(var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var nota in notas) {
                somatorio += nota;
            }
            // com for é menos interessante pois tem mais comandos
            //for (int i = 0; i < notas.Length; i++) {
            //    somatorio += notas[i];
            //}

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letra = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letra);
            Console.WriteLine(palavra);

        }
    }
}
