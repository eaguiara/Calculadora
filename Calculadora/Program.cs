using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' });//Implemente o calculo de divisao

            Calculadora calculadora = new Calculadora();

            StringBuilder sb = new StringBuilder(); 

            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Dequeue(); 
                calculadora.Calcular(operacao); 
                sb.AppendFormat("{0} {1} {2} = {3}\n", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);
            }
            Console.WriteLine("\n--Case - Eduarda Aguiar--\n");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("-------------------------\n");

        }

    }
}
