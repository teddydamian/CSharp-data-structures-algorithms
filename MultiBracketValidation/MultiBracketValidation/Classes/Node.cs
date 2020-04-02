using System;
namespace MultiBracketValidation.Classes
{
    public class Node
    {
        public char Value { get; set; }
        public Node Next { get; set; }
        public Node(char val)
        {
            Value = val;
        }
    }
}
