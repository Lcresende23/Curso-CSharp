using CursoCSharp.Colecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste";
            meuObjeto = 3;

            meuObjeto += 1;

            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Marcos";
            aluno.idade = 34;
            aluno.nota = 8;

            Console.WriteLine($"Nome: {aluno.nome}, Idade: {aluno.idade}, Nota: {aluno.nota}");
        }
    }
}
