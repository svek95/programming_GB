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
        Tools myTools = new Tools();

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
            case 41:
                Console.WriteLine("Input M numbers");
                int size3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Numbers more then 0 is: "+HW.Tak_41(HW.craeteMass(size3)));
                break;
            case 43:
                Console.WriteLine("Input b1");
                int b1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input k1");
                int k1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input b2");
                int b2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input k2");
                int k2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Dot Cross is:");
                HW.PrintArray(HW.Task_43(b1, k1, b2, k2));
                break;
            
            case 47:
                Console.WriteLine("Input number of rows: ");
                int rows = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input number of columns: ");
                int columns = Convert.ToInt32(Console.ReadLine());
                myTools.ShowDoublet2dArray(HW.Task_47(rows, columns));
                
                break;
            
            case 50:
                int[,] data50 = myTools.CreateRandom2dArray(5, 5, -10, 10);
                myTools.ShowInt2dArray(data50);
                Console.WriteLine("Input indexRows: ");
                int indexRows = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input indexColumns: ");
                int indexColumns = Convert.ToInt32(Console.ReadLine());
                HW.Task_50(data50, indexRows, indexColumns);
                break;
            
            case 52:
                int[,] data52 = myTools.CreateRandom2dArray(4, 4, 0, 3);
                myTools.ShowInt2dArray(data52);
                HW.Task_52(data52);
                
                break;
            
            case 100:
                int[] data47 = myTools.RiadeLine4data();
                myTools.ShowInt2dArray(myTools.CreateRandom2dArray(data47[0], data47[1], data47[2], data47[3]));
                
                
                break;


            default:
                Console.WriteLine("Wrong task");
                break;
        }


    }
    
    static void PracticsTask()
    
    {
        Practics pract = new Practics();
        Tools myTools = new Tools();
        
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
            
            case 10:
                Console.WriteLine("First side");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second side");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Third side");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(pract.trueTrigl(a, b, c));
                break;
            
            case 11:
                Console.WriteLine("Input number");
                int number10 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Rwsault is: ");
                pract.printArray(pract.fibanach(number10));
                break;
            
            case 12:
                Console.WriteLine("FInput number of rows: ");
                int rows = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input number of columns: ");
                int columns = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Third min");
                int min2d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Third max");
                int max2d = Convert.ToInt32(Console.ReadLine());
                int[,] myArray = myTools.CreateRandom2dArray(rows, columns, min2d, max2d);
                myTools.ShowInt2dArray(myArray); 
                Console.WriteLine(" ");
                Console.WriteLine("Resault:");
                int[,] myArrayRev = pract.Task1_8(myArray);
                myTools.ShowInt2dArray(myArrayRev);
                
                break;

            default:
                Console.WriteLine("Wrong task");
                break;
        }


    }

    
}