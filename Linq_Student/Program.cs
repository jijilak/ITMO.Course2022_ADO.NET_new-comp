using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Student
{
    internal class Program
    {
        static List<Student> students = new List<Student>
        {
            new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
            new Student {First="Claire", Last="O’Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
            new Student {First="Jiji", Last="Lak", ID=113, Scores= new List<int> {97, 92, 81, 60}},
        };
        static void Main(string[] args)
        {
            //IEnumerable<Student> studentQuery = from student in students where student.Scores[0] > 90 select student;   Lab7Ex1
            IEnumerable<Student> studentQuery = from student in students where student.Scores[0] > 90 && student.Scores[3] < 80
                                                //orderby student.Last ascending
                                                orderby student.Last descending
                                                select student;

            foreach (Student student in studentQuery)
            {
                //Console.WriteLine("{0}, {1}", student.Last, student.First);   Lab7Ex1

                Console.WriteLine("{0}, {1} {2}", student.Last, student.First, student.Scores[0]);
            }
            
            var studentQuery2 = from student in students group student by student.Last[0];
            foreach (var studentGroup in studentQuery2)
            {
                Console.WriteLine(studentGroup.Key);
                foreach (Student student in studentGroup)
                {
                    Console.WriteLine("   {0}, {1}", student.Last, student.First);
                }
            }
        }
    }
}
