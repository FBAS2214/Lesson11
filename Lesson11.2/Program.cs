using System;
using System.Linq;

namespace Lesson11_2
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly Birhtday { get; set; }
        public double Score { get; set; }

        public override string ToString()
        {
            return @$"
Id: {Id}
Name: {Name}
Surname: {Surname}
Birhtday: {Birhtday}
Score: {Score}";

        }
    }

    class Program
    {
        readonly static List<Student> _students = new List<Student>
        {
            new Student{ Id = 1, Name = "Leyla", Surname = "Qocayeva", Score = 11, Birhtday = new DateOnly(2002, 11, 4) },
            new Student{ Id = 2, Name = "Ceyhun", Surname = "Abdullayev", Score = 10, Birhtday = new DateOnly(2002, 4, 25) },
            new Student{ Id = 3, Name = "Ferman", Surname = "Esedov", Score = 9, Birhtday = new DateOnly(2005, 8, 16) },
            new Student{ Id = 4, Name = "Aga", Surname = "Akberzade", Score = 12, Birhtday = new DateOnly(2006, 6, 12) },
            new Student{ Id = 5, Name = "Sebine", Surname = "Shukurova", Score = 12, Birhtday = new DateOnly(2002, 7, 8) }
        };


        static void Main()
        {
            Student student = null;
            List<Student> students = null;

            // Predicate<Student> predicate = s => s.Id == 1;
            // Predicate<Student> predicate = delegate (Student s) { return s.Id == 1; };
            // Predicate<Student> predicate = Filter;

            // student = _students.Find(s => s.Id == 1);


            students = _students.FindAll(s => s.Birhtday.Year == 2002);

            // _students.ForEach(s => s.Id += 10);
            // _students.ForEach(s => Console.WriteLine(s));

            student = _students.FirstOrDefault(s => s.Name.ToLower().Contains("n"));


            Console.WriteLine(student);
        }












        static bool Filter(Student student)
        {
            return student.Id == 1;
        }
    }
}