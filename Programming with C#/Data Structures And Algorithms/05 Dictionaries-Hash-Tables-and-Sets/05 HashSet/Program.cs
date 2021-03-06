﻿// Implement the data structure "set" in a class HashedSet<T> using your class HashTable<K,T> to hold the elements.
// Implement all standard set operations like Add(T), Find(T), Remove(T), Count, Clear(), union and intersect.

namespace _05_HashSet
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var set = new HashedSet<int>(new[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("Set: {0}", set);

            set.Add(6);
            Console.WriteLine("Add '6' -> {0}", set);

            set.Add(6);
            Console.WriteLine("Add '6' -> {0}", set);

            Console.WriteLine("Find '0': {0}", set.Find(0));
            Console.WriteLine("Find '6': {0}", set.Find(6));

            set.Remove(3);
            Console.WriteLine("Remove '3' -> {0}", set);

            Console.WriteLine("Number of elements: {0}", set.Count);

            var collection = new[] { 3, 7 };
            set.Union(collection);
            Console.WriteLine("Union with [{0}] -> {1}", string.Join(", ", collection), set);

            collection = new[] { 5, 6, 7, 8, 9 };
            set.Intersect(collection);
            Console.WriteLine("Intersection with [{0}] -> {1}", string.Join(", ", collection), set);

            set.Clear();
            Console.WriteLine("Clear set...");
            Console.WriteLine("Number of elements: {0}", set.Count);
        }
    }
}
