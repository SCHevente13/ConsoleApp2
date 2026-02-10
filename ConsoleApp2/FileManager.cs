using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class FileManager
    {
        public static List<Pigs> ReadFile(string fileName)
        {
            List<Pigs> lines = new List<Pigs>();
            try
            {
                foreach (string line in File.ReadAllLines(fileName, Encoding.UTF8).Skip(1))
                {
                    string[] temp = line.Split(';');
                    if (temp.Length == 3)
                    {
                        lines.Add(new Pigs(temp[0], temp[1], double.Parse(temp[2]), int.Parse(temp[3])));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return lines;
        }
    }
}
