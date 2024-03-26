using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Salt
{
    internal class Student
    {
       public string FIO { get; set; }
        public string Predmet1 { get; set; }
        public string Predmet2 { get; set; }
        public string Predmet3 { get; set; }
        public string Predmet4 { get; set; }
        public string Predmet5 { get; set; }
        int mark1, mark2, mark3, mark4, mark5;
        public Student() { }
        // конструктор класса
        public Student(string fio, string predmet1, string predmet2, string predmet3, string predmet4,string predmet5)

        {
            this.FIO = fio;
            this.Predmet1 = predmet1;
            this.Predmet2 = predmet2;
            this.Predmet3 = predmet3;
            this.Predmet4 = predmet4;
            Predmet5 =  predmet5;
        }
         public void Pr1(int f)
        { this.mark1 = f; }
        public void Pr2(int f)
        { this.mark2 = f; }
        public void Pr3(int f)

        { this.mark3 = f; }
        public void Pr4(int f)

        { this.mark4 = f; }
        public void Pr5(int f)

        { this.mark5 = f; }
        public void Display() {
        Console.WriteLine($"студент {FIO} оценки {Predmet1}={mark1} {Predmet2}={mark2} {Predmet3}={mark3} {Predmet4}={mark4} {Predmet5}={mark5}");
            Console.WriteLine($"студент {FIO}, средний балл = {Sredn_ball()}");
        }
        int Sredn_ball()
        { return (mark1 + mark2 + mark3 + mark4+mark5) / 5; }
    }
}

