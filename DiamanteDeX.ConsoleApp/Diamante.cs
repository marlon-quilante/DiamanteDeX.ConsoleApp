namespace DiamanteDeX.ConsoleApp
{
    internal static class Diamante
    {
        public static int NumeroTamanho = 0;

        public static void Desenho()
        {
            DesenhoParteSuperior();
            DesenhoParteInferior();
        }

        static void DesenhoParteInferior()
        {
            int qtdEspacoEmBranco = 1;
            int qtdLinhas = NumeroTamanho / 2;

            for (int linha = 1; linha <= qtdLinhas; linha++)
            {
                for (int coluna = 1; coluna <= NumeroTamanho; coluna++)
                {
                    int primeiraPosicaoDeX = qtdEspacoEmBranco + 1;
                    int ultimaPosicaoDeX = NumeroTamanho - (primeiraPosicaoDeX - 1);

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

        static void DesenhoParteSuperior()
        {
            Console.WriteLine();
            int qtdEspacoEmBranco = (NumeroTamanho / 2);
            int qtdLinhas = ((NumeroTamanho / 2) + 1);

            for (int linha = 1; linha <= qtdLinhas; linha++)
            {
                for (int coluna = 1; coluna <= NumeroTamanho; coluna++)
                {
                    int primeiraPosicaoDeX = qtdEspacoEmBranco + 1;
                    int ultimaPosicaoDeX = NumeroTamanho - (primeiraPosicaoDeX - 1);

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
    }
}