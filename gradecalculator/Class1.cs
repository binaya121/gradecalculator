using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradecalculator
{
    class Student
    {
        public string Name { get; set; }
        public double MathsMarks { get; set; }
        public double PhysicsMarks { get; set; }
        public double ChemistryMarks { get; set; }
        public double ComputerScienceMarks { get; set; }

        public Student(string name)
        {
            Name = name;
        }

        public double CalculateAverage()
        {
            return (MathsMarks + PhysicsMarks + ChemistryMarks + ComputerScienceMarks) / 4.0;
        }

        public char CalculateGrade()
        {
            double average = CalculateAverage();
            if (average >= 80)
                return 'A';
            else if (average >= 70)
                return 'B';
            else if (average >= 60)
                return 'C';
            else if (average >= 50)
                return 'D';
            else
                return 'F';
        }
    }
}


