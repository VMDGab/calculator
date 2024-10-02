class Program
{
    static void Main(string[] args)
    {
        bool novaOperacao = true;
        double resultado = 0.0;

        while (novaOperacao)
        {
            Console.WriteLine(
                "Informe o tipo de operação" +
                "\n1 - Soma" +
                "\n2 - subtração " +
                "\n3 - multiplicação" +
                "\n4 - divisão"
                );

            String operacao = Console.ReadLine();

            if (
                operacao != "1" &&
                operacao != "2" &&
                operacao != "3" &&
                operacao != "4"
                )
            {
                Console.WriteLine("Erro! Informe uma operação válida");
                continue;
            }

            try
            {
            Console.WriteLine("Informe o primeiro valor");
            double valor1 = double.Parse(Console.ReadLine());
                      
            Console.WriteLine("Informe o segundo valor");
            double valor2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine(
                calcularResultado(valor1, valor2, operacao)
                ); 
            }
            catch { 
                Console.WriteLine("Insira valores válidos");
            }

            

            Console.WriteLine("Deseja realizar uma nova operação? S/N");
            String resposta = Console.ReadLine();

            if (resposta.ToLower() == "n")
            {
                novaOperacao = false;
            }
            else if(resposta.ToLower() == "s")
            {
                novaOperacao = true;
            }
            else
            {
                Console.WriteLine("Resposta inválida, fechando programa...");
                novaOperacao = false;
            }
        }

    }

    static string calcularResultado(double valor1, double valor2, string operacao)
    {
        double resultado = 0.0;

        switch (operacao){
            case "1":
               resultado = Soma.calcular(valor1, valor2);
                break;
            case "2":
                resultado = Subtracao.calcular(valor1, valor2);
                break;
            case "3":
                resultado = Multiplicacao.calcular(valor1, valor2);
                break;
            case "4":
                resultado = Divisao.calcular(valor1, valor2);
                break;
        }

        return $"O resultado da operação é : {resultado}";
    }
}