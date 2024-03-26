using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    /// <summary>
    /// klass transport sredstvo
    /// </summary>
    internal class TC
    {
        public string Name {  get; set; }
        public TC() { }
        public TC(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
        public static TC Init()
        {
            Console.WriteLine("Input Name");
            string name = Console.ReadLine();
            return new TC(name);
        }
    }
}
