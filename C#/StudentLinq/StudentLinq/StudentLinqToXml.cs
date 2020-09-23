using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace StudentLinq
{
    public class StudentLinqToXml
    {
        public static void CreateXML(string location)
        {
            var xmlStudents = Student.GetStudents();

            var xmlDocumentFinal = new XDocument(new XElement("Document"));

            foreach (var student in xmlStudents)
            {
                var xmlDocumentStage =
                    new XElement("Student", new XAttribute("StudentId", student.Id),
                        new XElement("StudentName", student.Name),
                        new XElement("StudentTotalMarks", student.TotalMarks)
                        );

                xmlDocumentFinal.Root.Add(xmlDocumentStage);
            }

            IEnumerable<string> studentNames = from studentsXml in xmlDocumentFinal.Descendants("Student")
                                               select studentsXml.Element("StudentName").Value;

            Console.WriteLine("Querying xml document to get Names");
            foreach (var name in studentNames)
            {
                Console.WriteLine(name);
            }

            xmlDocumentFinal.Element("Document").Elements("Student").Where(x => x.Attribute("StudentId").Value == "101").SingleOrDefault().
                SetElementValue("StudentTotalMarks", 260);

            xmlDocumentFinal.Root.Elements().Where(x => x.Attribute("StudentId").Value == "105").FirstOrDefault().Remove();

            xmlDocumentFinal.Save(@location);
            Console.WriteLine("Document created");

        }
    }
}
