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

    static void MyTask()
    {
        HomeWork HW = new HomeWork();
        
        Console.Write("Wich task: ");
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


            default:
                Console.WriteLine("Wrong task");
                break;
        }


    }

    
}