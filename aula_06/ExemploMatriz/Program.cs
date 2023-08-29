namespace ExemploMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] matriz = new float[2, 4];
            float[] media = new float[2];
            float soma = 0.0f;

            for (int indiceLinha = 0;  indiceLinha < matriz.GetLength(0); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < matriz.GetLength(0); indiceLinha++)
                {
                    Console.Write($"Digite a {indiceColuna +2} nota do Participante {indiceLinha + 1}:  ");
                    matriz[indiceLinha, indiceColuna] = Convert.ToSingle(Console.ReadLine());

                }
            }

            for (int indiceLinha = 0; indiceLinha < matriz.GetLength(0); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < matriz.GetLength(0); indiceLinha++)
                {
                    soma += matriz[indiceLinha, indiceColuna]; 
                }

                media[indiceLinha] = soma / matriz.GetLength(1);

                soma= 0.0f;

            }

            for (int indice = 0; indice < media.Length; indice++)
            {
                Console.WriteLine($"Media do participante {indice +1}: {media[indice]}");
            }
        }
    }
}