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
            Console.WriteLine("3.Check Queue");
            Console.WriteLine("4.Exit");
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
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }
}