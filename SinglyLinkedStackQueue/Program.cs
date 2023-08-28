namespace SinglyLinkedListStackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINKED LIST IMPLEMENTATION
            Console.WriteLine("LINKED LIST IMPLEMENTATION: ");
            LinkedList<int> linkedList = new();
            linkedList.Add(19);  // Adds an element to the linked list.
            linkedList.Add (20);  // Adds an element to the linked list.
            Console.WriteLine(linkedList.Add(21)); // Returns the number of elements in the list.
            Console.WriteLine(linkedList.CheckIfItemExist(19));  



            // QUEUE IMPLEMENTATION
            Console.WriteLine("\nQUEUE IMPLEMENTATION: ");
            Queue<int> queue = new Queue<int>();
            //Adding elements to the queue.
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine(queue.Dequeue()); // Retrieves the first element in the queue.
            Console.WriteLine(queue.IsEmpty()); // Checks if the queue is empty.


            // STACK IMPLEMENTATION
            Console.WriteLine("\nSTACK IMPLEMENTATION: ");
            Stack<string> stack = new Stack<string>();
            // Adding elements to the stack
            stack.Push("a"); 
            stack.Push("b");
            stack.Push("c");
            Console.WriteLine(stack.Pop()); // Retrieves the last element added in the array.
            Console.WriteLine(stack.IsEmpty()); // Checks if the stack is empty.
            if (stack.Size() > 0) // Returns the top item in the stack.
            {
                Console.WriteLine(stack.Peek()); // prints b   
            }
        }
    }
}