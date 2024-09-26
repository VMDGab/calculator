class Program
{
    static void Main(string[] args)
    {
        bool novaOperacao = true;

        while (novaOperacao)
        {
            Console.WriteLine("Informe o tipo de operação (Soma, subtração, divisão ou multiplicação)");
            String operacao = Console.ReadLine();

            if (
                operacao.ToLower() != "soma" &&
                operacao.ToLower() != "subtração" &&
                operacao.ToLower() != "divisão" &&
                operacao.ToLower() != "multiplicação"
                )
            {
                Console.WriteLine("Erro! Informe uma operação válida");
                return;
            }

            Console.WriteLine("Informe o primeiro valor");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor");
            double valor2 = double.Parse(Console.ReadLine());

            if (operacao.ToLower() == "soma")
            {
                Console.WriteLine("\nO resultado da soma é:");
                double resultado = Soma.calcular(valor1, valor2);
                Console.WriteLine(resultado);
            }
            else if (operacao.ToLower() == "subtração")
            {
                Console.WriteLine("\nO resultado da subtração é:");
                double resultado = Subtracao.calcular(valor1, valor2);
                Console.WriteLine(resultado);
            }
            else if (operacao.ToLower() == "multiplicação")
            {
                Console.WriteLine("\nO resultado da multiplicação é:");
                double resultado = Multiplicacao.calcular(valor1, valor2);
                Console.WriteLine(resultado);
            }
            else if (operacao.ToLower() == "divisão")
            {
                Console.WriteLine("\nO resultado da divisão é:");
                double resultado = Divisao.calcular(valor1, valor2);
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("Erro! Não foi possivel realizar a operação");
            }

            Console.WriteLine("Deseja realizar uma nova operação?");
            String resposta = Console.ReadLine();

            if (resposta.ToLower() == "não")
            {
                Console.WriteLine("Saindo...");
                novaOperacao = false;
            }
            else
            {
                novaOperacao = true;
            }

        }

    }
}