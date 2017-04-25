using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Exercise #1 - Remove Duplicates From String List");
            Console.WriteLine("------------------------------------------------");
            List<string> people = new List<string> { "Jason", "Mike", "Pat", "Jim", "Michelle", "Bob", "Michael", "Mike", "Mindy", "Sam", "Samantha", "Michelle", "Lucas", "Carter", "Brook", "Lucas", "Jason" };

            Console.WriteLine("Initial List:");
            foreach (var person in people)
                Console.Write(person + ", ");

            List<string> nonDuplicatePeopole = RemoveDuplicateStrings(people);

            Console.WriteLine("Duplicate Free List:");
            foreach(var person in nonDuplicatePeopole)
                Console.Write(person + ", ");
            Console.WriteLine("");
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("Exercise #2 - Class Grade Average, Drop Low Score");
            Console.WriteLine("------------------------------------------------");
            List<string> scores = new List<string> { "90,100,82,89,55", "95,91,20,89,55", "95,91,100,72,100", "70,99,72,69,49", "90,100,82,89,55,80,77" };
            Console.WriteLine("Grade1: 90,100,82,89,55 ---- Average with Drop = 90.25");
            Console.WriteLine("Grade2: 95,91,20,89,55 ---- Average with Drop = 82.50");
            Console.WriteLine("Grade3: 95,91,100,72,100 ---- Average with Drop = 96.50");
            Console.WriteLine("Grade4: 70,99,72,69,49 ---- Average with Drop = 77.50");
            Console.WriteLine("Grade5: 90,100,82,89,55,80,77 ---- Average with Drop = 86.33");
            Console.WriteLine("Expected Total Grade Average = 86.616");

            Console.WriteLine($"Average From Function: {AverageClassScores(scores)}");

            Console.WriteLine("");
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("Exercise #3 - Alphabetical order with frequency ");
            Console.WriteLine("------------------------------------------------");
            string letters = "Llewellyn";
            Console.WriteLine("starting string: Llewellyn");
            Console.WriteLine("Expected: E2L4N1W1Y1");
            Console.WriteLine($"Actual:   {AlphabetizeAndFindFrequency(letters)}");

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Exercise #4 - Does a list contain substring TH  ");
            Console.WriteLine("------------------------------------------------");
            List<string> morePeople = new List<string> { "Jason", "Theresa", "Pat", "Mike", "Mindy", "Sam", "Samantha", "Michelle", "Lucas", "Jason" };

            Console.WriteLine("1st List:");
            foreach (var person in morePeople)
                Console.Write(person + ", ");

            if (ListContainsTH(morePeople))
                Console.WriteLine("\nYES, this list contains a TH");
            else
                Console.WriteLine("\nNo, this list doesn't contain a TH");

            List<string> otherPeople = new List<string> { "Jason", "Pat", "Mike", "Mindy", "Sam", "Michelle", "Lucas"};

            Console.WriteLine("2nd List:");
            foreach (var person in otherPeople)
                Console.Write(person + ", ");

            if (ListContainsTH(otherPeople))
                Console.WriteLine("\nYES, this list contains a TH");
            else
                Console.WriteLine("\nNo, this list doesn't contain a TH");


            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Exercise #5 - Products out of stock            ");
            Console.WriteLine("------------------------------------------------");
            Inventory basketballs = new Inventory("Basketballs", 20, 20);
            Inventory Golfballs = new Inventory("golfballs", 1000, 999);
            Inventory volleyballs = new Inventory("volleyballs", 100, 100);
            Inventory softballs = new Inventory("softballs", 50, 10);
            Inventory hardballs = new Inventory("hardballs", 50, 49);
            List<Inventory> myInventory = new List<Inventory>() { basketballs, Golfballs, volleyballs, softballs, hardballs};

            Console.WriteLine("Expected Results:  golfballs, softballs, hardballs,");

            List<string> orderProducts = CheckInventory(myInventory);

            Console.Write("Products to Order: ");
            foreach (var product in orderProducts)
                Console.Write(product + ", ");
            Console.WriteLine("");


            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Exercise #6 - Array of numbers contains all odds?");
            Console.WriteLine("------------------------------------------------");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] evens = { 2, 4, 6, 8, 10 };
            int[] odds = { 1, 3, 5, 7, 9, 11 };

            Console.WriteLine("Expected Results:  1-10 (NO), Even (NO), Odd(YES)");

            if(CheckForAllOdds(numbers))
                Console.WriteLine($"YES...numbers contains all odds");
            else
                Console.WriteLine($"NO...numbers do not contain all odds");

            if (CheckForAllOdds(evens))
                Console.WriteLine($"YES...evens contains all odds");
            else
                Console.WriteLine($"NO...evens do not contain all odds");

            if (CheckForAllOdds(odds))
                Console.WriteLine($"YES...odds contain all odds");
            else
                Console.WriteLine($"NO...odds do not contain all odds");


            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Exercise #7 - Products fully stocked           ");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Expected Results:  basketballs, volleyballs");

            List<string> stockedProducts = CheckStockedInventory(myInventory);

            Console.Write("Products fully stocked: ");
            foreach (var product in stockedProducts)
                Console.Write(product + ", ");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Exercise #8 - Sort a result set on two columns  ");
            Console.WriteLine("------------------------------------------------");
            Inventory shorts = new Inventory("shorts", 20, 20);
            Inventory pants = new Inventory("pants", 1000, 999);
            Inventory tshirts = new Inventory("tshirts", 100, 100);
            Inventory sweaters = new Inventory("sweaters", 50, 10);
            Inventory suits = new Inventory("suits", 50, 49);
            Inventory jackets = new Inventory("jackets", 44, 44);
            Inventory shoes = new Inventory("shoes", 1000, 999);
            Inventory tanktops = new Inventory("tanktops", 77, 49);
            Inventory socks = new Inventory("socks", 25, 10);
            Inventory sandles = new Inventory("sandles", 60, 49);
            List<Inventory> clothsStore = new List<Inventory>() { shorts, pants, tshirts, sweaters, suits, jackets, shoes, tanktops, socks, sandles };

            List<Inventory> orderedStore = OrderInventoryByNameAndMax(clothsStore);

            Console.Write("Products Ordered: ");
            foreach (var product in orderedStore)
                Console.Write(product.product + ": " + product.maxSupply + ", ");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Exercise #9 - Linq Equivalent of a foreach loop  ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Answer - myStore.Foreach(p => console.write(p.product)");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Exercise #10 - .First vs. .FirstOrDefault      ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Answer - use .First when you know there will be an element in the sequence");
            Console.WriteLine("         use .FirstOrDefault if you check for a first element");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Exercise #11 - List<string> to string with ','  ");
            Console.WriteLine("------------------------------------------------");

            string peopleString = GetStringFromList(morePeople);
            Console.WriteLine($"People as String: {peopleString}");

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Exercise #12 - List<Inventory> to string  ','  ");
            Console.WriteLine("------------------------------------------------");

            string storeString = GetStringFromClass(clothsStore);
            Console.WriteLine($"Inventory Class as String: {storeString}");

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Exercise #13 - Int List and find every multiple of number ");
            Console.WriteLine("------------------------------------------------");
            Random rand = new Random();
            List<int> myints = new List<int>();
            int aNumber = 7;

            for (int i = 0; i < 500; i++)
                myints.Add(rand.Next(0, 500));

            List<int> multiples = GetMultiplesFromList(myints, aNumber);
            Console.WriteLine($"Multiples of {aNumber}");
            foreach(var i in multiples)
               Console.Write(i + ", ");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Exercise #14 - Int List is one divisible by 5? ");
            Console.WriteLine("------------------------------------------------");
            List<int> myintsList = new List<int>();
            int aNum = 5;

            for (int i = 0; i < 10; i++)
                myintsList.Add(rand.Next(0, 500));

            foreach (var i in myintsList)
                Console.Write(i+", ");
            Console.WriteLine("");
            if (CheckMultiplesFromList(myintsList, aNum))
                Console.WriteLine("Yes, there was a multiple of 5");
            else
                Console.WriteLine("No, there was not a multiple of 5");

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Exercise #15 - Get Max Value from List        ");
            Console.WriteLine("------------------------------------------------");

            foreach (var i in myintsList)
                Console.Write(i + ", ");
            Console.WriteLine("");
            int maxValue = GetMaxValueInList(myintsList);
            Console.WriteLine($"Max Value: {maxValue}");

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Exercise #16 - Select after From in Linq          ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Answer - select will determine the return value and ");
            Console.WriteLine("         this is a way to differentiate between SQL");
            Console.WriteLine("------------------------------------------------");
            Console.ReadLine();

        }
        static List<string> RemoveDuplicateStrings(List<string> stringList)
        {
            List<string> nonDupStrings = new List<string>();
            nonDupStrings.AddRange(stringList.AsQueryable().Distinct());
            return nonDupStrings;
        }

        static double AverageClassScores(List<string> studentsScores)
        {
            List<int> studentScores = new List<int>();
            double classAverage = 0;
            int numberInClass = 0;
            foreach (var student in studentsScores)
            {
                studentScores = student.Split(',')
                                    .Select(m => { return (int.Parse(m)); })
                                    .ToList();
                var studentAvg = studentScores.Where(x => x != studentScores.Min()).Average();
                classAverage += studentAvg;
                numberInClass += 1;
            }
           return classAverage/numberInClass;
        }
        static string AlphabetizeAndFindFrequency(string letters)
        {
            string lowerLetters = letters.ToLower();
            var inOrder =
                from letter in lowerLetters
                group letter by letter into aLetter
                orderby aLetter.Key
                select new
                {
                    letter = aLetter.Key.ToString().ToUpper(),
                    count = aLetter.Count().ToString()
                };
            string letterCountOrdered = "";
            foreach (var aLetter in inOrder.ToList())
            {
                letterCountOrdered += aLetter.letter + aLetter.count;
            }
            return letterCountOrdered;
        }
        static bool ListContainsTH(List<string> checkStrings)
        {
            var subList = checkStrings.Where(s => s.ToLower().Contains("th"));
            int countTotal = subList.Count();
            return countTotal > 0 ;
        }
        static List<string> CheckInventory(List<Inventory> myInventory)
        {
            List<string> productsToOrder = new List<string>();
            productsToOrder.AddRange(myInventory.Where(p => p.actualSupply < p.maxSupply).Select(x=>x.product));
            return productsToOrder;
        }

        static bool CheckForAllOdds(int[] numbers)
        {
            var subList = numbers.Where(n => n % 2 == 0);
            return !(subList.Count() > 0);
        }
        static List<string> CheckStockedInventory(List<Inventory> myInventory)
        {
            List<string> productsToOrder = new List<string>();
            productsToOrder.AddRange(myInventory.Where(p => p.actualSupply == p.maxSupply).Select(x => x.product));
            return productsToOrder;
        }

        static List<Inventory> OrderInventoryByNameAndMax(List<Inventory> myStore)
        {
            List<Inventory> OrderedList = new List<Inventory>();
            OrderedList.AddRange(myStore.OrderBy(p => p.product).ThenBy(p => p.maxSupply));
            return OrderedList;
        }
        static string GetStringFromList(List<string> aList)
        {
            var myList = String.Join(", ", aList.ToArray());
            return myList;
        }
        static string GetStringFromClass(List<Inventory> myStore)
        {
            string myList = "";
            myList = String.Join(", ", myStore.Select(p => $"{p.product}:Max-{p.maxSupply}:Actual-{p.actualSupply}".ToString()));
            return myList;
        }
        static List<int> GetMultiplesFromList(List<int> aList, int aMultiple)
        {
            List<int> multipleList = new List<int>();
            multipleList.AddRange(aList.Where(i => i % aMultiple == 0));
            return multipleList;
        }
        static bool CheckMultiplesFromList(List<int> aList, int aMultiple)
        {
            var subList = aList.Where(i => i % aMultiple == 0);
            return subList.Count() > 0;
        }
        static int GetMaxValueInList(List<int> aList)
        {
            return aList.Max();

        }
    }
}
