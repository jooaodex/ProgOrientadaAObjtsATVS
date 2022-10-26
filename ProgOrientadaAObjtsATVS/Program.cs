using ProgOrientadaAObjtsATVS;
using System;
using System.Globalization;

namespace Atividades
{
    class Program
    {
        static void Main(string[] args)
        {
             Pessoa x, y;
            x = new Pessoa();
            y= new Pessoa();

            Console.WriteLine("Informe o nome e a idade da primeira pessoa:");
            x.Nome = Console.ReadLine();
            x.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome e a idade da segunda pessoa");

            y.Nome = Console.ReadLine();
            y.Idade = int.Parse(Console.ReadLine());

            if (x.Idade > y.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + x.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + y.Nome);
            }

            ////////////////////////////////////////////////////////////

            Funcionario a, b;
            double mediaSalario;
            a = new Funcionario();
            b = new Funcionario();

            Console.WriteLine("Informe nome e salário do primeiro funcionário: ");
            a.Nome = Console.ReadLine();
            a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe nome e salário do segundo funcionário: ");
            b.Nome = Console.ReadLine();
            b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaSalario = (a.Salario + b.Salario) / 2;

            Console.WriteLine("Salário médio: " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture)); 

            //////////////////////////////////////////////////////////////////
            Produto p;
            p = new Produto();
            

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome Produto: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço do produto: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); ;

            Console.Write("Quantidade do produto: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto:" + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int Rqte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(Rqte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizado: " + p);

            
            
        }

    }
}
