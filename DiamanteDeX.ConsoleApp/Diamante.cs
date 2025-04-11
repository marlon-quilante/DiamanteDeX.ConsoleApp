namespace DiamanteDeX.ConsoleApp
{
    internal static class Diamante
    {

        public static void Desenho(int numero)
        {
            DesenhoParteSuperior(numero);
            DesenhoParteInferior(numero);
        }

        static void DesenhoParteInferior(int numero)
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

        static void DesenhoParteSuperior(int numero)
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
    }
}