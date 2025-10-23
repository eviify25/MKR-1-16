using System;

class Program
{
    public static void Main(string[] args)
    {
 
        int[,] myArray =
        {
            { 9, 5, 8, 12 },
            { 2, 15, 3, 7 },
            { 4, 1, 6, 10 }
        };

        Console.WriteLine("Початковий масив:");
        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                Console.Write(myArray[i, j] + "\t"); 
            }
            Console.WriteLine();
        }

        int cols = myArray.GetLength(1);

        int[] resultArray = new int[cols];
        
        for (int j = 0; j < cols; j++)
        {

            int min_element = myArray[0, j];
       
            for (int i = 1; i < myArray.GetLength(0); i++)
            {

                if (myArray[i, j] < min_element)
                {
                    min_element = myArray[i, j];
                }
            }

            resultArray[j] = min_element;
        }

        Console.WriteLine("\nМасив з найменшими елементами стовпців:");
        for (int i = 0; i < resultArray.Length; i++)
        {
            Console.Write(resultArray[i] + " ");
        }
    }
}