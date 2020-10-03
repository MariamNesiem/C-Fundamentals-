using System;
using System.Collections.Generic;

namespace src
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public interface IBook{
        void AddGrade(double grade);
        Statistics GetStatistics();
        string Name {get;}
        event GradeAddedDelegate GradeAdded;
    }
    public abstract class Book :NameObject , IBook
    {
        public Book(string name) : base(name)

        {}

        public virtual event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        public virtual Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
    public class NameObject
    {
        private string name;

        public NameObject(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }
    }
    public class InMemoryBook : Book , IBook
    {

        private List<double> grades;

        public readonly string category = "Science"; //can change it only in constructor
        public const int CATEGORY = 3; //can't change it even in constructor and can read only with class name and should be written in uppercase

        //to pass name to constructor of NameObject use base
        public InMemoryBook(string name) : base(name)

        {

            category = "";
            //CATEGORY = 4;
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        }
        public override void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
                //event
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());

                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }

        }
        public override event GradeAddedDelegate GradeAdded;
        public override Statistics GetStatistics()
        {

            var result = new Statistics();

            foreach (var a in grades)
            {
                if (a == 42.1)
                {
                    // break;
                    // continue;
                    goto done; //we can put done anywhere
                }

                result.High = Math.Max(a, result.High);
                result.Low = Math.Min(a, result.Low);
                result.SUM += a;
            }
            result.Avg = result.SUM / grades.Count;
            switch (result.Avg)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;

                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;

                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;

                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;

                default:
                    result.Letter = 'F';
                    break;
            }

        done:
            return result;
        }


    }
}
