using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one teacher from Teacher class
            Teacher teacher = new Teacher();
            teacher.Firstname = "Kirsi";
            teacher.Lastname = "Kernel";
            teacher.Age = 30;
            teacher.Address = "Piippukatu 2";
            teacher.Room = "D444";
            teacher.PhoneNumber = "040-12345678";
            Console.WriteLine(teacher.ToString());

            Student student = new Student("Matti","Mallikas", "H9909");
            student.Address = "Kirkkokatu 10";
            student.Age = 12;
            student.PhoneNumber = "050-12345678";
            Console.WriteLine(student.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();
        }
    }
}
