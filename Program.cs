namespace Zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] a = new double[3, 3];

            Console.WriteLine("Въведете 3x3 матрица (3 реда по 3 числа):");
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    a[i, j] = double.Parse(Console.ReadLine());

            double det =
                  a[0, 0] * (a[1, 1] * a[2, 2] - a[1, 2] * a[2, 1])
                - a[0, 1] * (a[1, 0] * a[2, 2] - a[1, 2] * a[2, 0])
                + a[0, 2] * (a[1, 0] * a[2, 1] - a[1, 1] * a[2, 0]);

            Console.WriteLine("Детерминантата е: " + det);
        }
    }
}

