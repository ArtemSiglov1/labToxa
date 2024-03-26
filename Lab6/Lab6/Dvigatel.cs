using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Dvigatel:Avto
    {
        public int Power {  get; set; }
        public Dvigatel() { }
        public Dvigatel(string name,string marka,int power):base(name,marka)
        {
            Power = power;
        }
        //output
        public override string ToString()
        {
            return base.ToString()+Power;
        }
        //input
        public static new Dvigatel Init()
        {
            Console.WriteLine("input name");
            string name = Console.ReadLine();
            Console.WriteLine("input marka");
            string marka = Console.ReadLine();
            Console.WriteLine("inpet power");
            int power = int.Parse(Console.ReadLine());
            return new Dvigatel(name, marka,power);
        }
    }
}
