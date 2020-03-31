using System;


namespace QueueWithStacks.Classes
{
    public class PseudoQueue
    {
        public Stack One = new Stack();
        public Stack Two = new Stack();
        public int Size { get; set; } = 0;


        public string Enqueue(int value)
        {
            
            while(One.Size > 0)
            {
                Two.Push(One.Pop());
            }
            One.Push(value);
            while(Two.Size > 0)
            {
                One.Push(Two.Pop());
            }
            Size++;

            string x = One.ToString();
            return x;
        }
    }
}
