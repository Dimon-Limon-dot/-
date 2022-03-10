using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClass
{
    public class Class1
    {

        public class Mark
        {
            public DateTime date { get; set; }
            public string Estimation { get; set; }
        }

        public class Student
        {
            public string FIO { get; set; }
            public int Group { get; set; }
            public DateTime DateReceipt { get; set; }
        }

        public static double MinAVG(string[] marks)
        {
            double resultAvg;
            double mark = 0;
            int count = 0;
            for (int i = 0; i < marks.Count(); i++)
            {
                bool result = Double.TryParse(marks[i], out var number);
                if (result == true)
                {
                    mark += Math.Round(number, 1);
                    count += 1;
                }
            }
            resultAvg = Math.Truncate(mark / count);
            return resultAvg;
        }

        public static int GetCountTruancy(List<Mark> marks)
        {
            int Count = 0;
            List<String> markList = new List<String>();
            IList list = marks;
            for (int i = 0; i < list.Count; i++)
            {
                string Mark = (string)list[i];
                try
                {
                    String value = Mark;
                    markList.Add(value);
                    if (markList[i] == "н")
                    {
                        Count += 1;
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
            return Count;
        }

        public static int GetCountDisease(List<Mark> marks)
        {
            int Count = 0;
            List<String> markList = new List<String>();
            IList list = marks;
            for (int i = 0; i < list.Count; i++)
            {
                string Mark = (string)list[i];
                try
                {
                    String value = Mark;
                    markList.Add(value);
                    if (markList[i] == "б")
                    {
                        Count += 1;
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
            return Count;
        }

        public static string GetStudentNumber(int year, int group, string fio)
        {
            string[] FIO = fio.Split(' ');
            return $"{year}.{group}.{FIO[0][0]}{FIO[1][0]}{FIO[2][0]}";
        }

        //public List<Mark> GetMarks(DateTime now, List<Student> students)
        //{
        //    List<Mark> result = new List<Mark>();

        //    for (int i = now.Day; i < now.Day + 10; i++)
        //    {
        //        DateTime current = new DateTime(now.Year, now.Month, i);

        //        foreach (Student student in students)
        //        {
        //            string pushData = markTypeList[rand.Next(0, 3)];

        //            result.Add(new Mark() { Date = current, StudentData = student, Estimation = pushData });
        //        }
        //    }

        //    return result;
        //}
    }
}
