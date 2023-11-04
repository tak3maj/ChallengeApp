using ChallengeApp;

var employee = new Employee("Adam", "Grzyb");
employee.AddGrade("Adam");
employee.AddGrade("3000");
employee.AddGrade(2);
employee.AddGrade(237);
employee.AddGrade(237145645);
employee.AddGrade(-81.4678);
employee.AddGrade(8.37);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");