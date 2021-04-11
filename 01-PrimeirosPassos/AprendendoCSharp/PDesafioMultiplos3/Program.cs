using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDesafioMultiplos3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int contador = 1; contador <= 100; contador++)
            {
                if(contador%3 == 0)
                {
                    Console.WriteLine(contador);
                }
            }
            Console.ReadLine();
        }
    }
}
