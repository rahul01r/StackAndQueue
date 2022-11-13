using System.Collections.Generic;

namespace StackAndQueueProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
          StackAndQueue<int> stack = new StackAndQueue<int>();
          QueueProgram<int> queue = new QueueProgram<int>();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Programs\n1.Create Stack\n2.Pop & Peek the node using stack\n3.Enqueue the element first in first out order\n4.Delete the Node Using Queue");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.Display();
                        break;
                    case 2:
                        stack.Pop();
                        stack.Peek();
                        stack.Display();
                        break;
                    case 3:
                        queue.Enqueue(70);
                        queue.Enqueue(30);
                        queue.Enqueue(56);
                        queue.Display();
                        break;
                    case 4:
                        queue.Dequeue();
                        queue.Display();
                        break;
                }
            }
        }
    }
}