using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp
{
    public class GradeBook
    {
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
           var stats= new GradeStatistics();
           
            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
              //  sum = sum + grade;
            }
            stats.AverageGrade = sum / grades.Count;

            return stats;
        }



        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }
        public NameChangeDelegate NameChanged;

        private string _name;
        private List<float> grades;
    }
}
