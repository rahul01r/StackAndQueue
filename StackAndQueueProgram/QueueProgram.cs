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
