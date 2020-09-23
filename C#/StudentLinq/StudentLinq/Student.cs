using System;
using System.Collections.Generic;
using System.Text;

namespace StudentLinq
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }
        public List<Subject> Subjects { get; set; }

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student
            {
                Id = 101,
                Name = "Preety",
                TotalMarks = 255,
                Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 80},
                        new Subject(){SubjectName = "Science", Marks = 90},
                        new Subject(){SubjectName = "English", Marks = 95}
                    }
            });
            students.Add(new Student
            {
                Id = 102,
                Name = "Sambit",
                TotalMarks = 275,
                Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 90},
                        new Subject(){SubjectName = "Science", Marks = 95},
                        new Subject(){SubjectName = "English", Marks = 93}
                }
            });


            students.Add(new Student
            {
                Id = 103,
                Name = "Hina",
                TotalMarks = 240,
                Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 70},
                        new Subject(){SubjectName = "Science", Marks = 80},
                        new Subject(){SubjectName = "English", Marks = 90}
                    }
            });
            students.Add(new Student
            {
                Id = 104,
                Name = "Anurag",
                TotalMarks = 278,
                Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 90},
                        new Subject(){SubjectName = "Science", Marks = 90},
                        new Subject(){SubjectName = "English", Marks = 95}
                    }
            });
            students.Add(new Student
            {
                Id = 105,
                Name = "Pranaya",
                TotalMarks = 265,
                Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 80},
                        new Subject(){SubjectName = "Science", Marks = 90},
                        new Subject(){SubjectName = "English", Marks = 85}
                    }
            });
            students.Add(new Student
            {
                Id = 106,
                Name = "Santosh",
                TotalMarks = 263,
                Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 86},
                        new Subject(){SubjectName = "Science", Marks = 70},
                        new Subject(){SubjectName = "English", Marks = 95}
                    }
            });

            return students;
        }

        public static List<Student> GetMeritStudent()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 102, Name = "Sambit" });
            students.Add(new Student { Id = 104, Name = "Anurag" });
            students.Add(new Student { Id = 105, Name = "Pranaya" });
            return students;
        }
    }
}
