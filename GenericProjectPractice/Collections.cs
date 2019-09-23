using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionsPractice
{
    public class Collection
    {
        public static Queue<int> FillQueue()
        {
            //Instantiate Queue
            Queue<int> QueInt = new Queue<int>();

            //Filling the queue
            foreach (int number in new int[] { 1, -1, 23, -23, 55 })
            {
                QueInt.Enqueue(number);
            }
            return QueInt;
        }
        public static void PrintQueue(Queue<int> Queue)
        {
            Console.WriteLine("Queue");
            foreach (int x in Queue)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
        }

        public static Stack<int> FillStack()
        {
            //Instantiate Stack
            Stack<int> StackInt = new Stack<int>();

            //Filling the queue
            foreach (int number in new int[] { 1, -1, 23, -23, 55 })
            {
                StackInt.Push(number);
            }
            return StackInt;
        }
        public static void PrintStack(Stack<int> Stack)
        {
            Console.WriteLine("Stack");
            foreach (int x in Stack)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
        }

        public static List<char> GenerateList()
        {
            //Instantiate List
            List<char> ListThis = new List<char>();

            //Filling the queue
            foreach (char chars in "MSSA SD6")
            {
                ListThis.Add(chars);
            }
            return ListThis;
        }

        public static void PrintList(List<char> List)
        {
            Console.WriteLine("List");
            foreach (char x in List)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
        }

        public static LinkedList<int> FillLinkedList()
        {
            //Instantiate Linked list
            LinkedList<int> LLInt = new LinkedList<int>();

            //Filling the linked list
            foreach (int number in new int[] { 1,2,3,4,-1,-5 })
            {
                LLInt.AddFirst(number);
                LLInt.AddLast(number);

            }
            return LLInt;
        }

        public static void PrintLinkedList(LinkedList<int> LinkedList)
        {
            Console.WriteLine("LinkedList");
            foreach (var x in LinkedList)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
        }

        public static Dictionary<string, char> MakeDictionary()
        {
            Dictionary<string, char> DictionaryKeyValue = new Dictionary<string, char>()
            {
                ["Apple"] = 'a',
                ["Banana"] = 'b',
                ["Cheery"] = 'c',
                ["Date"] = 'd',
                ["Floccinaucinihilipilification"] = 'f',
                ["Grape"] = 'g'
            };
            return DictionaryKeyValue;
        }

        public static void PrintDictionary(Dictionary<string, char> DictionaryKeyValue)
        {
            Console.WriteLine("Dictionary");
            foreach (KeyValuePair<string, char> pair in DictionaryKeyValue)
            {
                string index = pair.Key;
                char value = pair.Value;
                Console.WriteLine($"Key is {index} and Value is {value}");
            }
            Console.WriteLine();
        }

        public static SortedList<char, string> MakeSortedList()
        {
            SortedList<char, string> keyValuePair = new SortedList<char, string>()
            {
                {'e', "is" },
                {'g', "for" },
                {'c', "This" },
                {'z', "assignment" },
                {'v', "MSSA" }
            };
            return keyValuePair;
        }
        public static void PrintSortedList(SortedList<char, string> keyValuePairs)
        {
            Console.WriteLine("Sorted list with double key and a string value");
            foreach (KeyValuePair<char, string> element in keyValuePairs)
            {
                char order = element.Key;
                string word = element.Value;
                Console.WriteLine($"Key is {order} and Value is:'{word}'");
            }
            Console.WriteLine();
        }
        public static HashSet<string> PopulatingHashTables()
        {
            HashSet<string> wordsThatStartWithLetterR = new HashSet<string>(new string[]
            {
                "Run", "Reverse", "Repeat", "Rich", "Reaper", "Reach", "Rap"
            });
            HashSet<string> wordsThatContaintLetterE = new HashSet<string>(new string[]
            {
                "Egg", "Reverse", "Repeat", "Elephant", "Reaper", "Reach", "Moneky"
            });

            wordsThatStartWithLetterR.IntersectWith(wordsThatContaintLetterE);
            return wordsThatStartWithLetterR;
        }
        public static void PrintHash(HashSet<string> Hash)
        {
            Console.WriteLine("Hash");
            foreach (string x in Hash)
            {
                Console.WriteLine(x);
            }
        }


    }
}