using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Executando projeto 2 - Criando Variavéis");
            int idade;
            idade = 30;
            Console.WriteLine("Sua idade  átual e = "+ idade);
            idade = 10;
            Console.WriteLine("Sua idade  foi alteara para = " + idade);
            idade = 10 + 5;
            Console.WriteLine("Sua idade atual somada + 5 e = " + idade);
            idade = 10 + 5 * 2;
            Console.WriteLine("sua idade somada + 5 * 2 e: " + idade);
            idade = (10 + 5) * 2;
            Console.WriteLine("Expressão (idade + 5 )* 2 e: " + idade);

            Console.WriteLine("Execução finalizada. Tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
