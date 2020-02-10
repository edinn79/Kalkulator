using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prvi broj");
            decimal prviBroj = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("Unesite drugi broj");
            decimal drugiBroj = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("Unesite operaciju");
            string op = Console.ReadLine();

            if(op == "+")
                {
                    Console.WriteLine("Vas zbir je" + " " + (prviBroj + drugiBroj));
                }
            else if(op == "-")
                {
                    Console.WriteLine("Vasa razlika je" + " " + (prviBroj - drugiBroj));

                }
            else if(op == "*")
                {
                    Console.WriteLine("Vas proizvod je" +" " + (prviBroj * drugiBroj));
                }
            else if(op == "/")
                {
                     Console.WriteLine("Vas kolicnik je" + " " + (prviBroj / drugiBroj));
                } 
            else if (op == "%")
                {
                Console.WriteLine("Vas moduo je" + " " + (prviBroj % drugiBroj));   
                } 
                
            else
                {
                    Console.WriteLine("Izabrali ste nepostojecu operaciju");
                }




            Console.ReadKey();

        }
        
    }
}
