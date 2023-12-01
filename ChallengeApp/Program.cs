using ChallengeApp;
using System;

Console.WriteLine("Welcome to the XYZ Employee Assessment Program");
Console.WriteLine("____________________________________________");
Console.WriteLine();

var employee = new EmployeeInFile("Ben", "Tod");
employee.GradeAdded += EmployeeGradeAdded;

while (true)
{
    Console.WriteLine("Enter another employee rating from 0 to 100");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }

    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
    Console.WriteLine("If you want to end the operation and calculate the statistics, press q. If not this");
}
void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("To add new grade to employee");
}

var statistics = employee.GetStatistics(); 
Console.WriteLine($"Average is {statistics.Average:N2}");
Console.WriteLine($"Minimum is {statistics.Min}");
Console.WriteLine($"Maximum is {statistics.Max}");
Console.WriteLine($"Employee evaluation is {statistics.AverageLetter}");