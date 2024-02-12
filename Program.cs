using GenericsStack;

class Program
{
    static void Main()
    {
        GStack<int> stack = new GStack<int>();
        int choice;
        while (true)
        {
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Peek");
            Console.WriteLine("4. Exit");

            Console.WriteLine("Enter your Choice:");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter a value to push");
                    int val = int.Parse(Console.ReadLine());
                    stack.Push(val);
                    break;
                case 2:
                    if (stack.IsEmpty())
                    {
                        Console.WriteLine("Stack is empty!");
                    }
                    else
                    {
                        int valPop = stack.Pop();
                        Console.WriteLine("Value popped:" + valPop);
                    }
                    break;
                case 3:
                    if (stack.IsEmpty())
                    {
                        Console.WriteLine("Stack is empty!");
                    }
                    else
                    {
                        int valTop = stack.Peek();
                        Console.WriteLine("Top most element is:" + valTop);
                    }
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You have Entered Wrong Choice");
                    break;

            }
        }
    }
}