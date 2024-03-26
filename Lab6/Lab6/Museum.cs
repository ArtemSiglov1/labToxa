using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Museum
    {
        public string Name { get; set; }
        public Museum() { }
        public Museum(string name) { Name=name; }
        public override string ToString()
        {
            return $"{Name}";
        }
        public static Museum Init()
        {
            Console.WriteLine("Input Name");
            string name = Console.ReadLine();
            return new Museum(name);
        }
    }
}
