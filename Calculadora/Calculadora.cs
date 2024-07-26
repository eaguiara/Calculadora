using System;
using System.Collections.Generic;
namespace Calculadora
{
    public class Calculadora
    {
        private Stack<long> pilhaResultados = new Stack<long>();
        public void Calcular(Operacoes operacao)
        {
            switch(operacao.operador)
            {
                case '+':
                    operacao.resultado= soma(operacao);
                    break;
                case '-': 
                    operacao.resultado = subtracao(operacao);
                    break;
                case '*': 
                    operacao.resultado = multiplicacao(operacao);
                    break;
                case '/':
                    operacao.resultado = divisao(operacao);
                    break;
                default: 
                    operacao.resultado = 0; 
                    throw new InvalidOperationException("Operador desconhecido");
            }
            pilhaResultados.Push(operacao.resultado);
        }
    
        public long soma(Operacoes operacao)
        {
            return operacao.valorA + operacao.valorB;
        }
        public long subtracao(Operacoes operacao)
        {
            return operacao.valorA - operacao.valorB;
        }
        public long multiplicacao(Operacoes operacao)
        {
            return operacao.valorA * operacao.valorB;
        }
        public long divisao (Operacoes operacao)
        {
            return operacao.valorA / operacao.valorB;
        }
       
    }
}
