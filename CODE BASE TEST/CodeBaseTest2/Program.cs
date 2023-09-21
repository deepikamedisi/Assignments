using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBaseTest_2
{
    abstract class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }

        public abstract bool IsPassed(double grade);
    }

    class Undergraduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }

    class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          
            Undergraduate undergradStudent = new Undergraduate
            {
                Name = "John",
                StudentId = 1,
                Grade = 75.0
            };

          
            Graduate gradStudent = new Graduate
            {
                Name = "Jane",
                StudentId = 2,
                Grade = 85.0
            };

            
            Console.WriteLine($"{undergradStudent.Name} passed: {undergradStudent.IsPassed(undergradStudent.Grade)}");
            Console.WriteLine($"{gradStudent.Name} passed: {gradStudent.IsPassed(gradStudent.Grade)}");
            Console.ReadLine();
        }
    }
}
