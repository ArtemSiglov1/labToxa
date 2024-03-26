using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //16//11
            TC tC=new TC("car");
            Avto avto = new Avto("car","BMW");
            Dvigatel dvigatel = Dvigatel.Init();
            Console.WriteLine(tC.ToString()+avto.ToString()+dvigatel.ToString());
        }
    }
}
