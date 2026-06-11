using System;

class Student
{
    // Public variable
    public string Name;

    // Private variable
    private int age;

    // Method to set age
    public void SetAge(int a)
    {
        age = a;
    }

    // Method to display age
    public void DisplayAge()
    {
        Console.WriteLine("Age: " + age);
    }
}

class Program
{
    static void Main()
    {
        // VARIABLES
        int a = 5;
        int b = 3;

        Console.WriteLine("Value of a: " + a);
        Console.WriteLine("Value of b: " + b);

        // STRING.EMPTY
        string message = string.Empty;

        // IF ELSE
        if (a == 1)
        {
            message = "a is equal to 1";
        }
        else if (a > 1)
        {
            message = "a is greater than 1";
        }
        else
        {
            message = "a is less than 1";
        }

        Console.WriteLine("\nCondition Result:");
        Console.WriteLine(message);

        // ARRAY
        string[] cars = { "BMW", "Audi", "Tesla", "Mercedes" };

        Console.WriteLine("\nCars Array:");

        foreach (string car in cars)
        {
            Console.WriteLine(car);
        }

        // BITWISE COMPLEMENT (~)
        Console.WriteLine("\nBitwise Complement:");
        Console.WriteLine("~5 = " + (~a));

        // BITWISE AND (&)
        Console.WriteLine("\nBitwise AND:");
        Console.WriteLine("5 & 3 = " + (a & b));

        // BITWISE OR (|)
        Console.WriteLine("\nBitwise OR:");
        Console.WriteLine("5 | 3 = " + (a | b));

        // BITWISE XOR (^)
        Console.WriteLine("\nBitwise XOR:");
        Console.WriteLine("5 ^ 3 = " + (a ^ b));

        // LEFT SHIFT (<<)
        Console.WriteLine("\nLeft Shift:");
        Console.WriteLine("5 << 1 = " + (a << 1));

        // RIGHT SHIFT (>>)
        Console.WriteLine("\nRight Shift:");
        Console.WriteLine("5 >> 1 = " + (a >> 1));

        // Easy Trick for Exams
        // & → Common 1s only
        // | → All 1s
        // ^ → Different bits only
        // << n → Multiply by 2^n
        // >> n → Divide by 2^n (integer division)

        // CLASS AND OBJECT
        Student s1 = new Student();

        s1.Name = "Krishna";
        s1.SetAge(19);

        Console.WriteLine("\nClass and Object:");
        Console.WriteLine("Name: " + s1.Name);
        s1.DisplayAge();

        Console.WriteLine("\nProgram Finished Successfully.");
    }
}


// //output

// Value of a: 5
// Value of b: 3

// Condition Result:
// a is greater than 1

// Cars Array:
// BMW
// Audi
// Tesla
// Mercedes

// Bitwise Complement:
// ~5 = -6

// Bitwise AND:
// 5 & 3 = 1

// Bitwise OR:
// 5 | 3 = 7

// Bitwise XOR:
// 5 ^ 3 = 6

// Left Shift:
// 5 << 1 = 10

// Right Shift:
// 5 >> 1 = 2

// Class and Object:
// Name: Krishna
// Age: 19
 