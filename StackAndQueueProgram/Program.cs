using System.Collections.Generic;

namespace StackAndQueueProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
          StackAndQueue stack = new StackAndQueue();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Programs\n1.Create Stack");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.Display();
                        break;
                }
            }
        }
    }
}