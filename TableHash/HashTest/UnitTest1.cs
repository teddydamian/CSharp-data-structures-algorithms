using System;
using TableHash.Classes;
using Xunit;

namespace HashTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to see if you can add a pair of key and Value
        /// </summary>
        [Fact]
        public void CanAddAPairOfKeyValue()
        {
            HashTable hashtable = new HashTable(1);
            hashtable.Add("apple", "pineapple");
            Assert.True(hashtable.Contains("apple"));
        }

        /// <summary>
        /// Test to see if No key exist.
        /// </summary>
        [Fact]
        public void NoKeyExist()
        {
            HashTable hashtable = new HashTable(1);
            hashtable.Add("apple", "pineapple");
            Assert.False(hashtable.Contains("banana"));
        }

        /// <summary>
        /// Test to see if you can add multiple value key pairs
        /// </summary>
        [Fact]
        public void CanAddMultiplePairsOfKeyValues()
        {
            string[] keys = { "A", "B", "C", "D", "E", "F", "G" };
            string[] values = { "pen", "pineapple", "apple", "baby", "shark", "doo", "duu" };

            HashTable hashtable = new HashTable(keys.Length);

            for (int i = 0; i < keys.Length; i++)
            {
                hashtable.Add(keys[i], values[i]);
                Assert.True(hashtable.Contains(keys[i]));
            }
        }

        /// <summary>
        /// Test to see if table can handle collision
        /// </summary>
        [Fact]
        public void HandleCollision()
        {
            HashTable hashtable = new HashTable(1);

            hashtable.Add("banana", "pen");
            hashtable.Add("ananab", "nep");

            Assert.True(hashtable.Contains("banana"));
            Assert.True(hashtable.Contains("ananab"));

            Assert.Equal(0, hashtable.Hash("banana"));
            Assert.Equal(0, hashtable.Hash("ananab"));

        }

        /// <summary>
        /// Test to see if Get Method is working
        /// </summary>
        [Fact]
        public void TestingGetMethod()
        {
            HashTable hashTable = new HashTable(1);
            hashTable.Add("banana", "pen");

            Assert.Equal("pen", hashTable.Get("banana"));
        }


        /// <summary>
        /// Test to see if we can get value from a hashtable that has a size of 1 but with 2 value for collision
        /// </summary>
        [Fact]
        public void GetValueFromABucketWithCollision()
        {
            HashTable hashtable = new HashTable(1);

            hashtable.Add("banana", "pen");
            hashtable.Add("ananab", "nep");

            Assert.True(hashtable.Contains("banana"));
            Assert.True(hashtable.Contains("ananab"));

            Assert.Equal(0, hashtable.Hash("banana"));
            Assert.Equal(0, hashtable.Hash("ananab"));

            Assert.Equal("pen", hashtable.Get("banana"));
            Assert.Equal("nep", hashtable.Get("ananab"));

        }
    }
}
