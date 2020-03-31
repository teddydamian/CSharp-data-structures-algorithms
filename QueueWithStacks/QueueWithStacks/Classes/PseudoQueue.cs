using System;


namespace QueueWithStacks.Classes
{
    public class PseudoQueue
    {
        //Instantiate 2 stacks
        Stack one = new Stack();
        Stack two = new Stack();
        public Node Current { get; set; }

        public Stack Enqueue(int value)
        {
            one.Push(value);
            return one;
        }
    }
}
