using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            String Operacao;
            Double Valor;
            Double Total;
            Operacao = "+";
            Total = 0;

            

            while (Operacao != "=")
            {
                Console.Clear();
                Console.WriteLine("Calculadora Teste - Por Vinicius Henrique Moraes.");
                Console.WriteLine("Total = " + Convert.ToString(Total));
            
            Console.Write("Valor --> ");
            Valor = Convert.ToDouble(Console.ReadLine());

            Console.Write("Operação --> ");
            Operacao = Console.ReadLine();

            switch (Operacao)
            {
                case "+": Total = Total + Valor;
                    break;

                case "-": Total = Total - Valor;
                    break;

                case "*": Total = Total * Valor;
                    break;

                case "x": Total = Total * Valor;
                    break;

                case "/": Total = Total / Valor;
                    break;
                default:
                        Operacao = "=";
                break;
            }

            }
                Console.WriteLine("Total --> " + Convert.ToString(Total));
                
            
            Console.ReadKey();
            

        }
    }
}
