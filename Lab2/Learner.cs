using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonForm
{ 
    public class Learner : Person
    {
        private decimal gpa;
        private int year;
        private string placeOfStudy;

        public Learner(string name, string surname, int age,
                       decimal gpa = 0.0m, int year = 0, string placeOfStudy = "Unknown")
            : base(name, surname, age)
        {
            Gpa = gpa;
            Year = year;
            PlaceOfStudy = placeOfStudy;
        }

        public override string GetRole()
        {
            return "Learner";
        }

        public override string ToString()
        {
            return base.ToString() +
                   $", GPA: {Gpa.ToString(CultureInfo.InvariantCulture)}, Year: {Year}, Place: {PlaceOfStudy}";
        }

        public decimal Gpa
        {
            get { return gpa; }
            set
            {
                if (value < 0.0m || value > 5.0m)
                    throw new ArgumentOutOfRangeException("GPA должен быть в диапазоне от 0.0 до 5.0");
                gpa = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 0 || value > 11)
                    throw new ArgumentOutOfRangeException("Год обучения не может быть меньше 0 и больше 11");
                year = value;
            }
        }

        public string PlaceOfStudy
        {
            get { return placeOfStudy; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Место обучения не может быть пустым");
                placeOfStudy = value;
            }
        }
    }
}
