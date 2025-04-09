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
            Console.Write("\nDigie um número inteiro: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
