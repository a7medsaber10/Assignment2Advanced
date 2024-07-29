using System.Collections.Generic;
using System.Collections;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using Assignment2AdvancedC_.Classes;
using System.Runtime.Intrinsics.X86;
using System;

namespace Assignment2AdvancedC_
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1 - Collections Report
            // Collections in computer science are data structures that store and manage groups of objcets
            // They offer various way to access, insert, update and delete elements.

            #region 1.ArrayList
            // 1. ArrayList
            //  - Dynamic array size
            //  - Internally maintains an array, doubling its size when the array is full.

            // Time complexity => Access: O(1)

            // ArrayLists are ideal for scenarios where:
            // ------------------------------------------
            // You need fast random access to elements.
            // Insertions and deletions are infrequent.
            // Example: Storing a list of student names where quick access is needed.
            //ArrayList students = new ArrayList() { "John", "Jane", "Jack" };
            //Console.WriteLine(students[1]);// Outputs "Jane" 
            #endregion

            #region 2.List
            // 2. List
            // - Generic dynamic array
            // - Used when you need an ordered collection but want to be flexible with the underlying implementation.

            // Time complexity => Access: O(1)

            // Lists are ideal for senareos where:
            // -------------------------------------
            // Type-safe collections with generic support.
            // Example: Maintaining a list of employee objects.
            //List<string> list = new List<string>();
            //list.Add("John");
            //list.Add("Jane");
            //list.Add("Jack");
            //Console.WriteLine(list[1]); // Outputs "Jane" 
            #endregion

            #region 3.LinkedList
            // 3. LinkedList
            // - LinkedList<T> is a generic collection of objects where each element is a node.
            // - Nodes are linked, and the list can be traversed forwards and backwards.

            // Time Complexity => Access: O(n)

            // Business Case => Use when you need efficient insertions and deletions at both ends of the list.
            //LinkedList<string> linkedList = new LinkedList<string>();
            //linkedList.AddLast("John");
            //linkedList.AddLast("Jane");
            //linkedList.AddLast("Jack");
            //Console.WriteLine(linkedList.First.Next.Value); // Outputs "Jane"
            #endregion

            #region 4.Stack
            // 4.Stack
            // Stack<T> is a generic collection that follows the Last-In-First-Out (LIFO) principle.

            // Time Complexity => Access: O(n)

            // Business case => Use when you need LIFO access to elements.
            //Stack<string> stack = new Stack<string>();
            //stack.Push("John");
            //stack.Push("Jane");
            //stack.Push("Jack");
            //Console.WriteLine(stack.Pop()); // Outputs "Jack"
            #endregion

            #region 5.Queue
            // 5.Queue
            // Queue<T> is a generic collection that follows the First-In-First-Out (FIFO) principle.

            // Time Complexity => Access: O(n)

            // Business case => Use when you need FIFO access to elements.
            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("John");
            //queue.Enqueue("Jane");
            //queue.Enqueue("Jack");
            //Console.WriteLine(queue.Dequeue()); // Outputs "John"
            #endregion

            #region 6.HashTable
            // 6.HashTable
            // Hashtable is a non-generic collection that stores key-value pairs.
            // It uses a hash code to look up the keys.

            // Time Complexity => Access: O(1) average, O(n) worst case

            // Business case => Use when you need to look up values by keys and type safety is not a concern.

            //Hashtable hashtable = new Hashtable();
            //hashtable["John"] = "Doe";
            //hashtable["Jane"] = "Smith";
            //Console.WriteLine(hashtable["Jane"]); // Outputs "Smith"
            #endregion

            #region 7.Dictionary
            // 7.Dictionary
            // Dictionary<TKey, TValue> is a generic collection that stores key-value pairs.
            // It uses a hash code to look up the keys.

            // Time Complexity => O(1) average, O(n) worst case

            // Business case => Use when you need to look up values by keys with type safety.
            //Dictionary<string, string> dictionary = new Dictionary<string, string>();
            //dictionary["John"] = "Doe";
            //dictionary["Jane"] = "Smith";
            //Console.WriteLine(dictionary["Jane"]); // Outputs "Smith"
            #endregion

            #region 8.HashSet
            // 8.HashSet
            // HashSet<T> is a generic collection that contains unique elements.
            // It uses a hash code for the elements.

            // Time Complexity => O(1) average, O(n) worst case

            // Business case => Use when you need a collection of unique elements.
            //HashSet<string> hashSet = new HashSet<string>();
            //hashSet.Add("John");
            //hashSet.Add("Jane");
            //hashSet.Add("Jack");
            //Console.WriteLine(hashSet.Contains("Jane")); // Outputs "True"
            #endregion

            #endregion

        }


    }
}
