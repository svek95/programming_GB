
Main();

static void Main(){
    Console.Write("Wich task: ");
    int taskNumver = Convert.ToInt32(Console.ReadLine());
    switch (taskNumver)
    {
        case 1:
            First_task();
            break;
        case 2:
            Second_task();
            break;

        case 3:
            Third_task();
            break;

        case 4:
            Foth_task();
            break;

        default:
            Console.WriteLine("Wrong task");
            break;
    }
    
    
}

static void First_task() 
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

static void Second_task()
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

static void Third_task()
{
    Console.Write("Input number for check even: ");
    int inputNumber = Convert.ToInt32(Console.ReadLine());

    if (inputNumber%2 == 0)
        Console.WriteLine("Even");

    else
        Console.WriteLine("Not even");

}

static void Foth_task()
{
    int current = 1;
    Console.Write("Input number: ");
    int numberTask4 = Convert.ToInt32(Console.ReadLine());

    while (current<= numberTask4)
    {
        if (current%2 == 0)
            Console.WriteLine(current);
        current++;
    }

    
}

