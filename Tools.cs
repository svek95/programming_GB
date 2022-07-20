namespace pr;

public class Tools
{

    public int[] RiadeLine4data()
    {
        
        Console.WriteLine("FInput number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Third min");
        int min2d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Third max");
        int max2d = Convert.ToInt32(Console.ReadLine());

        int[] return4Data = new[] { rows, columns, min2d, max2d };

        return return4Data;

    }

    public int[,] CreateRandom2dArray(int rows, int columns, int minElement, int maxElement)
    {
        int[,] newArray = new int[rows, columns];
        Console.WriteLine("   ");
        for (int i = 0; i < rows; i++)
            for (int k = 0; k < columns; k++)
                newArray[i, k] = new Random().Next(minElement, maxElement + 1 );
        return newArray;

    }

    public void ShowInt2dArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
                Console.Write("{0,3}", array[i, k]+ " ");
            Console.WriteLine();
        }

           
    }
    
    public void ShowDoublet2dArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
                Console.Write("{0,3}", array[i, k]+ " ");
            Console.WriteLine();
        }

           
    }

    
    

}