using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePessoa
{
    internal class Fluxo
    {
        public void ExecutarFluxo()
        {
            Console.WriteLine("#############################################################");
            Console.WriteLine("#### Programa para determinar qual pessoa é a mais velha ####");
            Console.WriteLine("#############################################################");

            var pessoas = new List<Pessoa>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Nome: ");
                string Nome = Console.ReadLine();

                Console.WriteLine("Idade: ");
                short idade = Convert.ToInt16(Console.ReadLine());

                var pessoa = new Pessoa();
                pessoa.Nome = Nome;
                pessoa.Idade = idade;

                pessoas.Add(pessoa);
            }
            var pessoaMaisVelha = pessoas.OrderByDescending(x => x.Idade).First();
            Console.WriteLine("A pessoa mais velha é: " + pessoaMaisVelha.Nome);
        }
    }
}
