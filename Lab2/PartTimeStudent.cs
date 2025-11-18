using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonForm
{
    public class PartTimeStudent : Student
    {
        private int workHoursPerWeek;

        public PartTimeStudent(string name, string surname, int age, decimal gpa, int year, 
            string placeOfStudy, string major, string faculty,int workHoursPerWeek = 20)
            : base(name, surname, age, gpa, year, placeOfStudy, major, faculty)
        {
            WorkHoursPerWeek = workHoursPerWeek;
        }

        public override string GetRole()
        {
            return base.GetRole() + ", but part-time student";
        }

        public override string ToString()
        {
            return base.ToString() + $", Work hours per week: {WorkHoursPerWeek}";
        }

        public int WorkHoursPerWeek
        {
            get { return workHoursPerWeek; }
            set
            {
                if (value < 0 || value > 40)
                    throw new ArgumentOutOfRangeException("Количество рабочих часов в неделю должно быть от 0 до 40");
                workHoursPerWeek = value;
            }
        }


    }
}
