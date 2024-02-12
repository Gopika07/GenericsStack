using GenericsStack;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the stack:");
        int sizeS = int.Parse(Console.ReadLine());
        GStack<int> stack = new GStack<int>(sizeS);
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
                    string input = Console.ReadLine().Trim();

                    if (string.IsNullOrEmpty(input))
                    {
                        stack.Push();
                    }
                    else
                    {
                        if (int.TryParse(input, out int val))
                        {
                            stack.Push(val);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer.");
                        }
                    }
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