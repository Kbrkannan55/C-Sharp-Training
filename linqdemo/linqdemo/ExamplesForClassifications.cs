using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace linqdemo
{
    internal class ExamplesForClassifications
    {
        public void example1()
        {
            IList<string> courses = new List<string>();
            courses.Add("C++ Tutorials");
            courses.Add("C# Tutorials");
            courses.Add("Learn SQL");
            courses.Add("Web Technologies");
            courses.Add("Python Tutorials");


           // var tutorial = from t in courses where t.Contains("Tutorials") select t;

            var tutorial=courses.Where(c=> c.Contains("Tutorials"));
            
          
            foreach(var t in tutorial)
            {
                Console.WriteLine(t);
            }
            
        }


        public void example2()
        {
            IList<Student> students = new List<Student>()
            {
                new Student {StudentID=01,StudentName="Boopathi",StudentAge= 23},
                new Student {StudentID=02,StudentName="Jothika",StudentAge= 23},
                new Student {StudentID=03,StudentName="Keerthika",StudentAge= 33},
                new Student {StudentID=04,StudentName="Abinaya",StudentAge= 13},
                new Student {StudentID=05,StudentName="Anushaya",StudentAge= 20}
            };

            var filter=from s in students where s.StudentAge>12 && s.StudentAge<20 select s;

            foreach(var student in filter)
            {
                Console.WriteLine(student.StudentName);
            }

        }


        public void example3()
        {
            IList elements = new ArrayList();
            elements.Add(1);
            elements.Add("Boo");
            elements.Add(3);
            elements.Add(4);
            elements.Add("Joo");

            //var strings = from e in elements.OfType<int>() select e;

            var strings = elements.OfType<string>();
            foreach(var  s in strings)
            {
                Console.WriteLine(s);
            }
        }


        public void example4()
        {
            IList<Student> students = new List<Student>()
            {
                new Student {StudentID=01,StudentName="Boopathi",StudentAge= 23},
                new Student {StudentID=02,StudentName="Jothika",StudentAge= 23},
                new Student {StudentID=03, StudentName="Jothika",StudentAge=20},
                new Student {StudentID=03,StudentName="Keerthika",StudentAge= 33},
                new Student {StudentID=04,StudentName="Abinaya",StudentAge= 13},
                new Student {StudentID=05,StudentName="Anushaya",StudentAge= 20}
            };

          //  var sortoperation = from s in students orderby s.StudentName select s;
            var sortoperation = students.OrderBy(s  => s.StudentName ).ThenBy(s=> s.StudentAge);
            foreach(var student in sortoperation)
            {
                Console.WriteLine(student.StudentName);
            }

        }

        public void example5()
        {
            IList<Student> students = new List<Student>()
            {
                new Student {StudentID=01,StudentName="Boopathi",StudentAge= 23},
                new Student {StudentID=02,StudentName="Jothika",StudentAge= 23},
                new Student {StudentID=03, StudentName="Jothika",StudentAge=20},
                new Student {StudentID=03,StudentName="Keerthika",StudentAge= 33},
                new Student {StudentID=04,StudentName="Abinaya",StudentAge= 13},
                new Student {StudentID=05,StudentName="Anushaya",StudentAge= 20}
            };

           // var grouping = from s in students group s by s.StudentName;
         //   var grouping = students.GroupBy(s => s.StudentName);

            var grouping = students.ToLookup(s => s.StudentName);

            foreach (var student in grouping)
            {
                Console.WriteLine(student.Key);

                foreach (var x in students)
                {
                   
                    Console.WriteLine(x.StudentID+" "+ x.StudentAge);
                }
                Console.WriteLine();
            }
            


        }


    }


 
}
