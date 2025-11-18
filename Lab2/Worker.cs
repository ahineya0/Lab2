using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonForm
{
    public class Worker : Person
    {
        private string company, jobTitle;

        public Worker(string name, string surname,  int age, string company = "UnknownCompany", string jobTitle = "Unknown") : base(name, surname, age)
        {
            Company = company;
            JobTitle = jobTitle;
        }

        public override string GetRole()
        {
            return "Worker";
        }

        public override string ToString()
        {
            return base.ToString() + $", Company: {Company}, Job: {JobTitle}";
        }

        public string Company
        {
            get { return company; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Название компании не может быть пустым");
                company = value;
            }
        }

        public string JobTitle
        {
            get { return jobTitle; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Название должности не может быть пустым");
                jobTitle = value;
            }
        }
    }
}
