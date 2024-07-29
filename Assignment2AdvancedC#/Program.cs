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

            // 1. You are given an ArrayList containing a sequence of elements.
            //try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse.
            //Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
            #region Part2 - Q1
            //ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };

            //Console.WriteLine("Original list");
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //ReverseArrayList(list);

            //Console.WriteLine("\nReversed list");
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            // 2. You are given a list of integers.
            //Your task is to find and return a new list containing only the even numbers from the given list.
            #region Part2 - Q2
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, };

            //List<int> evenNumbers = GetEvenNumbers(numbers);

            //Console.WriteLine("Original list");
            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //Console.WriteLine("\nEven list");
            //foreach(int num in evenNumbers)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            // 3. implement a custom list called FixedSizeList<T> with a predetermined capacity.
            //This list should not allow more elements than its capacity
            //and should provide clear messages if one tries to exceed it or access invalid indices
            //Requirements:
            //    1.Create a generic class named FixedSizeList<T>.
            //    2.Implement a constructor that takes the fixed capacity of the list as a parameter.
            //    3.Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
            //    4.Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.
            #region Part2 - Q3
            //int capacity = 5;
            //FixedSizeList<int> fixedList = new FixedSizeList<int>(capacity);
            //for (int i = 1; i <= capacity; i++)
            //{
            //    fixedList.Add(i);
            //}

            //// fixedList.Add(6); // this will throw exception

            //Console.WriteLine("Elements in the list: ");
            //for (int i = 0; i < fixedList.Count; i++)
            //{
            //    Console.WriteLine(fixedList.Get(i));
            //} 
            #endregion

            //
            // 4.Given a string, find the first non - repeated character in it and return its index.
            //If there is no such character, return -1.Hint you can use dictionary
            #region Part2 - Q4
            //string input = "sswiss";
            //int index = FirstNonRepeatedCharIndex(input);
            //Console.WriteLine(index); // Output should be 2 (character 'w' at index 2)

            //input = "tterr";
            //index = FirstNonRepeatedCharIndex(input);
            //Console.WriteLine(index); // Output should be 2 (character 'e' at index 2)

            //input = "aabbcc";
            //index = FirstNonRepeatedCharIndex(input);
            //Console.WriteLine(index); // Output should be -1 (no non-repeated character)
            #endregion


        }
        static void ReverseArrayList(ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                var temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }

        static List<int> GetEvenNumbers(List<int> nums)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num);
                }
            }
            return evenNumbers;
        }

        static int FirstNonRepeatedCharIndex(string input)
        {
            // Dictionary to store character counts and their first occurrence index
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            Dictionary<char, int> charIndex = new Dictionary<char, int>();

            // Traverse the string and fill the dictionaries
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                    charIndex[c] = i;
                }
            }

            // Find the first non-repeated character
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (charCount[c] == 1)
                {
                    return charIndex[c];
                }
            }

            // If no non-repeated character is found, return -1
            return -1;
        }

    }
}
