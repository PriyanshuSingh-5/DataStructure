using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
       public  static void Main(string[] args)
        {
            Console.WriteLine("Welcome to data structure");
            LinkedList list = new LinkedList();
            list.InsertLast(56);
            list.InsertLast(30);
            list.InsertLast(70);

            //list.InsertFront(70);
            //list.InsertFront(30);
            //list.InsertFront(56);


            //list.InsertFront(70);
            //list.InsertFront(56);
            //list.InsertAtParticularPosition(2, 30);

            //list.DeleteFirstNode();

            // list.DeleteLastNode();

            //list.Search(30);


            //Console.WriteLine("Deleting 40");
            //list.DeleteAny(40);

            //Stack stack = new Stack();
            //stack.Push(70);
            //stack.Push(30);
            //stack.Push(56);

            //stack.Pop();

            // stack.Peek();

            // list.Search(30);
            //list.Display();
            //list.InsertAfter(40, 30);


            Queue queue = new Queue();
            
            queue.Enqueue(44);
            queue.Enqueue(33);
            queue.Enqueue(23);
            queue.DisplayQueue();
            
            //queue.QueuePeek();
            
            //queue.Dequeue();
            
            //queue.IsEmptyQueue();
            Console.ReadLine();

        }
    }
}
