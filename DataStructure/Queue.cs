using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Queue
    {
        Node head;

        
        public void Enqueue(int data) //for inserting data in queue
        {
            //creating and initializing node with data
            Node node = new Node(data);
            Node temp = head;
           
            if (head == null)
            {
                head = node;
            }
            else
            {
                
                Node lastNode = GetLastNode(temp);
                lastNode.next = node;
            }
            Console.WriteLine("Element inserted in queue:\t{0}", node.data);

        }
        
        public Node GetLastNode(Node temp) //method to get last node
        {
            if (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
       
        public void DisplayQueue() //to display the changes
        {
            Console.WriteLine("\nDisplaying the Queue");
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("empty queue");
            }
            else
            {
                
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
        
        public int QueuePeek() //peek mathod
        {
            if (head == null)
            {
                Console.WriteLine("Empty Queue");
            }

            Console.WriteLine("Peek method for queue");
            Console.WriteLine(head.data);
            return head.data;
        }
        
        public void Dequeue()//deleting from queue
        {
            if (head == null)
            {
                Console.WriteLine("Empty Queue");
            }
           
            head = head.next;
            DisplayQueue();


        }
        public void IsEmptyQueue()  //checking whether queue is empty
        {
            Node temp = head;
            while (temp != null)
            {
                QueuePeek();
                Dequeue();
                temp = temp.next;
            }
        }
    }
}
