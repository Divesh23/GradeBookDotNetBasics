using System;
using System.Collections.Generic;

namespace Gradebook
{
    public class Book
    {
        List<double> grades;
        public string name;
        public Book(string name)
        {
            this.name = name;
            grades= new List<double>();
        }
         
        public void AddGrades(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStats()
        {
            // Array Creation
            // var numbers = new[] {12.1,13.5,10.4};
            
            var result = new Statistics();
            result.Average=0.0;
            result.High=0.0;
            result.Low=0.0; 

            var count = grades.Count;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach(double number in grades)
            {
                result.High = Math.Max(number,result.High);
                result.Low = Math.Min(number,result.Low);
                result.Average += number;
            }

            result.Average = result.Average/count;
            return result;

        }
    }


}