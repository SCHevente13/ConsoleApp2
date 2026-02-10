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
            List<Pigs> lines = new();
            try
            {
                foreach (string line in File.ReadAllLines(fileName, Encoding.UTF8).Skip(1))
                {
                    lines.Add(new Pigs(line.Replace('.', ',').Split(';')));
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
