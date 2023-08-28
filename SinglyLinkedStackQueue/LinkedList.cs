using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListStackQueue
{
    public class LinkedList<T>
    {
        private Node<T> head;
        private int count;

        public LinkedList()
        {
            this.head = null;
            this.count = 0;
        }

        public int Add(T item)
        {
            Node<T> newNode = new Node<T>(item);

            if (head is null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;

                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = newNode;
            }

            count++;
            return count;
        }

        public bool Remove(T item)
        {
            
            if (head == null)
            {
                return false; 
            }

            if (head.data.Equals(item))
            {
                head = head.next; 
                count--;
                return true; 
            }

            Node<T> current = head;

            while (current.next != null  && !current.next.data.Equals(item)) 
            {
                current = current.next;
            }

            if (current.next == null)
            {
                return false;
            }

            current.next = current.next.next;
            count--;

            return true;
        }

        public bool CheckIfItemExist(T item)
        {
            if (head == null)
            {
                return false;
            }

            Node<T> current = head;

            while (current != null)
            {
                if (current.data.Equals(item))
                {
                    return true; 
                }

                current = current.next;
            }

            return false;
        }

        public int Index(T item)
        {
            int index = 0;
            Node<T> current = head;

            while (!(current == null))
            {
                if (current.data.Equals(item))
                {
                    return index;
                }
                index++;
                current = current.next;
            }
            
            if (current == null) 
            {
                return -1;
            }

            return index;
        }
    }

    
}
