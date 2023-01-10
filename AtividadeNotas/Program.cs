namespace AtividadeNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#######################################################################");
            Console.WriteLine("#### Programa que calcula a média das notas de provas de uma turma ####");
            Console.WriteLine("#######################################################################");

            int quantidadeLinhas, quantidadeColunas;

            Console.WriteLine("Quantos alunos são?");
            string? linhasInformadas = Console.ReadLine();
            quantidadeLinhas = Convert.ToInt32(linhasInformadas);

            Console.WriteLine("Quantas provas são?");
            string? colunasInformadas = Console.ReadLine();
            quantidadeColunas = Convert.ToInt32(colunasInformadas);

            var matrizNumeros = new int[quantidadeLinhas, quantidadeColunas];

            for (int contadorLinhas = 0; contadorLinhas < quantidadeLinhas; contadorLinhas++)
            {

                for (int contadorColunas = 0; contadorColunas < quantidadeColunas; contadorColunas++)
                {
                    Console.WriteLine($"Informe o número da nota do aluno {contadorLinhas + 1}, na prova {contadorColunas + 1}:");
                    int numeroInformado = Convert.ToInt32(Console.ReadLine());
                    matrizNumeros[contadorLinhas, contadorColunas] = numeroInformado;   
                }
            }


            decimal somaNumeros = 0;
            for (int contadorLinhas = 0; contadorLinhas < quantidadeLinhas; contadorLinhas++)
            {

                for (int contadorColunas = 0; contadorColunas < quantidadeColunas; contadorColunas++)
                {
                    int numeroInformado = matrizNumeros[contadorLinhas, contadorColunas];
                    if (numeroInformado < 0)
                        continue;

                    somaNumeros = somaNumeros + numeroInformado;
                    
                }
                
            }
            decimal Total = somaNumeros / (quantidadeLinhas * quantidadeColunas);
            Console.WriteLine("Média é:" + Total );
            Console.ReadKey();
        }
    }
}