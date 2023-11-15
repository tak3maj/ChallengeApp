using System.ComponentModel.Design;

namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public string Name => "Adam";

        public string Surname => "Boss";

        public void AddGrade(float grade)
        {
                throw new Exception("Invalid grade value");
        }

        public void AddGrade(short grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(long grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.AddGrade(100);
                    break;
                case "6-":
                case "-6":
                    this.AddGrade(95);
                    break;
                case "5+":
                case "+5":
                    this.AddGrade(85);
                    break;
                case "5":
                    this.AddGrade(80);
                    break;
                case "5-":
                case "-5":
                    this.AddGrade(75);
                    break;
                case "4+":
                case "+4":
                    this.AddGrade(65);
                    break;
                case "4":
                    this.AddGrade(60);
                    break;
                case "4-":
                case "-4":
                    this.AddGrade(55);
                    break;
                case "3+":
                case "+3":
                    this.AddGrade(45);
                    break;
                case "3":
                    this.AddGrade(40);
                    break;
                case "3-":
                case "-3":
                    this.AddGrade(35);
                    break;
                case "2+":
                case "+2":
                    this.AddGrade(25);
                    break;
                case "2":
                    this.AddGrade(20);
                    break;
                case "2-":
                case "-2":
                    this.AddGrade(15);
                    break;
                case "1+":
                case "+1":
                    this.AddGrade(5);
                    break;
                case "1":
                    this.AddGrade(0);
                    break;
                default:
                    if (float.TryParse(grade, out float value))
                    {
                        this.AddGrade(value);
                        break;
                    }
                    else
                    {
                        throw new Exception("String is not float");
                    }
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var index in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, index);
                statistics.Min = Math.Min(statistics.Min, index);
                statistics.Average += index;
            }
            statistics.Average /= this.grades.Count;

            //switch (statistics.Average)
            //{
            //    case var average when average >= 100:
            //        statistics.AverageLetter = '6';
            //        break;
            //    case var average when average >= 95:
            //        statistics.AverageLetter = '6-';
            //        break;
            //    case var average when average >= 85:
            //        statistics.AverageLetter = '5+';
            //        break;
            //    case var average when average >= 80:
            //        statistics.AverageLetter = '5';
            //        break;
            //    case var average when average >= 75:
            //        statistics.AverageLetter = '5-';
            //        break;
            //    case var average when average >= 65:
            //        statistics.AverageLetter = '4+';
            //        break;
            //    case var average when average >= 60:
            //        statistics.AverageLetter = '4';
            //        break;
            //    case var average when average >= 55:
            //        statistics.AverageLetter = '3+';
            //        break;
            //    case var average when average >= 40:
            //        statistics.AverageLetter = '3';
            //        break;
            //    case var average when average >= 35:
            //        statistics.AverageLetter = '3-';
            //        break;
            //    case var average when average >= 25:
            //        statistics.AverageLetter = '2+';
            //        break;
            //    case var average when average >= 20:
            //        statistics.AverageLetter = '2';
            //        break;
            //    case var average when average >= 15:
            //        statistics.AverageLetter = '2-';
            //        break;
            //    case var average when average >= 10:
            //        statistics.AverageLetter = '1+';
            //        break;
            //    default:
            //        statistics.AverageLetter = '1';
            //        break;
            //}

            return statistics;
        }
    }
}
