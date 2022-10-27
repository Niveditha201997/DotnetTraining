using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Xml;

namespace LinqHandsOn2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.Most frequent character
            //Write a query that returns most frequent character in string.Assume that there is only one such character.
            //Expected input and output
            //"panda"  → 'a'
            //"n093nfv034nie9"→ 'n'

            string str = "Niveditha";

            var mostFrequentCharacter = str.GroupBy(c => c).OrderByDescending(c => c.Count()).First().Key;

            Console.WriteLine(mostFrequentCharacter);


            //2.Find out Unique values
            //Given a non - empty list of strings, return a list that contains only unique(non - duplicate) strings.
            //Expected input and output
            //["abc", "xyz", "klm", "xyz", "abc", "abc", "rst"] → ["klm", "rst"]

            var results = new List<string>()
           {
               "abc","xyz","klm","xyz","abc","rst",
           };
            var res = results.GroupBy(c => c)
                .Where(c => c.Count() == 1)
               .Select(c => c.Key)
               .ToList();
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }



            //3.Top 5 numbers
            //Write a query that returns top 5 numbers from the list of integers in descending order.
            //Expected input and output
            //[78, -9, 0, 23, 54, 21, 7, 86]  → 86 78 54 23 21

            List<int> numbers = new List<int> { 78, -9, 0, 23, 54, 21, 7, 86 };

            var top5 = numbers.OrderByDescending(x => x).Take(5);

            foreach (var number in top5)
            {
                Console.Write($"{number} ");
            }



            //4.	 Find the words in the collection that start with the letter 'L'

            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            IEnumerable<string> LFruits = from fruit in fruits where fruit[0] == 'L' select fruit;
            IEnumerable<string> LLFruits = fruits.Where(f => f[0] == 'L');

            foreach (string fruit in LFruits)
            {
                Console.WriteLine(fruit);
            }


            //5.   Which of the following numbers are multiples of 4 or 6
            List<int> mixedNumbers = new List<int>()
                        {
                              15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                        };
            List<int> fourSixMultiples = mixedNumbers.Where(n => n % 4 == 0 || n % 6 == 0).ToList();
            foreach (int number in fourSixMultiples)
            {
                Console.WriteLine(number);
            }

            // 6.   Output how many numbers are in this list
             List<int> numbers1 = new List<int>()
                        {
                            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                        };
            Console.WriteLine(numbers1.Count());



            // 7.   How much money have we made?
            List<double> purchases = new List<double>()
                        {
                            2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
                        };
            Console.WriteLine($"{purchases.Sum().ToString("C")}");



            // 8.   What is our most expensive product?
            List<double> prices = new List<double>()
                        {
                            879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
                        };
            Console.WriteLine($"{prices.Max().ToString("C")}");


            // 9.Given the same customer set, display how many millionaires per bank

            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            var groupedByBank = customers.Where(c => c.Balance >= 1000000).GroupBy(
                p => p.Bank,  // Group banks
                p => p.Name,  // by millionaire names
                (bank, millionaires) => new GroupedMillionaires()
                {
                    Bank = bank,
                    Millionaires = millionaires
                }
            ).ToList();

            foreach (var item in groupedByBank)
            {
                Console.WriteLine($"{item.Bank}: {string.Join(" and ", item.Millionaires)}");
            }

            //  10.Display Top 3 customers per bank.

            var topThree = (from Customer in customers
                            orderby Balance descending
                            select customers).Take(3);

            foreach (var x in topThree)
            {
                Console.WriteLine(x);
            }

            //Customer[] result2 = customers.Where(customers.).ToArray();

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item.Balance);
            //    Console.WriteLine(item.Bank);
            //}


        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
        
    }

    

    public class GroupedMillionaires
    {
        public string Bank { get; set; }
        public IEnumerable<string> Millionaires { get; set; }
    }
}
