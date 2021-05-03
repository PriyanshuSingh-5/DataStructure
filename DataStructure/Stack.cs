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
    }
}
