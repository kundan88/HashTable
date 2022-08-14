namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hash Table");
            LinkedHashMap<string, int> LinkedHashMap = new LinkedHashMap<string, int>(5);

            string Paragraph = "paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] letters = Paragraph.ToLower().Split(" ");
            foreach (string word in letters)
            {
                int value = LinkedHashMap.Get(word);
                if (value == default)
                {
                    value = 1;
                }
                else value += 1;
                LinkedHashMap.Add(word, value);
            }
            int frequency = LinkedHashMap.Get("paranoid");
            Console.WriteLine(frequency);

            LinkedHashMap.Remove("avoidable");
            int pop = LinkedHashMap.Get("avoidable");

            Console.WriteLine(pop);


        }
    }
}
