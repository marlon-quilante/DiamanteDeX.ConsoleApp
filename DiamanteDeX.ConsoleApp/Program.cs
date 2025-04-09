namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                CabecalhoInicial();
                int numero = NumeroDeEntrada();

                while (!NumeroValidado(numero))
                {
                    CabecalhoInicial();
                    numero = NumeroDeEntrada();
                }
            }
        }

        static void CabecalhoInicial()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Diamante de X");
            Console.WriteLine("------------------------------------");
        }

        static int NumeroDeEntrada()
        {
            int numero = 0;

            try
            {
                Console.Write("\nDigite um número inteiro ímpar maior que 1: ");
                numero = int.Parse(Console.ReadLine());

                while (true)
                {
                    if (numero == 0)
                    {
                        CabecalhoInicial();
                        Console.WriteLine("\nO número digitado é zero!");
                        Console.Write("\nDigite um número inteiro ímpar maior que 1: ");
                        numero = int.Parse(Console.ReadLine());
                    }
                    else if (numero < 0)
                    {
                        CabecalhoInicial();
                        Console.WriteLine("\nO número digitado é negativo!");
                        Console.Write("\nDigite um número inteiro ímpar maior que 1: ");
                        numero = int.Parse(Console.ReadLine());
                    }
                    else if (numero == 1)
                    {
                        CabecalhoInicial();
                        Console.WriteLine("\nO número digitado é 1!");
                        Console.Write("\nDigite um número inteiro ímpar maior que 1: ");
                        numero = int.Parse(Console.ReadLine());
                    }
                    else if (numero % 2 == 0)
                    {
                        CabecalhoInicial();
                        Console.WriteLine("\nO número digitado não é ímpar!");
                        Console.Write("\nDigite um número inteiro ímpar maior que 1: ");
                        numero = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        break;
                    }
                }

                return numero;
            }
            catch (Exception ex)
            {
                Console.Write("\nOcorreu um erro inesperado! Pressione ENTER e tente novamente...");
                Console.ReadLine();
                return 0;
            }
        }

        static bool NumeroValidado(int numero)
        {
            if (numero == 0)
            {
                return false;
            }

            return true;
        }
    }
}
