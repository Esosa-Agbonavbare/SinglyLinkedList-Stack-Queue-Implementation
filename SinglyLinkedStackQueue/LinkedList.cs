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

            // Check if the list is empty (head is null)
            if (head is null)
            {
                // If the list is empty, set the new node as the head of the list.
                head = newNode;
            }
            else
            {
                // If the list is not empty, move to find the last node.
                Node<T> current = head;

                while (current.next != null)
                {
                    // Move to the next node in the list.
                    current = current.next;
                }

                current.next = newNode;
            }

            count++;
            return count;
        }

        public bool Remove(T item)
        {
            // checking if list is empty
            if (head == null)
            {
                return false; // Item cannot be removed.
            }

            // Checking if the item to remove is at the head of the list.
            if (head.data.Equals(item))
            {
                head = head.next; //Updates the head to the next node, removing the first node.
                count--;
                return true; // Success
            }

            // If the item is not at the head, we go through the list to find it.
            Node<T> current = head;

            // The loop iterates through the list until it either finds the node containing the item to remove or reaches the end of the list.
            while (current.next != null  && !current.next.data.Equals(item)) 
            {
                current = current.next;
            }

            // If the loop exits because current.next is null, the item was not found in the list, so the method returns false.
            if (current.next == null)
            {
                return false;
            }


            // If found, the next reference of the previous node containing the item is skipped, removing the node from the list.
            current.next = current.next.next;
            count--;

            return true;
        }

        public bool CheckIfItemExist(T item)
        {
            // Check if the list is empty.
            if (head == null)
            {
                return false;
            }

            // The current variable is initialized to head to act as starting point for iterating throught the list.
            Node<T> current = head;

            // The loop continues as long as current is not null. The end of the list is not reached.
            while (current != null)
            {
                // Checks if the data in the current node is equal to the specified item.
                if (current.data.Equals(item))
                {
                    return true; // if found.
                }

                // If the data in the current node is not equal to the item, the loop continues by moving to the next node in the list
                current = current.next;
            }

            return false;
        }

        public int Index(T item)
        {
            int index = 0;
            Node<T> current = head;  // Start from the head of the list.

            while (!(current == null))
            {
                // Check if the data in the current node is equal to the specific item.
                if (current.data.Equals(item))
                {
                    return index; // If the item is found.
                }
                index++;
                current = current.next; // Move to the next node in the list.
            }

            // If the loop exits without finding the item, return -1 to indicate it wasn't found.
            if (current == null) 
            {
                return -1;
            }

            return index;
        }
    }

    
}
