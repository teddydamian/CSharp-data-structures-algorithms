# Hashtables
Hash table (hash map) is a data structure that implements an associative array abstract data type, a structure that can map keys to values. A hash table uses a hash function to compute an index, also called a hash code, into an array of buckets or slots, from which the desired value can be found. - Wikipedia

## Challenge
Implement a Hashtable with the following methods:

- ***add***: takes in both the key and value. This method should hash the key, and add the key and value pair to the table, handling collisions as needed.
- ***get***: takes in the key and returns the value from the table.
- ***contains***: takes in the key and returns a boolean, indicating if the key exists in the table already.
- ***hash***: takes in an arbitrary key and returns an index in the collection.

## Approach & Efficiency
O(1)
Searching for the element takes same amount of time as searching for the first element of an array, which is a constant time.


## Source
https://en.wikipedia.org/wiki/Hash_table
