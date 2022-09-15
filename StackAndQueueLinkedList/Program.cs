using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Stack and Queue Programs");
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();

            linkedListStack.Peek();
            linkedListStack.Pop();
            linkedListStack.IsEmpty();
        }
    }
}
