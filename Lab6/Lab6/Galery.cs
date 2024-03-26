using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Galery:Museum
    {
        public string Avtor {  get; set; }
        public Galery() { }
        public Galery(string name,string avtor):base(name) {
            Avtor = avtor; }
        public override string ToString()
        {
            return base.ToString() + Avtor;
        }
        public new static Galery Init()
        {
            Console.WriteLine("input name");
            string name = Console.ReadLine();
            Console.WriteLine("input marka");
            string avtor = Console.ReadLine();
            return new Galery(name, avtor);
        }
    }
}
