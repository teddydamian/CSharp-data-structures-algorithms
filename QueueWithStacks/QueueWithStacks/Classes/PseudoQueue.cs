using System;


namespace QueueWithStacks.Classes
{
    public class PseudoQueue
    {
        public Stack One = new Stack();
        public Stack Two = new Stack();
        public int Size { get; set; } = 0;

        /// <summary>
        /// Enqueue method will pop everything in stack 1, push it to stack 2, push a new value into stack 1, and pop all from stack 2, then push to stack 1.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>string of the new first stack</returns>
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

        /// <summary>
        /// Dequeue will remove the top of the stack.
        /// </summary>
        /// <returns>string of the stack after top is removed</returns>
        public string Dequeue()
        {
            
            if(One.Size == 0)
            {
                return "Stack is empty";
                
            }
            else
            {
                One.Pop();
                string pop = One.ToString();
                return pop;
            }
         
        }
    }
}
