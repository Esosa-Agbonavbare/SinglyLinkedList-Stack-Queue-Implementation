using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListStackQueue
{
    public class Stack<T>
    {
        private Node<T> top; // Represents the most recently added element
        private int size; 

        public Stack() 
        {
            this.top = default;
            this.size = 0;
        }

        // Checking if the stack is empty
        public bool IsEmpty() 
        {
            return top == null;
        }

        // Adding an item to the top of the stack.
        public void Push(T item)
        {
            Node<T> newNode = new Node<T>(item);

            // Checking if stack is empty
            if (top == null)
            {
                top = newNode; 
            }
            else // the newNode.next is updated to point to the current top node and top is moved to the new node.
            {
                newNode.next = top;
                top = newNode;
            }

            size++;
        }

        // Removing the item from the top of the stack
        public T Pop() 
        {
            // Checking if the stack is empty
            if (top == null)
            {
                throw new Exception("Stack is Empty");
            }

            T item = top.data;

            top = top.next;

            size--;

            return item;
        }

        // Returning the item at the top of the stack
        public T Peek()
        {
            if (top == null)
            {
                throw new Exception("Stack is empty");
            }

            return top.data;
        }

        public int Size() 
        {
            return size;
        }
    }
}
