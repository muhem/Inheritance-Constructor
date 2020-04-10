using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Chika", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Allan", 40, 190302, "logical information", "Dosen@teacher.amikom.ac.id");
            teacher.GetNameAndAge();

            Student student = new Student("Muhammad Erwin Syahrul Alim", 19, 2687, "muhammad.2676@student.amikom.ac.id");
            student.GetNameAndAge();
        }
    }
}