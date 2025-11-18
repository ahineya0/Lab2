using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonForm
{
    public class Student : Learner
    {
        public string major, faculty;
        
        public Student(string name, string surname, int age, decimal gpa, int year, 
            string placeOfStudy, string major = "Undeclared", string faculty = "General Studies")
            : base(name, surname, age, gpa, year, placeOfStudy)
        {
            Major = major;
            Faculty = faculty;
        }

        public override string GetRole()
        {
            return base.GetRole() + ", Student";
        }

        public override string ToString()
        {
            return base.ToString() + $", Major: {Major}, Faculty: {Faculty}";
        }

        public string Major
        {
            get { return major; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Специальность не может быть пустой");
                }
                major = value;
            }
        }

        public string Faculty
        {
            get { return faculty; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Факультет не может быть пустым");
                }
                faculty = value;
            }
        }

    }
}
