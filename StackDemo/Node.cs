namespace StackDemo
{
    public class Node
    {
        public Node Next { get; set; }
        public char Value { get; set; }
        public Node(char value)
        {
            Value = value;
        }
    }
}