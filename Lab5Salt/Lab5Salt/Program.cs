using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Salt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // создание объекта f класса student
            Student f = new Student("Сидоров", "математика", "информатика",
            "программирование", "история","англ");
            // обращение к открытым методам класса – ввод информации об оценках студента
            f.Pr1(2);
            f.Pr2(3);
            f.Pr3(3);
            f.Pr4(4);
            f.Pr5(5);
            f.Display();
            Console.Read();
        }
    }
}
