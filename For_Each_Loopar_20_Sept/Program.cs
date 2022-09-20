using System.Collections.Generic;

namespace For_Each_Loopar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintList(new List<string>{"Batman","Robin","Batgirl","Alfred","Ace","Oracle","Huntress"});
            //PrintArray(new string[]{"Batman","Robin","Batgirl","Alfred","Ace","Oracle","Huntress"});
            //var alias = new Dictionary<string, string>();
            //alias.Add("Bruce Wayne", "Batman");
            //alias.Add("Clark Kent", "Superman");
            //alias.Add("Peter Quill", "Star-Lord");
            //alias.Add("Groot", "Groot");
            //PrintDictionary(alias);
            //AllDoctors();
            SummanAvArrayen();
        }

        static void PrintList(List<string> namesList)
        {
            Console.WriteLine("Övning 1");
            Console.WriteLine("+-----------+");
            foreach (var name in namesList)
            {
                Console.WriteLine(name);
            }
        }

        static void PrintArray(string[] namesList)
        {
            Console.WriteLine("Övning 2");
            Console.WriteLine("+-----------+");
            foreach (var name in namesList)
            {
                Console.WriteLine(name);
            }
        }

        static void PrintDictionary(Dictionary<string, string> aliasList)
        {
            Console.WriteLine("Övning 3");
            Console.WriteLine("+-----------+");
            foreach (var name in aliasList)
            {
                Console.WriteLine($"{name.Key} is {name.Value}");
            }

        }

        static void AllDoctors()
        {
            string[] doctors = new string[]
            {
                " 1 - William Hartnell"," 2 - Patrick Troughton"," 3 - Jon Pertwee",
                " 4 - Tom Baker"," 5 - Peter Davidsson", " 6 - Colin Baker",
                " 7 - Sylvester McCoy", " 8 - Paul McGann", " 9 - Christopher Eccleston",
                " 10 - David Tennant", " 11 - Matt Smith", "War - John Hurt",
                " 12 - Peter Capaldi", " 13 - Jodie Whittaker"," 0 - Jo Martin",
                " 14 - Ncuti Gatwa"
            };

            foreach (var name in doctors)
            {
                Console.WriteLine(name);
            }
        }


        //static void SummanAvArrayen()
        //{
        //    int[] numbers = { 1, 2, 4, 45, 2, 23, 324, 23, 2 };
        //    int totSumma = 0;
        //    foreach (int number in numbers)
        //    {
        //        totSumma += number;
        //    }
        //    Console.WriteLine($"Summan är {totSumma}");
        //}

        static void SummanAvArrayen()
        {
            int[] numbers = { 1, 2, 4, 45, 2, 23, 324, 23, 2 };
            int totSumma = 0;
            foreach (int number in numbers)
            {
                totSumma = numbers.Sum();
            }
            Console.WriteLine($"Summan är {totSumma}");
        }



    }



}