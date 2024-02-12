using GenericQueue;

class Program
{
    static void Main()
    {
        GQueue<Chat> queue = new GQueue<Chat>();
        string content;
        int messageId = 1000;
        DateTime timeStamp;
        int sourceId = 2000;

        while (true)
        {
            Console.WriteLine("1.Enqueue chat message");
            Console.WriteLine("2.Dequeue chat message");
            Console.WriteLine("3.Check if Queue is empty");
            Console.WriteLine("4.Check if Queue is full");
            Console.WriteLine("5.Exit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter a message: ");
                    content = Console.ReadLine();
                    messageId++;
                    timeStamp = DateTime.Now;
                    sourceId++;
                    Chat message = new Chat(content, messageId, timeStamp, sourceId);
                    queue.Enqueue(message);
                    Console.WriteLine("Message added successfully!");
                    break;
                case 2:
                    Chat deletedMessage = queue.Dequeue();
                    Console.WriteLine($"Deleted message : {deletedMessage.Content}");
                    break;
                case 3:
                    Console.WriteLine(queue.isEmpty() ? "Queue is empty!" : "Queue is not empty");
                    break;
                case 4:
                    Console.WriteLine(queue.isFull()? "Queue is full!" : "Queue is not full");
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }
}