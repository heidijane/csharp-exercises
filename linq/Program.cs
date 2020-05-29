﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = fruits.Where(fruit => fruit.StartsWith("L"));

            Console.WriteLine("Get foods that start with the letter 'L'");
            Console.WriteLine("---------------------");
            LFruits.ToList().ForEach(LFruit => Console.WriteLine(LFruit));

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where(num => num % 4 == 0 || num % 6 == 0);

            Console.WriteLine();
            Console.WriteLine("Get numbers that are multiples of 4 or 6");
            Console.WriteLine("---------------------");
            fourSixMultiples.ToList().ForEach(num => Console.WriteLine(num));

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather",
                "James",
                "Xavier",
                "Michelle",
                "Brian",
                "Nina",
                "Kathleen",
                "Sophia",
                "Amir",
                "Douglas",
                "Zarley",
                "Beatrice",
                "Theodora",
                "William",
                "Svetlana",
                "Charisse",
                "Yolanda",
                "Gregorio",
                "Jean-Paul",
                "Evangelina",
                "Viktor",
                "Jacqueline",
                "Francisco",
                "Tre"
            };

            IEnumerable<string> descendingNames = names.OrderByDescending(name => name);

            Console.WriteLine();
            Console.WriteLine("Get names in descending order");
            Console.WriteLine("---------------------");
            descendingNames.ToList().ForEach(name => Console.WriteLine(name));

            // Build a collection of these numbers sorted in ascending order
            List<int> sortNumbers = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            Console.WriteLine();
            Console.WriteLine("Sort numbers in ascending order");
            Console.WriteLine("---------------------");
            IEnumerable<int> ascendingNumbers = sortNumbers.OrderBy(num => num);

            ascendingNumbers.ToList().ForEach(num => Console.WriteLine(num));

            // Output how many numbers are in this list
            List<int> countNumbers = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            int numberCount = countNumbers.Count;

            Console.WriteLine();
            Console.WriteLine("Count how many numbers are in a list");
            Console.WriteLine("---------------------");
            Console.WriteLine(numberCount);

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29,
                745.31,
                21.76,
                34.03,
                4786.45,
                879.45,
                9442.85,
                2454.63,
                45.65
            };

            double moneyMade = purchases.Sum();

            Console.WriteLine();
            Console.WriteLine("How much money have we made?");
            Console.WriteLine("---------------------");
            Console.WriteLine($"${moneyMade}");

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45,
                9442.85,
                2454.63,
                45.65,
                2340.29,
                34.03,
                4786.45,
                745.31,
                21.76
            };

            IEnumerable<double> sortedPrices = prices.OrderByDescending(num => num);
            double mostExpensive = sortedPrices.FirstOrDefault();

            Console.WriteLine();
            Console.WriteLine("Most expensive product");
            Console.WriteLine("---------------------");
            Console.WriteLine($"${mostExpensive}");

            List<int> wheresSquaredo = new List<int>()
            {
                66,
                12,
                8,
                27,
                82,
                34,
                7,
                50,
                19,
                46,
                81,
                23,
                30,
                4,
                68,
                14
            };
            /*
                Store each number in the following List until a perfect square
                is detected.

                Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */

            IEnumerable<int> numberList = wheresSquaredo.TakeWhile(num => Math.Sqrt(num) % 1 != 0);

            Console.WriteLine();
            Console.WriteLine("Store each number until a perfect square is detected");
            Console.WriteLine("---------------------");
            numberList.ToList().ForEach(num => Console.WriteLine(num));

            /*
            Given the same customer set, display how many millionaires per bank.
            Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

            Example Output:
            WF 2
            BOA 1
            FTB 1
            CITI 1
            */

            List<Customer> customers = new List<Customer>()
            {
                new Customer() { Name = "Bob Lesman", Balance = 80345.66, Bank = "FTB" },
                new Customer() { Name = "Joe Landy", Balance = 9284756.21, Bank = "WF" },
                new Customer() { Name = "Meg Ford", Balance = 487233.01, Bank = "BOA" },
                new Customer() { Name = "Peg Vale", Balance = 7001449.92, Bank = "BOA" },
                new Customer() { Name = "Mike Johnson", Balance = 790872.12, Bank = "WF" },
                new Customer() { Name = "Les Paul", Balance = 8374892.54, Bank = "WF" },
                new Customer() { Name = "Sid Crosby", Balance = 957436.39, Bank = "FTB" },
                new Customer() { Name = "Sarah Ng", Balance = 56562389.85, Bank = "FTB" },
                new Customer() { Name = "Tina Fey", Balance = 1000000.00, Bank = "CITI" },
                new Customer() { Name = "Sid Brown", Balance = 49582.68, Bank = "CITI" }
            };

            List<Bank> bankMills = (from customer in customers group customer by customer.Bank into bankGroup select new Bank
            {
                Name = bankGroup.Key,
                    CurrentMills = bankGroup.Count()
            }).ToList();

            Console.WriteLine();
            Console.WriteLine("Display how many millionaires per bank");
            Console.WriteLine("---------------------");

            foreach (Bank bank in bankMills)
            {
                Console.WriteLine($"{bank.Name}: {bank.CurrentMills}");
            }

        }
    }
}