namespace pr
{
    class HomeWork
    {
        Practics pract = new Practics();
        int resaultHW;
        private int counter;
        
        public void First_task()
        {
            Console.Write("Input first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                Console.WriteLine("Max is: " + a);
            else
                Console.WriteLine("Max is: " + b);
        }

        public void Second_task()
        {
            int max;

            Console.Write("Input first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input third number: ");
            int c = Convert.ToInt32(Console.ReadLine());

            /// use standart System.Math
            // Console.WriteLine("Max is: " + Math.Max(a, Math.Max(b, c)));

            max = b > a ? b : a;
            max = max > c ? max : c;
            Console.WriteLine("Max is: " + max);

        }

        public void Third_task()
        {
            Console.Write("Input number for check even: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            if (inputNumber % 2 == 0)
                Console.WriteLine("Even");

            else
                Console.WriteLine("Not even");

        }

        public void Foth_task()
        {
            int current = 1;
            Console.Write("Input number: ");
            int numberTask4 = Convert.ToInt32(Console.ReadLine());

            while (current <= numberTask4)
            {
                if (current % 2 == 0)
                    Console.WriteLine(current);
                current++;
            }


        }

        public int Task_10(int number)
        {   
            resaultHW  = number % 100 / 10;
            return resaultHW;
        }

        public void Task_13(int number)
        {
            string numberToString = Convert.ToString(number);
            if (numberToString.Length > 2){
                Console.WriteLine("Third digit is: " + numberToString[2]);
            }
            else {
                Console.WriteLine("Third digit is empty");
            }
        }

        public void Task_15(int dateNumber)
        {
            if (dateNumber <= 0 || dateNumber > 7)
            {
                Console.WriteLine("Not a day!!!");
            }
            else if (dateNumber == 6 || dateNumber == 7)
                Console.WriteLine("Yes");
            else
            {
                Console.WriteLine("No!!!");
            }
        }

        public void Task_19(string number)
        {   
            bool isNumeric = int.TryParse(number, out int n);
            if (number.Length != 5 || isNumeric is false)
                Console.WriteLine("Number is wrong or not is number");
            else
            { 
                string reverseNumber = string.Concat(number.Reverse());
                Console.WriteLine(number == reverseNumber ? "YES" : "NO");   
            }
        }
        
        public void Task_23(int number)
        {
            counter = 1;
            while (counter <= number)
            {
                int cube = counter * counter * counter;
                Console.WriteLine($"{counter}^3 = {cube}");
                counter++;
            }
        }

        public int Task_27(int number)
        {
            if (number == 0)
                return 0;
            else
                return number % 10 + Task_27(number / 10);
        }

        public void Task_29(int size)
        {
            int[] array = new int[size];
            
           for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Input {i} number to array");
                int number = Convert.ToInt32(Console.ReadLine());
                array[i] = number;
            }

            /// Ввод рандомных элементов массива 
/*            Random myRandom = new Random();
 
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = myRandom.Next(0, 100000); /// чтобы цифры были не over99999 
             //   Console.Write("{0} ", array[i]);
            }*/

            Console.WriteLine("Array is: " + "[{0}]", string.Join(", ", array));
        }

        public void PrintArray(double[] array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }
        
        public int Task_34(int[] array)
        {
            counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    counter++;

            }
            return counter;
        }

        public int Task_36(int[] array)
        {
            resaultHW = 0; 
            for (int i = 1; i < array.Length; i++)
            {
                if (i % 2 != 1)
                    resaultHW += array[i];

            }
            return resaultHW;
        }
        
        public void Task_38(int[] array)
        {
            resaultHW = 0;
            int maxElement = array[0];
            int minElement = array[0];                
            for (int i = 1; i < array.Length; i++)
            {
                if (maxElement < array[i])
                {
                    maxElement = array[i];
                }
                if (minElement > array[i])
                {
                    minElement = array[i];
                }
                
                resaultHW = maxElement - minElement;

            }
            Console.WriteLine($"\nDev between max element ({maxElement}) and min ({minElement}) is: {resaultHW}");
        }

        public int[] craeteMass(int size)
        {
            int[] array = new int[size];
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Input {i+1} number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                array[i] = number;
            }

            return array;

        }

        public int Tak_41(int[] array)
        {
            counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > 0 ) counter += 1; 
            }
            return counter;
        }

        public double[] Task_43(double b1, double k1, double b2, double k2)
        {
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;
            double[] dotCross = new[] {x, y};

            return dotCross;

            //          Console.WriteLine("x = " + x + "y = " + y );

        }

        public double[,] Task_47(int rows, int columns)
        {
            Random rand = new Random();
            double[,] newArray = new double[rows, columns];
            Console.WriteLine("   ");
            for (int i = 0; i < rows; i++)
            for (int k = 0; k < columns; k++)
                newArray[i, k] =  rand.Next(-100, 200) + rand.Next(0, 9) / 10.0;
            return newArray;

        }


        public void Task_50(int[,] array, int rowsIndex, int columnsIndex)
        {
            if (rowsIndex > array.GetLength(0) || columnsIndex > array.GetLength(1)) 
                Console.WriteLine($"Not element in array in [{rowsIndex},{columnsIndex}]");

            else
                Console.WriteLine("Element  in [{rowsIndex},{columnsIndex}] is: " + array[rowsIndex, columnsIndex]);
            
        }

        public void Task_52(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int meanArray = 0;
                int ColChetn = 0;
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    meanArray += array[k, i];

                }

                Console.WriteLine($"Arithmetic mean of column elements {i + 1} = {(float)meanArray / array.GetLength(1)}");

            }

        }

        public int[,] Task_54(int[,] array2d)
        {
            for (int i = 0; i < array2d.GetLength(0); i++)
            for (int j = 0; j < array2d.GetLength(1); j++)
            for (int k = 0; k < array2d.GetLength(1) - 1; k++)
                if (array2d[i, k] < array2d[i, k + 1])
                    (array2d[i, k + 1], array2d[i, k]) = (array2d[i, k], array2d[i, k + 1]);

            return array2d;
        }

        int i = 0;
        int row = 0;
        public int Task_56(int[,] array2d)
        {
            
            int summ = 0, summ1 = 0, summ2 = 0;
            
            for(int i = 0; i < array2d.GetLength(0); i++) 
                for(int j = 0; j < array2d.GetLength(1); j++) 
                    summ2 += array2d[i, j];  
                if(summ2 < summ1)
                   summ = summ2; row = i;
                summ1 = summ2;
                
           return row;

        }


        public int[,] Task_62(int n)
        {
            int[,] snakeArray = new int[n, n];

            int temp = 1;
            int i = 0, j = 0;
            
            while (temp <= snakeArray.GetLength(0) * snakeArray.GetLength(1))
            {
                snakeArray[i, j] = temp;
                temp++;
                if (i <= j + 1 && i + j < snakeArray.GetLength(1) - 1)
                    j++;
                else if (i < j && i + j >= snakeArray.GetLength(0) - 1)
                    i++;
                else if (i >= j && i + j > snakeArray.GetLength(1) - 1)
                    j--;
                else
                    i--;
            }

            return snakeArray;
        }





    }
}