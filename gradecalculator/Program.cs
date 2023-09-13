using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradecalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student's name:");
            string name = Console.ReadLine();

            Student student = new Student(name);

            try
            {
                Console.Write("Enter marks for Maths (out of 100): ");
                student.MathsMarks = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter marks for Physics (out of 100): ");
                student.PhysicsMarks = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter marks for Chemistry (out of 100): ");
                student.ChemistryMarks = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter marks for Computer Science (out of 100): ");
                student.ComputerScienceMarks = Convert.ToDouble(Console.ReadLine());

                char grade = student.CalculateGrade();

                switch (grade)
                {
                    case 'A':
                        Console.WriteLine("Excellent! Your grade is A");
                        break;
                    case 'B':
                        Console.WriteLine("Good! Your grade is B");
                        break;
                    case 'C':
                        Console.WriteLine("Satisfactory. Your grade is C");
                        break;
                    case 'D':
                        Console.WriteLine("Pass. Your grade is D");
                        break;
                    case 'F':
                        Console.WriteLine("Fail. Your grade is F");
                        break;
                    default:
                        Console.WriteLine("Invalid grade");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numeric values for marks.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.ReadKey();  

        }
    }
}