﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meses_DESAFIO_ALR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            switch (variavelASerTestada)
            {
                case opção1:
                    comando(s) caso a opção 1 tenha sido escolhida
            break;
                case opção2:
                    comando(s) caso a opção 2 tenha sido escolhida
            break;
                case opção3:
                    comando(s) caso a opção 3 tenha sido escolhida
            break;
                default:
                    comando(s) caso nenhuma das opções anteriores tenha sido escolhida
}

            int mes = 13;

            switch (mes)
            {
                case 1:
                    Console.WriteLine("O mês é Janeiro");
                    break;
                case 2:
                    Console.WriteLine("O mês é Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("O mês é Março");
                    break;
                case 4:
                    Console.WriteLine("O mês é Abril");
                    break;
                case 5:
                    Console.WriteLine("O mês é Maio");
                    break;
                case 6:
                    Console.WriteLine("O mês é Junho");
                    break;
                case 7:
                    Console.WriteLine("O mês é Julho");
                    break;
                case 8:
                    Console.WriteLine("O mês é Agosto");
                    break;
                case 9:
                    Console.WriteLine("O mês é Setembro");
                    break;
                case 10:
                    Console.WriteLine("O mês é Outubro");
                    break;
                case 11:
                    Console.WriteLine("O mês é Novembro");
                    break;
                case 12:
                    Console.WriteLine("O mês é Dezembro");
                    break;
                default:
                    Console.WriteLine("Mês inválido");
                    break;
            }
            Console.ReadLine();
        }
    }
}
