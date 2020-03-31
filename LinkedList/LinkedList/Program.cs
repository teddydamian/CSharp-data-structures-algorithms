using System;
using LinkedList.Classes;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static Linklist InstantiateLL1()
        {
            Linklist LL1 = new Linklist();

            LL1.Insert(1004);
            LL1.Insert(1003);
            LL1.Insert(1002);
            LL1.Insert(1001);

            return LL1;

        }

        public static Linklist InstantiateLL2()
        {

            Linklist LL2 = new Linklist();

            
            LL2.Insert(2003);
            LL2.Insert(2002);
            LL2.Insert(2001);

            return LL2;
        }

        
        
    }
}
