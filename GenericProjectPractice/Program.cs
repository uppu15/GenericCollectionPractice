using System;
using System.Collections;

namespace GenericCollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public static void PopulateAll()
        {
            Collection.PrintQueue(Collection.FillQueue());
            Collection.PrintStack(Collection.FillStack());
            Collection.PrintList(Collection.GenerateList());
            Collection.PrintLinkedList(Collection.MakingLinkedList());
            Collection.PrintSortedList(Collection.MakeSortedList());
            Collection.PrintDictionary(Collection.MakeDictionary());
            Collection.PrintHash(Collection.PopulatingHashTables());
        }
    }
}
