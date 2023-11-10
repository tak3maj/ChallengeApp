using ChallengeApp;

Console.WriteLine("Welcome to the XYZ Employee Assessment Program");
Console.WriteLine("____________________________________________");
Console.WriteLine();

var employee = new Employee("Ben", "Tod");

while (true)
{
    Console.WriteLine("Enter another employee rating from 0 to 100");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    employee.AddGrade(input);
    Console.WriteLine("If you want to end the operation and calculate the statistics, press q. If not this");
} 

var statistics = employee.GetStatistics(); 
Console.WriteLine($"Average is {statistics.Average:N2}");
Console.WriteLine($"Minimum is {statistics.Min}");
Console.WriteLine($"Maximum is {statistics.Max}");
Console.WriteLine($"Employee evaluation is {statistics.AverageLetter}");