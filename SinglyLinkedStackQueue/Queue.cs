using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListStackQueue
{
    public class Queue<T>
    {
        private Node<T> head; // Points to the front of the queue
        private Node<T> tail; // Points to the back of the queue
        private int size; // Keeps track of the number of elements in the queue.

        public Queue() 
        {
            this.head = default;
            this.tail = default;
            this.size = 0;
        }

        // Checking if the queue is empty
        public bool IsEmpty()
        {
            //  If head is null, it means the queue is empty.
            return head == null;
        }

        // Adding an item to the back of the queue
        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);

            // If the queue is empty, both head and tail are set to the new node.
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else // tail.next is updated to the new node and tail is moved to the new node.
            {
                tail.next = newNode;
                tail = newNode;
            }

            size++;
        }

        // Removing the item at the front of the queue
        public T Dequeue()
        {
            // Checking if the queue is empty
            if (head == null)
            {
                throw new Exception("Queue is empty");
            }

            T item = head.data; // Retrieving data from the head node

            head = head.next; // Moves the head to the next node

            size--;

            return item;
        }

        // Returns the current size of the queue
        public int Size()
        {
            return size;
        }
    }
}
