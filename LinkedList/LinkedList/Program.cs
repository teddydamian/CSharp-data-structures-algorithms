using System;
using LinkedList.Classes;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Linklist LOne = InstantiateLL1();
            Linklist LTwo = InstantiateLL2();
            Linklist newList = MergeLists(LOne, LTwo);
            string list = newList.ToString();
            Console.WriteLine(list);
            
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

        public Linklist MergeList(LinkedList listOne, LinkedList listTwo)
		{
            Node currentOne = listOne.Head;
            Node currentTwo = listTwo.Head;
            Node helpOne;
            Node helpTwo;

            //Handles Even Lists
            while (currentOne.Next != null && currentTwo.Next != null)
            {
                helpOne = currentOne.Next;
                currentOne.Next = currentTwo;
                currentOne = helpOne;

                helpTwo = currentTwo.Next;
                currentTwo.Next = currentOne;
                currentTwo = helpTwo;
            }

            //Handles Uneven Lists
            if (currentTwo.Next == null)
            {
                helpOne = currentOne.Next;
                currentOne.Next = currentTwo;
                currentTwo.Next = helpOne;
            }

            return listOne;
        }
        
    }
}
