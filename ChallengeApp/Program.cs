using ChallengeApp;

var employee = new Employee("Adam", "Grzyb");
employee.AddGrade(9f);
employee.AddGrade(2);
employee.AddGrade(23);
employee.AddGrade(56);
employee.AddGrade(81.1);
employee.AddGrade(8.37);

var statistics1 = employee.GetStatisticsWithForEach();
Console.WriteLine($"Statistics using Foreach loop");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine();

var statistics2 = employee.GetStatisticsWithFor();
Console.WriteLine($"Statistics using For loop");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine();

var statistics3 = employee.GetStatisticsWithDoWhile();
Console.WriteLine($"Statistics using Do..While loop");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine();

var statistics4 = employee.GetStatisticsWithWhile();
Console.WriteLine($"Statistics using While loop");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");