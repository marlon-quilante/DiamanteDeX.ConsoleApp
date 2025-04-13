namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                CabecalhoInicial();
                Diamante.NumeroTamanho = NumeroDeEntrada();

                while (!NumeroValidado())
                {
                    CabecalhoInicial();
                    Diamante.NumeroTamanho = NumeroDeEntrada();
                }

                Diamante.Desenho();
                if (!CriarNovoDiamante())
                {
                    break;
                }
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

                return numero;
            }
            catch (Exception ex)
            {
                Console.Write("\nOcorreu um erro inesperado! Pressione ENTER e tente novamente...");
                Console.ReadLine();
                return 0;
            }
        }

        static bool ValidarNumeroZero()
        {
            while (Diamante.NumeroTamanho == 0)
            {
                CabecalhoInicial();
                Console.WriteLine("\nO número digitado é zero!");
                Console.Write("\nDigite um número inteiro ímpar maior que 1: ");
                Diamante.NumeroTamanho = int.Parse(Console.ReadLine());

                return true;
            }

            return false;
        }

        static bool ValidarNumeroNegativo()
        {
            while (Diamante.NumeroTamanho < 0)
            {
                CabecalhoInicial();
                Console.WriteLine("\nO número digitado é negativo!");
                Console.Write("\nDigite um número inteiro ímpar maior que 1: ");
                Diamante.NumeroTamanho = int.Parse(Console.ReadLine());

                return true;
            }

            return false;
        }

        static bool ValidarNumero1()
        {
            while (Diamante.NumeroTamanho == 1)
            {
                CabecalhoInicial();
                Console.WriteLine("\nO número digitado é 1!");
                Console.Write("\nDigite um número inteiro ímpar maior que 1: ");
                Diamante.NumeroTamanho = int.Parse(Console.ReadLine());

                return true;
            }

            return false;
        }

        static bool ValidarNumeroPar()
        {
            while (Diamante.NumeroTamanho % 2 == 0)
            {
                CabecalhoInicial();
                Console.WriteLine("\nO número digitado não é ímpar!");
                Console.Write("\nDigite um número inteiro ímpar maior que 1: ");
                Diamante.NumeroTamanho = int.Parse(Console.ReadLine());

                return true;
            }

            return false;
        }

        static bool NumeroValidado()
        {
            while (true)
            {
                if (!ValidarNumeroZero() && !ValidarNumeroNegativo() && !ValidarNumero1() && !ValidarNumeroPar() && Diamante.NumeroTamanho != 0)
                {
                    break;
                }
            }

            return true;
        }

        static bool CriarNovoDiamante()
        {
            Console.WriteLine("\n1- Criar outro diamante");
            Console.WriteLine("2- Sair");

            Console.Write("\nDigite uma das opções: ");
            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                return true;
            }
            else if (opcao == "2")
            {
                return false;
            }
            else
            {
                Console.WriteLine("\nOpção inválida! O programa será encerrado...");
                return false;
            }
        }
    }
}