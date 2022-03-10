using MainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MainClass.Class1;

namespace ConsoleApp2
{
    internal class Program
    {
        //public static List<Student> studentsdata = new List<Student>()
        //{ new Student(new DateTime(2002, 12, 12), 1202, "Лебедев Алексей Сергеевич"),
        //  new Student(new DateTime(2002, 12, 11), 1202, "Лебедев Алексей Сергеевич"),
        //  new Student(new DateTime(2002, 12, 24), 122, "Лебедев Алексей Сергеевич"),
        //};
        static void Main(string[] args)
        {
            Console.WriteLine("Подсчет среднего балла студента");
            string[] marks = new string[] { "5", "5", "3", "4", "н", "4", "5", "н", "5" };
            Console.Write("Отметки: ");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write(marks[i] + ",");
            }
            Console.WriteLine();
            Console.Write("Средний балл: ");
            Console.WriteLine(Class1.MinAVG(marks));
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Генерация № студенческого билета");
            string FIO;
            int Year;
            int Group;
            Console.Write("№ билета: ");
            Console.WriteLine(Class1.GetStudentNumber(2018, 1282, "Лебедев Алексей Сергеевич"));
            Console.WriteLine();
            Console.ReadKey();
      
        }
    }
}
