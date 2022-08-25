// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace QueuePracticeProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Queue <string> queue = new Queue<string>();
            queue.Enqueue("56");
            queue.Enqueue("30");
            queue.Enqueue("70");

            foreach (string ele in queue)
            {
                Console.WriteLine(ele);

            }
            Console.WriteLine("The Peek element is " + queue.Peek());

            Console.WriteLine("-------------------");

            queue.Dequeue();

            foreach(string ele in queue)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("The Peek element is " + queue.Peek());

            Console.WriteLine("-------------------");
        }
    }
}