namespace pr;

public class Start
{
    static void Main()
    {
        Console.Write("HW or Practic: ");
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
               
                break;

            case 4:
                
                break;


            default:
                Console.WriteLine("Wrong task");
                break;
        }


    }

    
}