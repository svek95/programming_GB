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
        Practics pract = new Practics();

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
            case 27:
                PrintNumberConsole();
                Console.WriteLine("Resault is: " + HW.Task_27(ReadIntNumber()));
                break;
            case 29:
                Console.WriteLine("Length for array: ");
                HW.Task_29(ReadIntNumber());
                break;
            case 34:
                Console.WriteLine("Input size mass");
                int size = Convert.ToInt32(Console.ReadLine());
                int min = 100;
                int max = 999;
                Console.WriteLine("Evan's number is: " + HW.Task_34(pract.newRandomMass(size, min, max)));
                break;
            case 36:
                Console.WriteLine("Input size mass");
                int size1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input min");
                int min1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input max");
                int max1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Summ is: " + HW.Task_36(pract.newRandomMass(size1, min1, max1)));
                break;
            case 38:
                Console.WriteLine("Input size mass");
                int size2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input min");
                int min2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input max");
                int max2 = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Summ is: " + HW.Task_38(pract.newRandomMass(size2, min2, max2)));
                HW.Task_38(pract.newRandomMass(size2, min2, max2));
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
            
            case 8:
                Console.WriteLine("Input size mass");
                int size = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input min");
                int min = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input max");
                int max = Convert.ToInt32(Console.ReadLine());
                pract.chengeMass(pract.newRandomMass(size, min, max));
                break;
            
            case 9:
                Console.WriteLine("Input min");
                int min1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input max");
                int max1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Count: " + pract.mass20random(pract.newRandomMass(20, min1, max1)));

                break;

            default:
                Console.WriteLine("Wrong task");
                break;
        }


    }

    
}