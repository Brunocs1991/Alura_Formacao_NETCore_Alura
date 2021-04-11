using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();
        }
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "qwe");
            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "123";
            sistemaInterno.Logar(camila, "123");
            sistemaInterno.Logar(camila, "qwe");
            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123";
            sistemaInterno.Logar(parceiro, "123");
            sistemaInterno.Logar(parceiro, "qwe");
        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";
            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";
            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            Desenvolvedor guilherme = new Desenvolvedor("456.175.486-20");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registar(pedro);
            gerenciadorBonificacao.Registar(roberta);
            gerenciadorBonificacao.Registar(igor);
            gerenciadorBonificacao.Registar(camila);
            gerenciadorBonificacao.Registar(guilherme);

            Console.WriteLine("Total de bonificação do mês " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
