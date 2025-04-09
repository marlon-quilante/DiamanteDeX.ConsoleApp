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

                DesenhoDiamante(numero);
                Console.ReadLine();
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

        static void DesenhoDiamante(int numero)
        {
            Console.WriteLine();
            int qtdEspacoEmBranco = (numero / 2);
            int qtdLinhas = ((numero / 2) + 1);

            for (int linha = 1; linha <= qtdLinhas; linha++)
            {
                for (int coluna = 1; coluna <= numero; coluna++)
                {
                    int xPosicaoInicial = qtdEspacoEmBranco + 1;
                    int xPosicaoFinal = numero - (xPosicaoInicial - 1);

                    if (coluna >= xPosicaoInicial && coluna <= xPosicaoFinal)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                qtdEspacoEmBranco--;
            }
        }
    }
}