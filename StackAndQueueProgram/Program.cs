﻿using System.Collections.Generic;

namespace StackAndQueueProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
          StackAndQueue<int> stack = new StackAndQueue<int>();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Programs\n1.Create Stack\n2.Pop & Peek the node using stack");
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
                }
            }
        }
    }
}