using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList
    {
        public Node head;
        public void InsertLast(int new_data) //insetion of data at end
        {
            Node new_node = new Node(new_data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("inserted into list" + new_node.data);

        }
        public Node GetLastNode() //to get the node
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public void InsertFront(int new_data)   //Insert data at front
        {
            Node new_node = new Node(new_data);
            new_node.next = this.head;
            this.head = new_node;
            Console.WriteLine("inserted into front" + new_node);
        }


       
        //public Node InsertAtParticularPosition(int position, int data)  //add data in between
        //{
        //    if (position < 1)
        //        Console.WriteLine("Invalid position");
        //    if (position == 1)
        //    {
        //        var newNode = new Node(data);
        //        newNode.next = this.head;
        //        head = newNode;
        //    }
        //    else
        //    {
        //        while (position-- != 0)
        //        {
        //            if (position == 1)
        //            {
        //                Node node = new Node(data);
        //                node.next = this.head.next;
        //                head.next = node;
        //                break;
        //            }
        //            head = head.next;
        //        }
        //        if (position != 1)
        //            Console.WriteLine("Position out of range");
        //    }
        //    return head;
        //}


        public Node DeleteFirstNode()   //delete first node
        {
            if(this.head==null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }

        public Node DeleteLastNode()    //delete last node
        {
            Node newNode = this.head;
            if(this.head == null)
            {
                return null;
            }
            if(this.head.next  == null)
            {
                this.head = null;
                return null;
            }
            while(newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return newNode;
        }

        public bool Search(int input)
        {
            bool flag = false;
            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == input)
                    {
                        Console.WriteLine("The element is present");
                        flag = true;
                        break;
                    }
                    temp = temp.next;
                }
                if (!flag)
                    Console.WriteLine("The Element is Absent");
            }
            return flag;
        }

        public bool InsertAfter(int data, int after)    //insert in between the sequences
        {
            bool flag = false;
            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == after)
                    {
                        Node newNode = new Node(data);
                        newNode.next = temp.next;
                        temp.next = newNode;
                        flag = true;
                        break;
                    }
                    temp = temp.next;
                }
                if (!flag)
                    Console.WriteLine("The Element is Absent");
            }
            return flag;
        }

        public bool DeleteAny(int data)     //delete data
        {
            bool flag = false;
            int count = 0;

            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                Node previousNode = null;
                while (temp != null)
                {
                    count++;
                    if (temp.data == data)
                    {
                        if (count == 1)
                        {
                            head = temp.next;
                        }
                        else
                        {
                            previousNode.next = temp.next;
                        }
                        flag = true;
                        break;
                    }
                    previousNode = temp;
                    temp = temp.next;
                }
                if (!flag)
                    Console.WriteLine("The Element is Absent");
            }

            return flag;
        }

        public int Size()   //specify size
        {
            int count = 0;

            Node temp = head;
            while (temp != null)
            {
                temp = temp.next;
                count++;
            }

            return count;
        }

    


        public void Display()  //display data after changes made
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            else
            {
                while (temp.next != null)
                {
                    Console.Write(temp.data + "->");
                    temp = temp.next;
                }
                Console.WriteLine(temp.data);
            }
        }
    }

}