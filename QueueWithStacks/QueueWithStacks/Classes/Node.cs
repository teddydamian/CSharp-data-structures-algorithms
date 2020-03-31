using System;
namespace QueueWithStacks.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node(int val)
        {
            Value = val;
        }
    }
}
