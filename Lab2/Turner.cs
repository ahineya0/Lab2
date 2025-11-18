using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonForm
{
    public class Turner : Worker
    {
        private int experienceYears;
        private string toolType;

        public Turner(string name, string surname, int age, string company, string jobTitle, int experienceYears = 0, string toolType = "Lathe")
            : base(name, surname, age, company, jobTitle)
        {
            ExperienceYears = experienceYears;
            ToolType = toolType;
        }

        public override string GetRole()
        {
            return base.GetRole() + " , Turner";
        }

        public override string ToString()
        {
            return base.ToString() + $", Experience: {ExperienceYears} years, Tool type: {ToolType}";
        }

        public int ExperienceYears
        {
            get { return experienceYears; }
            set
            {
                if (value < 0 || value > Age - 18)
                    throw new ArgumentOutOfRangeException("Опыт работы не может быть меньше 0 и превышать количество лет с 18 лет");
                experienceYears = value;
            }
        }

        public string ToolType
        {
            get { return toolType; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Тип инструмента не может быть пустым");
                toolType = value;
            }
        }
    }
}
