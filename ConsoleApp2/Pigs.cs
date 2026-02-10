using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Pigs
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public Pigs(string name, string gender, double weight, int age)
        {
            Name = name;
            Gender = gender;
            Weight = weight;
            Age = age;
        }
        public override string ToString()
        {
            return $"Name: {Name} | Gender: {Gender} | Weight: {Weight} kg | Age: {Age}";
        }
        public string Rename(string newName)
        {
            Name = newName;
            return "New Name: "+ Name;
        }
        public double Feed()
        {
            Weight *= 1.01;
            return Weight;
        }
    }
}
