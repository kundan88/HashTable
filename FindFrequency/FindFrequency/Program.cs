using System;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table");
            HashTable<string, int> hashtable = new HashTable<string, int>(5);
            string sentence = "To be or not to be";
            string[] words = sentence.ToLower().Split(' ');
            foreach (string word in words)
            {
                int value = hashtable.Get(word);
                if (value == default)
                {
                    value = 1;
                    hashtable.Add(word, value);
                }
                else
                {
                    value += 1;
                    hashtable.Add(word, value);
                }
            }
            int frequencyTo = hashtable.Get("to");
            int frequencybe = hashtable.Get("be");
            int frequencyor = hashtable.Get("or");
            int frequencyNot = hashtable.Get("not");
            int frequencyto = hashtable.Get("to");
            int frequencyBe = hashtable.Get("be");
            Console.WriteLine("Freq of to :" + frequencyTo);
            Console.WriteLine("Freq of not :" + frequencyNot);
            Console.WriteLine("Freq of or :" + frequencyor);
            Console.WriteLine("Freq of be :" + frequencyBe);
           
        }
    }
}

