using System;
namespace TableHash.Classes
{
    public class HashTable
    {
        public int Buckets { get; set; }
        public Node[] Storage { get; set; }

        /// <summary>
        /// HashTable ctor to designate how many buckets in Table
        /// </summary>
        /// <param name="buckets"></param>
        public HashTable(int buckets)
        {
            Buckets = buckets;
            Storage = new Node[Buckets];
        }

        /// <summary>
        /// method takes in a key as a string and returns an int value of the index in the collection
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int Hash (string key)
        {
            long value = 0;
            for (int i = 0; i < key.Length; i++)
            {
                long charVal = (int)key[i];
                value += charVal;
            }

            value *= 599;
            value %= Buckets;

            int hashKey = Convert.ToInt32(value);
            return hashKey;
        }

        /// <summary>
        /// Check the table to see if key exists in the table.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Contains(string key)
        {
            int index = Hash(key);

            // if the storage is empty, return false
            if (Storage[index] == null)
            {
                return false;
            }


            if (Storage[index].Key == key)
            {
                return true;
            }
            else
            {
                // Traverse through the LL
                Node currentNode = Storage[index];

                while (currentNode.Key != key && currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                if (currentNode.Key == key)
                {
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// Takes in the key and returns the value from the table.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string Get(string key)
        {
            if (!Contains(key))
            {
                return null;
            }
            else
            {
                int index = Hash(key);
                if (Storage[index].Key == key)
                {
                    return Storage[index].Value;
                }
                else
                {
                    Node currentNode = Storage[index];

                    while (currentNode.Key != key)
                    {
                        currentNode = currentNode.Next;
                    }
                    return currentNode.Value;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(string key, string value)
        {
            Node node = new Node(key, value);

            int index = Hash(key);

            if (Storage[index] == null)
            {
                Storage[index] = node;
            }
            else
            {
                Node currentNode = Storage[index];

                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = node;
            }
        }
    }
}
