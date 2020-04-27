using System;
namespace TableHash.Classes
{
    public class Node
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public Node Next { get; set; }

        /// <summary>
        /// Node will have key and value stored
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public Node(string key, string value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
