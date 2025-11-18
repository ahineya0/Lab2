using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonForm
{
    public class Programmer : Worker
    {
        private string programmingLanguage;
        private int projectsCompleted;

        public Programmer(string name, string surname, int age, string company, string jobTitle,
                          string programmingLanguage = "C#", int projectsCompleted = 0)
            : base(name, surname, age, company, jobTitle)
        {
            ProgrammingLanguage = programmingLanguage;
            ProjectsCompleted = projectsCompleted;
        }

        public override string GetRole()
        {
            return base.GetRole() + ", Programmer";
        }

        public override string ToString()
        {
            return base.ToString() + $", Programming language: {ProgrammingLanguage}, Projects completed: {ProjectsCompleted}";
        }

        public string ProgrammingLanguage
        {
            get { return programmingLanguage; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Язык программирования не может быть пустым");
                programmingLanguage = value;
            }
        }

        public int ProjectsCompleted
        {
            get { return projectsCompleted; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Количество завершенных проектов не может быть меньше 0");
                projectsCompleted = value;
            }
        }


    }
}
