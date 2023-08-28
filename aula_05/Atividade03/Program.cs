namespace atividade03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            int resultado = 0, resultado2 = 0;

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(0); coluna++)
                {
                    Console.WriteLine($"Escreva os números: matriz[{linha}],[{coluna}] = ");
                    matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine($"Elementos da Diagonal Principal são:{matriz[0,0]},{matriz[1,1]},{matriz[2,2]}:");
            Console.WriteLine($"Elementos da Diagonal Segundária são:{matriz[2,0]},{matriz[1,1]},{matriz[0,2]}:");
            resultado = matriz[0,0] + matriz[1,1] + matriz[2,2];
            resultado2 = matriz[2,0] + matriz[1,1] + matriz[0,2];
            Console.WriteLine($"Soma dos elementos da Diagonal principal: {resultado} ");
            Console.WriteLine($"Soma dos elementos da Diagonal segundaria:{resultado2} ");
        }   
    }
}                         