namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            int valueInt = (int)grade;

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else 
            {
                Console.WriteLine("Invalid grade value");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else 
            { 
                Console.WriteLine("String is not float");
            }
        }
        public void AddGrade(short grade)
        {
            int valueInt = (int)grade;
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            { 
                Console.WriteLine("Short is not float");
            }
        }
        public void AddGrade(long grade)
        {
            int valueInt = (int)grade;
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Long is not float");
            }
        }
        public void AddGrade(double grade)
        {
            int dbl = (int)grade;
          
            if (dbl >= 0 && dbl <= 100)
            {
                this.grades.Add(dbl);
            }
            else
            {
                Console.WriteLine("Invalid value of number");
            }
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}
