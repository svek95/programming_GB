namespace pr
{
    class HomeWork
    {
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



    }
}