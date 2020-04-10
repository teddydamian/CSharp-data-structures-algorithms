using System;

namespace TreeCompare.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public int NumOfFiles { get; set; } = 0;
        public BinaryTree()
        {
            Root = null;
        }        
    }
}
