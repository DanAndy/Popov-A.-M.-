using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace oooop
{
    class students
    {
        private static int count;
        public int[] marks;
        public int numberst;
        public string fio;
        public char gender;
        public int age;
        public int tel;
        public string email;
        public int kurs;


        public void setStudent(int[] marks, int numberst, string fio, char gender, int age, int tel, string email, int kurs)
        {
            this.marks = marks;
            this.numberst = numberst;
            this.fio = fio;
            this.gender = gender;
            this.age = age;
            this.tel = tel;
            this.email = email;
            this.kurs = kurs;
        }
        public void printSudent()
        {
            this.kurs += 1;
            Console.WriteLine("Номер студента: " + this.numberst + " Студент : " + this.fio + " учится на " + this.kurs + " курсе " + " номер студ билета " + numberst) ;
            
            if (this.kurs > 4 || this.kurs < 1)
            {
                Console.WriteLine("Куда мы лезем");
            }
            count++;
        }
        public static void Print()
        {
            Console.WriteLine("Count: " + count);
        }
        //public void Kurs(int kurs)
        //{
        //    if (this.kurs > 4 || this.kurs < 1)
        //    {
        //        Console.WriteLine("Куда мы лезем");
        //    }
        //}

    }
}
