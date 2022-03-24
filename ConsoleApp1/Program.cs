using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f;
            int o, verifica, result;

            verifica = 1;
            while (verifica != 0)
            {
                Console.Write("Primeiro número: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Entre com o segundo número: ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Selecione a operação: ");
                Console.WriteLine("1-Adição");
                Console.WriteLine("2-Subtração");
                Console.WriteLine("3-Multiplicação");
                Console.WriteLine("4-Divisão");
                o = Convert.ToInt32(Console.ReadLine());

                if (o == 1)
                {
                    c = a + b;
                    Console.WriteLine("Resultado da adição: " + c);
                    Console.WriteLine("Deseja fazer mais uma conta?");
                    Console.WriteLine("1 - SIM");
                    Console.WriteLine("2 - NÃO");
                    result = Convert.ToInt32(Console.ReadLine());
                    if (result == 1)
                    {
                        verifica = 1;
                    }
                    else
                    {
                        verifica = 0;
                        Environment.Exit(0);
                    }

                }
                else if (o == 2)
                {
                    d = a - b;
                    Console.WriteLine("Resultado da subtração: " + d);
                    Console.WriteLine("Deseja fazer mais uma conta?");
                    Console.WriteLine("1 - SIM");
                    Console.WriteLine("2 - NÃO");
                    result = Convert.ToInt32(Console.ReadLine());
                    if (result == 1)
                    {
                        verifica = 1;
                    }
                    else
                    {
                        verifica = 0;
                        Environment.Exit(0);
                    }
                }
                else if (o == 3)
                {
                    e = a * b;
                    Console.WriteLine("Resultado da multiplicação: " + e);
                    Console.WriteLine("Deseja fazer mais uma conta?");
                    Console.WriteLine("1 - SIM");
                    Console.WriteLine("2 - NÃO");
                    result = Convert.ToInt32(Console.ReadLine());
                    if (result == 1)
                    {
                        verifica = 1;
                    }
                    else
                    {
                        verifica = 0;
                        Environment.Exit(0);
                    }
                }
                else if (o == 4)
                {
                    f = a / b;
                    Console.WriteLine("Resultado da divisão: " + f);
                    Console.WriteLine("Deseja fazer mais uma conta?");
                    Console.WriteLine("1 - SIM");
                    Console.WriteLine("2 - NÃO");
                    result = Convert.ToInt32(Console.ReadLine());
                    if (result == 1)
                    {
                        verifica = 1;
                    }
                    else
                    {
                        verifica = 0;
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Opção não encontrada.");
                    verifica = 1;
                }
            }


            Console.ReadKey();
        }
    }
}
