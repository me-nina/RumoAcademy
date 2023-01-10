namespace atividadecd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você deseja calcular o lucro de quantos tipos de produto: ");
            int quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
            string?[] nomesProdutos = new string[quantidadeProdutos];
            decimal[] lucros = new decimal[quantidadeProdutos];

            string[] vetorProdutos = new string[quantidadeProdutos];

            //coletando informações
            for (int i = 0; i < quantidadeProdutos; i++)
            {
                Console.Clear();
                Console.WriteLine("Qual o nome do produto? ");
                nomesProdutos[i] = Console.ReadLine();
                Console.WriteLine("Qual a quantidade de unidades vendidas? ");
                int quantidade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Qual o preço de compra? ");
                decimal precoCompra = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Qual o preço de venda? ");
                decimal precoVenda = Convert.ToDecimal(Console.ReadLine());

                lucros[i] = (precoVenda - precoCompra) * quantidade;

            }

            Console.Clear();
            Console.WriteLine("Cada tipo de produto obteve o lucro: " + Environment.NewLine);

            //imprimindo os tipos de produto com lucro
            for (int i = 0; i < quantidadeProdutos; i++)
            {

                Console.WriteLine("Produto: " + nomesProdutos[i] + " teve um lucro de: R$ " + lucros[i]);

            }

        }
    }
}