using static System.Runtime.InteropServices.JavaScript.JSType;

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
                DesenhoDoDiamante(numero);
                Console.WriteLine("\nPressione ENTER para criar outro diamante...");
                Console.ReadLine();
            }
        }

        static void CabecalhoInicial()
        {
            Console.Clear();
            Console.WriteLine("------------------");
            Console.WriteLine("  Diamante de X");
            Console.WriteLine("------------------");
        }

        static int NumeroDeEntrada()
        {
            int numero = 0;

            try
            {
                Console.WriteLine("\nInforme abaixo o tamanho do diamante que deseja criar. " +
                    "O número do tamanho precisa ser inteiro, ímpar e maior que 1!");
                Console.Write("\nNúmero do tamanho: ");
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

        static void DiamanteParteSuperior(int numero)
        {
            Console.WriteLine();
            int qtdEspacoEmBranco = (numero / 2);
            int qtdLinhas = ((numero / 2) + 1);

            for (int linha = 1; linha <= qtdLinhas; linha++)
            {
                for (int coluna = 1; coluna <= numero; coluna++)
                {
                    int primeiraPosicaoDeX = qtdEspacoEmBranco + 1;
                    int ultimaPosicaoDeX = numero - (primeiraPosicaoDeX - 1);

                    if (coluna >= primeiraPosicaoDeX && coluna <= ultimaPosicaoDeX)
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

        static void DiamanteParteInferior(int numero)
        {
            int qtdEspacoEmBranco = 1;
            int qtdLinhas = numero / 2;

            for (int linha = 1; linha <= qtdLinhas; linha++)
            {
                for (int coluna = 1; coluna <= numero; coluna++)
                {
                    int primeiraPosicaoDeX = qtdEspacoEmBranco + 1;
                    int ultimaPosicaoDeX = numero - (primeiraPosicaoDeX - 1);

                    if (coluna >= primeiraPosicaoDeX && coluna <= ultimaPosicaoDeX)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                qtdEspacoEmBranco++;
            }
        }

        static void DesenhoDoDiamante(int numero)
        {
            DiamanteParteSuperior(numero);
            DiamanteParteInferior(numero);
        }
    }
}