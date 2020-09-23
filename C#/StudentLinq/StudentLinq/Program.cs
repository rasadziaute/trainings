using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace StudentLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. Get Students which are not part of Merit list");
            var students = Student.GetStudents().Where(p => !Student.GetMeritStudent().Any(p2 => p2.Name == p.Name && p2.Id == p.Id));

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id}, {student.Name}");
            }

            // 2. We don't have to do the 2nd

            Console.WriteLine("3. Fetch Record of Students Whose Total marks > 265");

            var studentsTotalMarks = Student.GetStudents().Where(x => x.TotalMarks > 265);
            foreach (var student in studentsTotalMarks)
            {
                Console.WriteLine($"{student.Id}, {student.Name}");
            }

            Console.WriteLine("4. Fetch Student Record whose marks in each Subject > 80");

            var studentsTotalMarksSubject = from student in Student.GetStudents()
                                            where student.Subjects.All(m => m.Marks > 80)
                                            select new { student.Id, student.Name };

            foreach (var student in studentsTotalMarksSubject)
            {
                Console.WriteLine($"{student.Id}, {student.Name}");
            }

            Console.ReadLine();

            Console.WriteLine("Implementing LINQ to XML");
            Console.WriteLine("Paste in location and document name where to create an xml document");
            var location = Console.ReadLine();

            StudentLinqToXml.CreateXML(location);

           
        }
    }
}
