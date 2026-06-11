using System;
using System.Collections.Generic;

// Student Class
class Student
{
    public string Name { get; set; }
    public int RollNo { get; set; }
    public string Course { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        while (true)
        {
            Console.WriteLine("\n===== STUDENT MANAGEMENT SYSTEM =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Exit");

            Console.Write("Enter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Student s = new Student();

                    Console.Write("Enter Name: ");
                    s.Name = Console.ReadLine();

                    Console.Write("Enter Roll Number: ");
                    s.RollNo = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Course: ");
                    s.Course = Console.ReadLine();

                    students.Add(s);

                    Console.WriteLine("\nStudent Added Successfully!");
                    break;

                case 2:
                    Console.WriteLine("\n===== STUDENT LIST =====");

                    if (students.Count == 0)
                    {
                        Console.WriteLine("No Students Found!");
                    }
                    else
                    {
                        foreach (Student student in students)
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine($"Name     : {student.Name}");
                            Console.WriteLine($"Roll No  : {student.RollNo}");
                            Console.WriteLine($"Course   : {student.Course}");
                        }
                    }

                    break;

                case 3:
                    Console.WriteLine("Exiting Program...");
                    return;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
    }
}