using System.Collections.Generic;

namespace ArraysListsDemoCSharp_45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            //Arrays have a set size that you define at creation and that size cannot change
            var numbers = new int[] {12, 50, 40, 12, 5};

            //var numbersToList = numbers.ToList();

            //var numbersToArray = numbersToList.ToArray();

            //numbers[1] = 300;

            //foreach(var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Arrays have a property called "Length" that shows you the number things in the array
            //Console.WriteLine(numbers.Length - 1);

            var names = new string[] {"Seth", "Mack", "Cruz"};


            Console.WriteLine(names.Length);


            for(int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }

            //Lists
            //Lists have a size that can change all you want
            var listNumbers = new List<int>() { 2, 50, 244, 2 };

            listNumbers.Add(1000);
            listNumbers.Remove(listNumbers[0]);

            foreach(var number in listNumbers) 
            {
                Console.WriteLine(number);
            }

            //Lists have a property called Count that gets number of things in the list
            Console.WriteLine(listNumbers.Count);

            var ourClass = new List<string>() { "Alex", "Bryan", "Greg", "Jayson", "Mack", "Muzammel", "Richard", "William", "Seth"};

            Console.WriteLine(ourClass.Count);

            ourClass.Remove("Seth");

            for(int i = 0; i < ourClass.Count; i++)
            {
                Console.WriteLine(ourClass[i]);
            }
        }
    }
}
