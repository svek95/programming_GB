namespace pr;

public class Start
{
    static void Main()
    {
        Console.Write("HW (1) or Practic (2): ");
        int taskNumver = Convert.ToInt32(Console.ReadLine());
        switch (taskNumver)
        {
            case 1:
                MyTask();
                break;
            case 2:
                PracticsTask();
                break;


        }
    }

    static void PrintNumberConsole()
    {
        Console.WriteLine("Input number: ");
    }
    
    static int ReadIntNumber()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    static void MyTask()
    {
        HomeWork HW = new HomeWork();

        Console.Write("Wich task: ");
        Console.WriteLine("WH2 is 10, 13, 15");
        Console.WriteLine("WH3 is 19, 23");
        int taskNumver = Convert.ToInt32(Console.ReadLine());
        switch (taskNumver)
        {
            case 1:
                HW.First_task();
                break;
            case 2:
                HW.Second_task();
                break;

            case 3:
                HW.Third_task();
                break;

            case 4:
                HW.Foth_task();
                break;
            case 10:
                Console.WriteLine("Input number: ");
                Console.WriteLine("Resault is: " + HW.Task_10(ReadIntNumber())); 
                break;
            case 13:
                Console.WriteLine("Input number: ");
                HW.Task_13(ReadIntNumber());
                break;
            case 15:
                Console.WriteLine("Input number of day: ");
                HW.Task_15(ReadIntNumber());
                break;
            case 19:
                PrintNumberConsole();
                HW.Task_19(Console.ReadLine()); 
                break;
            case 23:
                PrintNumberConsole();
                HW.Task_23(ReadIntNumber());
                break;

            default:
                Console.WriteLine("Wrong task");
                break;
        }


    }
    
    static void PracticsTask()
    {
        Practics pract = new Practics();
        
        Console.Write("Wich task: ");
        int taskNumver = Convert.ToInt32(Console.ReadLine());
        switch (taskNumver)
        {
            case 1:
                pract.MaxNamber();
                break;
            case 2:
                int task2 = Convert.ToInt32(Console.ReadLine());
                pract.Second_task_1(task2);
                break;

            case 3:
//                Console.WriteLine();
                Console.WriteLine("Input X");
                int X = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Y");
                int Y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Quarter is: " + pract.WhereDot(X, Y));
                break;

            case 4:
                Console.WriteLine("Input number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Resault is:");
                pract.Quad(number);
                break;
            case 5:
                Console.WriteLine("Input number");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Resault is:" + pract.countNumber(number1));
                break;
            case 6:
                Console.WriteLine("Input number");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Resault is:" + pract.factNumber(number2));
                break;
            case 7:
                Console.WriteLine("Input first number");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input second number");
                int B = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Step: " + pract.stepNum(A, B));
                break;

            default:
                Console.WriteLine("Wrong task");
                break;
        }


    }

    
}