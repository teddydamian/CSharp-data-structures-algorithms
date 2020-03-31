﻿using System;
using QueueWithStacks.Classes;

namespace QueueWithStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            PseudoQueue pseudo = new PseudoQueue();
    
            pseudo.One.Push(20);
            pseudo.One.Push(30);
            pseudo.One.Push(40);
   
            string result = pseudo.Enqueue(10);
            Console.WriteLine("Enqueue:");
            Console.WriteLine($"{result}");
        }

   
    }
}
