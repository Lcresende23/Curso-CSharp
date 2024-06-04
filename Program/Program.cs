using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar },
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando números - Fundamentos", FormatandoNumero.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operadore Ternário - Fundamentos", OperadorTernario.Executar },

                //Estruturas de Controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIf.Executar },
                {"Estrutura IF/ELSE - Estruturas de Controle", EstruturaIfElse.Executar },
                {"Estrutura IF/ELSE/IF - Estruturas de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura SWITCH - Estruturas de Controle", EstruturaSwitch.Executar },
                {"Estrutura WHILE - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrutura DO WHILE - Estruturas de Controle", EstruturaDoWhile.Executar },
                {"Estrutura FOR - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura FOREACH - Estruturas de Controle", EstruturaForEach.Executar },
                {"Usando BREAK - Estruturas de Controle", UsandoBreak.Executar },
                {"Usando CONTINUE - Estruturas de Controle", UsandoContinue.Executar },

                // Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar },
                {"Construtores - Classes e Métodos", Construtores.Executar },
                {"Metodos com Retorno  - Classes e Métodos", MetodosComRetorno.Executar },
                {"Metodos Estáticos  - Classes e Métodos", MetodosEstaticos.Executar },
                {"Atriutos Estáticos  - Classes e Métodos", AtributosEstaticos.Executar },
                {"Desafio Atributo  - Classes e Métodos", DesafioAtributo.Executar },
                {"Params  - Classes e Métodos", Params.Executar },
                {"Parametros Nomeados  - Classes e Métodos", ParametrosNomeados.Executar },
                {"Get Set  - Classes e Métodos", GetSet.Executar },
                {"Props - Classes e Métodos", Props.Executar },
                {"Readonly - Classes e Métodos", Readonly.Executar },
                {"Enum - Classes e Métodos", ExemploEnum.Executar },
                {"Struct - Classes e Métodos", ExemploStruct.Executar },
                {"Struct Vs Classe - Classes e Métodos", StructVsClasse.Executar },
                {"Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar },
                {"Parametros por referência - Classes e Métodos", ParametrosPorReferencia.Executar },
                {"Parametro Padrão  - Classes e Métodos", ParametroPadrao.Executar },

                // Coleções
                {"Array - Coleções", Colecoes.Array.Executar },
                {"List - Coleções", ColecoesList.Executar },
                {"Array List - Coleções", ColecoesArrayList.Executar },
                {"Set - Coleções", ColecoesSet.Executar },
                {"Queue - Coleções", ColecoesQueue.Executar },
                {"Stack - Coleções", ColecoesStack.Executar },
                {"Dictionary - Coleções", ColecoesDictionary.Executar },

            });

            central.SelecionarEExecutar();
        }
    }
}