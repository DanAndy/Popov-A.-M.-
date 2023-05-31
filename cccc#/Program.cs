using oooop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace povtorenie
{
    class oop : Group
    {
        public int[] marks;

        public void student(int[] marks, int number, string fio, char gender, int age, int tel, string email, int kurs)
        {

        }

        public static void Print(string word)
        {
            Console.WriteLine(word);
        }

        public static void Main()
        {
            students stud1 = new students();
            stud1.setStudent(new int[] { 5 }, 1, "Андрей Попов", 'м', 20, 571275612, "adawjkda@mail.ru", 1);
            stud1.printSudent();
            students stud2 = new students();
            stud2.setStudent(new int[] { 4 }, 2, "Иван Петров", 'м', 20, 571275612, "adawjkda@mail.ru", 2);
            stud2.printSudent();
            students stud3 = new students();
            stud3.setStudent(new int[] { 3 }, 3, "Алиса Кружкова", 'ж', 20, 571275612, "adawjkda@mail.ru", 3);
            stud3.printSudent();
            students stud4 = new students();
            stud4.setStudent(new int[] { 2 }, 4, "Лиза Носова", 'ж', 20, 571275612, "adawjkda@mail.ru", 1);
            stud4.printSudent();
            //Group group = new Group();
            //group.setGroup("Ис", 21);
            //group.printGroup();
            Group group1 = new Group();
            group1.setGroup("ИС", 21, null);
            group1.Append(stud1);
            group1.Append(stud2);
            group1.Append(stud3);
            group1.Append(stud4);
            //group1.PrintBoys();
            //group1.PrintWomen();
            group1.PrintAll();
        }

    }
    class Group : students
    {
        public string Title { get; set; }
        public int Nomer { get; set; }
        public List<students> Students { get; set; }

        public void setGroup(string title, int nomer, List<students> students = null)
        {
            Title = title;
            Nomer = nomer;
            Students = new List<students>();
        }

        // Добавляем студента в группу
        public void Append(students stud)
        {
            Students.Add(stud);
        }
        public void PrintBoys()
        {
             if (gender != 'м')
                    Console.WriteLine(Students.Count);

        }
        public void PrintWomen()
        {
            char w = 'ж';
            for (int i = 0; i < Students.Count; i++)
            {
                if (gender != w)
                {
                    Console.WriteLine(Students.Count);
                }
            }
        }
        public void PrintAll()
        {
            foreach (var person in Students)
            {
                Console.WriteLine(person);
            }
        }

    }

}
