using Employee;
//using System.Runtime.CompilerServices;
//using System.Threading.Tasks.Sources;

Emp emp1 = new Emp("Adam", "Grzyb");
Emp emp2 = new Emp("Monika", "Woda");
Emp emp3 = new Emp("Zuzia", "Trawa");

emp1.AddScore(15);
emp1.AddScore(2);
emp1.AddScore(1);

emp2.AddScore(2);
emp2.AddScore(5);
emp2.AddScore(-9);

emp3.AddScore(11);
emp3.AddScore(15);
emp3.AddScore(1);

var result = emp1.Result;
var result1 = emp2.Result;
var result2 = emp3.Result;

List<Emp> emps = new List<Emp>()
{
    emp1, emp2, emp3
};

int maxResult = -1;
Emp empWithMaxResult = null;

foreach (var emp in emps)
{
    if (emp.Result > maxResult)
    {
        maxResult = emp.Result;
        empWithMaxResult = emp;
    }
}
Console.WriteLine($"Maximum punktów, czyli {maxResult} ma {empWithMaxResult.Name} {empWithMaxResult.Surname}");
