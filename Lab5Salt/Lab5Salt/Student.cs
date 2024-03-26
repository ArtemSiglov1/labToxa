using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Salt
{
    /// <summary>
    /// класс студент
    /// </summary>
    internal class Student
    {
        /// <summary>
        /// свойство ФИО
        /// </summary>
       public string FIO { get; set; }
        /// <summary>
        /// свойсто 1 предмета 
        /// </summary>
        public string Predmet1 { get; set; }
        /// <summary>
        /// свойсто 2 предмета 
        /// </summary>
        public string Predmet2 { get; set; }
        /// <summary>
        /// свойсто 3 предмета 
        /// </summary>
        public string Predmet3 { get; set; }
        /// <summary>
        /// свойсто 4 предмета 
        /// </summary>
        public string Predmet4 { get; set; }
        /// <summary>
        /// свойсто 5 предмета 
        /// </summary>
        public string Predmet5 { get; set; }
        /// <summary>
        /// поля для оценок 
        /// </summary>
        int mark1, mark2, mark3, mark4, mark5;
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Student() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="fio"></param>
        /// <param name="predmet1"></param>
        /// <param name="predmet2"></param>
        /// <param name="predmet3"></param>
        /// <param name="predmet4"></param>
        /// <param name="predmet5"></param>
        public Student(string fio, string predmet1, string predmet2, string predmet3, string predmet4,string predmet5)

        {
            this.FIO = fio;
            this.Predmet1 = predmet1;
            this.Predmet2 = predmet2;
            this.Predmet3 = predmet3;
            this.Predmet4 = predmet4;
            Predmet5 =  predmet5;
        }
        /// <summary>
        /// метод для ввода оценки
        /// </summary>
        /// <param name="f"></param>
         public void Pr1(int f)
        { this.mark1 = f; }
        /// <summary>
        /// метод для ввода оценки
        /// </summary>
        /// <param name="f"></param>
        public void Pr2(int f)
        { this.mark2 = f; }
        /// <summary>
        /// метод для ввода оценки
        /// </summary>
        /// <param name="f"></param>
        public void Pr3(int f)

        { this.mark3 = f; }
        /// <summary>
        /// метод для ввода оценки
        /// </summary>
        /// <param name="f"></param>
        public void Pr4(int f)

        { this.mark4 = f; }
        /// <summary>
        /// метод для ввода оценки
        /// </summary>
        /// <param name="f"></param>
        public void Pr5(int f)

        { this.mark5 = f; }
        /// <summary>
        /// метод вывода информации выводим свойства класса и метод нахождения среднего балла
        /// </summary>
        public void Display() {
        Console.WriteLine($"студент {FIO} оценки {Predmet1}={mark1} {Predmet2}={mark2} {Predmet3}={mark3} {Predmet4}={mark4} {Predmet5}={mark5}");
            Console.WriteLine($"студент {FIO}, средний балл = {Sredn_ball()}");
        }
        /// <summary>
        /// метод нахождения среднего балла
        /// </summary>
        /// <returns>сумму всех оценок деленых на их кол во </returns>
        int Sredn_ball()
        { return (mark1 + mark2 + mark3 + mark4+mark5) / 5; }
    }
}

