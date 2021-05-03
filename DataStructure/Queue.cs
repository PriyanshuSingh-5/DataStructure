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
        public void Enqueue(int item)
        {
            Node new_node = new Node(item)
            if(this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node temp = this.head;
                while(temp.next! = null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
            Console.WriteLine("inserted into list" + new_node.data);
        }
    }
}
