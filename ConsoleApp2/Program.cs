namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pigs> list1 = FileManager.ReadFile("disznok.csv");
            List<Pigs> list2 = FileManager.ReadFile("disznok2.csv");
            Pigs oldest1 = list1[0];
            foreach (Pigs pig in list1)
            {
                if (oldest1.Age < pig.Age)
                {
                    oldest1 = pig;
                }
            }
            Console.WriteLine("Oldest pig: " + oldest1);
            Pigs heaviest1 = list1[0];
            foreach (Pigs pig in list1)
            {
                if (heaviest1.Weight < pig.Weight)
                {
                    heaviest1 = pig;
                }
            }
            Console.WriteLine("Heaviest pig: " + heaviest1);
            Console.WriteLine("Male pigs:");
            foreach (Pigs pig in list1)
            {
                if (pig.Gender == "kan")
                {
                    Console.WriteLine("- " + pig);
                }
            }
            /*
            Pigs longestN1 = list1[0];
            foreach (Pigs pig in list1)
            {
                if (longestN1.Name < longestN1.Name)
                {
                    longestN1 = pig;
                }
            }
            Console.WriteLine("Oldest pig: " + longestN1);
            */
            int totalF1 = 0;
            foreach (Pigs pig in list1)
            {
                if (pig.Gender == "koca")
                {
                    totalF1++;
                }
            }
            Console.WriteLine("Total female: " + totalF1);
            double totalMW1 = 0;
            foreach (Pigs pig in list1)
            {
                if (pig.Gender == "kan")
                {
                    totalMW1 += pig.Weight;
                }
            }
            Console.WriteLine("Average Weight of Males: " + totalMW1 / list1.Count);
            double totalMA1 = 0;
            foreach (Pigs pig in list1)
            {
                if (pig.Gender == "kan")
                {
                    totalMA1 += pig.Age;
                }
            }
            Console.WriteLine("Average Weight of Males: " + totalMA1 / list1.Count);
            /*
            Insert feladat here
            */
            double total2W1 = 0;
            foreach (Pigs pig in list1)
            {
                if (pig.Age >= 2)
                {
                    total2W1 += pig.Weight;
                }
            }
            Console.WriteLine("Average Weight of Males: " + total2W1 / list1.Count);
            Console.WriteLine("Higher than average weight pigs:");
            foreach (Pigs pig in list1)
            {
                if (pig.Weight > total2W1 / list1.Count)
                {
                    Console.WriteLine("- " + pig);
                }
            }
            int totalM1 = 0;
            foreach (Pigs pig in list1)
            {
                if (pig.Gender == "kan")
                {
                    totalM1++;
                }
            }
            Console.WriteLine("Total male: " + totalM1);
            Console.WriteLine("Total female (again): " + totalF1);
            double totalFW1 = 0;
            foreach (Pigs pig in list1)
            {
                if (pig.Gender == "koca")
                {
                    totalFW1 += pig.Weight;
                }
            }
            Console.WriteLine("Average Weight of...");
            Console.WriteLine("- Females: " + totalFW1 / list1.Count);
            Console.WriteLine("- Males:   " + totalMW1 / list1.Count);
            if (totalFW1 / list1.Count > totalMW1 / list1.Count)
            {
                Console.WriteLine("Females are heavier on average");
            }
            else
            {
                Console.WriteLine("Males are heavier on average");
            }

        }
    }
}
