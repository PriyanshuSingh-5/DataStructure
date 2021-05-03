using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Stack
    {
        public Node top;

        public void Push(int newData)
        {
            Node newNode = new Node(newData);
            if(this.top != null)
            {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine("New node added" + newNode.data);
        }

        public void Peek()
        {
            if(this.top== null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine("the element after peeking is" + this.top.data);
        }

        public void Pop()
        {
            if(this.top == null)
            {
                Console.WriteLine("no element to pop");
                return;
            }
            this.top = this.top.next;
        }
    }
}
