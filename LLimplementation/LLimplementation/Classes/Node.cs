﻿using System;
namespace LLimplementation.Classes
{
    public class Node
    {

        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}