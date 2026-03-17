using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Student
    {
        public string name { get; set; }
        public double grade1 { get; set; }
        public double grade2 { get; set; }
        public double grade3 { get; set; }

        public Student(string name, double grade1, double grade2, double grade3)
        {
            this.name = name;
            this.grade1 = grade1;
            this.grade2 = grade2;
            this.grade3 = grade3;
        }

        public double Average(double grade1, double grade2, double grade3)
        {
            double sum = grade1 + grade2 + grade3;
            double average = sum / 3;
            Console.WriteLine($"El promedio del estudiante es de: {average}");

            return average;
        }

        public static bool IsAproved(double average)
        {
            if (average < 0) { return false; }
            if (average > 60) { return true; }

            return false;
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Nombre: {name}");
            Console.WriteLine($"Nota 1: {grade1}");
            Console.WriteLine($"Nota 2: {grade2}");
            Console.WriteLine($"Nota 3: {grade3}");
        }
    }
}
