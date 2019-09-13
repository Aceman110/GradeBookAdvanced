using System.Collections.Generic;
using System;

namespace GradeBook
 {
         public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }       
        public void AddGrade(double grade)
        {
         if(grade <= 100 && grade >= 0)
         { 
             grades.Add(grade);           
         }         
         else
         {
             throw new ArgumentException($"Invalid {nameof(grade)}");
         }
        }
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            for(var i = 0; i < grades.Count; i ++ )
           {
               result.High = Math.Max(grades[i], result.High);
               result.Low = Math.Min(grades[i], result.Low);
               result.Average += grades[i];
           }
           result.Average /= grades.Count;

           switch(result.Average)
           {
               case var d when d >= 90.0:
               result.letter = 'A';
               break;
               case var d when d >= 80.0:
               result.letter = 'B';
               break;
               case var d when d >= 70.0:
               result.letter = 'C';
               break;
               case var d when d >= 60.0:
               result.letter = 'D';
               break;
               default:
               result.letter = 'F';
               break;
           }

           return result;
        }
        private List<double> grades;
        
        public string Name
        {
            get; 
         set;
        }
    }
 }