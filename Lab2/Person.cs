using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PersonForm
{
    public abstract class Person
    {
        private string name, surname;
        private int age;

        public Person(string name = "John", string surname = "Doe", int age = 18)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public virtual string GetRole()
        {
            return "No information";
        }

        public override string ToString()
        {
            return $"{GetType().Name} Name: {Name}, Surname: {Surname}, Age: {Age}";
        }

        public string Name
        {
            get { return name; }
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw new ArgumentException("Имя не может быть пустым");
                name = value;
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw new ArgumentException("Фамилия не может быть пустой");
                surname = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if(value < 1 || value > 122)
                    throw new ArgumentOutOfRangeException("Возраст должен быть в диапазоне от 1 до 122");
                age = value;
            }
        }
    }
}
