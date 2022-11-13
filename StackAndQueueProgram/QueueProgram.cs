using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueProgram
{
    public class QueueProgram<T>
    {
        private Node<T> top;
        private Node<T> head;
        public QueueProgram()
        {
            this.top = null;
        }
        public void Enqueue(T value)
        {
            Node<T> node = new Node<T>(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to queue", value);
        }
        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("queue is empty,Deletion is not possible");
                return;
            }
            else
            {
                while (this.head != null)
                {
                    Console.WriteLine("value Dequeue is {0}", this.head.data);
                    this.head = this.head.next;
                }
            }
        }
        public void Display()
        {
            Node<T> temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
