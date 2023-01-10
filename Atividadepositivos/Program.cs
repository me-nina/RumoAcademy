using System.ComponentModel;

namespace Atividadepositivos
{
    internal class Program
    {
        //2. Faça um algoritmo que receba 15 números e exiba somente os positivos para o usuário
        static void Main(string[] args)
        {
            Console.WriteLine("O programa receberá 15 números e no final exibirá apenas os positivos para o usuário");
           
            List<int> numeroPositivo = new List<int>();

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite um número");
               int receberNumero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Esse é o número: " + (i + 1) + " de 15");
                if (receberNumero > 0) numeroPositivo.Add(receberNumero);
            }
            // escrever os números da lista numeroPositivo
            for (int i = 0; i < numeroPositivo.Count; i++)
                Console.WriteLine(numeroPositivo[i]);
        }
    }
}