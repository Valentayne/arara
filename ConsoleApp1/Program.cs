namespace ConsoleApp1
{
    internal class Program
    {
        static void Block4()
        {
            //Console.WriteLine("Введiть розмiрнiсть масива рядки i стовпчики через пробiл");
            //string[] data = Console.ReadLine().Trim().Split(' ');
            int rows = 1;
            int cols = 8;
            int[][] matrixA = new int[1][];
            matrixA[0] = new int[] { 3, 1, 4, 1, 5, 9, 2, 6 };
            int[][] matrixB = new int[rows][];
            int first = 0, last = 0;

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                first = matrixA[i][0];
                last = matrixA[i][matrixA[i].Length - 1];
                int[] arr = new int[last - first]; // 3 1 4 1 5 9 2 6
                for (int j = 0; j < arr.Length; j++)//    f     l
                {
                    arr[j] = matrixA[i][first + j]; // =4 =1 =5 -9
                }
                matrixB[i] = arr;
            }

        }
        static void Main(string[] args)
        {
            Block4();
        }
    }
}