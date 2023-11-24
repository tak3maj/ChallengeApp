﻿using System.ComponentModel.Design;

namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public string Name => "Adam";

        public string Surname => "Boss";

        public void AddGrade(float grade)
        {
            string gradeValue = grade.ToString();
            AddGrade(gradeValue);
        }

        public void AddGrade(char grade)
        {
            string gradeValue = grade.ToString();
            AddGrade(gradeValue);
        }

        public void AddGrade(long grade)
        {
            string gradeValue = grade.ToString();
            AddGrade(gradeValue);
        }

        public void AddGrade(double grade)
        {
            string gradeValue = grade.ToString();
            AddGrade(gradeValue);
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

            return statistics;
        }
    }
}
