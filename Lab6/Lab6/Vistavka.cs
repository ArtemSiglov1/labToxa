

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Vistavka:Galery
    {
        public int CountObj {  get; set; }
        public Vistavka() { }
        public Vistavka(string name,string avtor,int count):base(name,avtor) {
            CountObj = count; }
        public override string ToString()
        {
            return base.ToString() + CountObj;
        }
        //input
        public static new Vistavka Init()
        {
            Console.WriteLine("input name");
            string name = Console.ReadLine();
            Console.WriteLine("input marka");
            string marka = Console.ReadLine();
            Console.WriteLine("inpet power");
            int count = int.Parse(Console.ReadLine());
            return new Vistavka(name, marka, count);
        }
    }
}
