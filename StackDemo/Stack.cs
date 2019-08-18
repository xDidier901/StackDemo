using System;

namespace StackDemo
{
    // Last In, Last Out (LIFO).
    // O - Top (First to be out).
    // O
    // O
    // O
    // O (Last to be out).
    public static class Stack
    {
        private static Node _top;

        // Checks if the stack is empty
        public static bool IsEmpty()
        {
            return _top == null;
        }

        // Prints the next node to be out (the top one).
        public static void PrintPeek()
        {
            if (_top == null)
            {
                Console.WriteLine("The stack is empty.");
            }
            Console.WriteLine($"Peek: The top is { _top.Value }");
        }

        // Pushes a new node to the stack.
        public static void Push(char value)
        {
            // We create the new node.
            var newNode = new Node(value);

            // If the stack is not empty, we update the top pointer.
            if (_top != null)
            {
                newNode.Next = _top;
            }

            // We set the new node as the top.
            _top = newNode;
        }

        // Deletes the top node of the stack.
        public static char Pop()
        {
            // If the stack is empty return an empty char.
            if (_top == null)
            {
                return char.MinValue;
            }

            // We get the value to remove.
            var nodeValue = _top.Value;

            _top = _top.Next;
            return nodeValue;
        }

        // Prints the current state of the stack.
        public static void PrintStack()
        {
            // We check if the stack is empty.
            if (_top == null)
            {
                System.Console.WriteLine("The stack is empty.");
                return;
            }

            var currentNode = _top;
            while (currentNode != null)
            {
                System.Console.Write($" <= { currentNode.Value }");
                currentNode = currentNode.Next;
            }
            System.Console.Write(" (Top)");
            System.Console.WriteLine();
        }




    }
}