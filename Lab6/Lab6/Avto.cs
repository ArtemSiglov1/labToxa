using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Avto:TC
    {
        public string Marka {  get; set; }
        public Avto() { }
        public Avto(string name,string marka):base(name)
        {
            Marka = marka;
        }
        public override string ToString()
        {
            return base.ToString()+Marka;
        }
        public new static Avto Init()
        {
            Console.WriteLine("input name");
            string name = Console.ReadLine();
            Console.WriteLine("input marka");
            string marka = Console.ReadLine();
            return new Avto(name,marka);
        }
    }
}
