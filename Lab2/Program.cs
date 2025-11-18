using PasswordForm;
using PersonForm;
using System;


namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choose;
            Console.WriteLine("Выберите задание (1 - задание с перегрузкой операцией, 2 - задание с наследованием): ");
            choose = int.TryParse(int.Parse(Console.ReadLine()).ToString(), out choose) ? choose : 0;

            switch (choose)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Замена последнего символа");
                        Password pass1 = new Password("1234567f");
                        Console.WriteLine($"Изначальный пароль: {pass1.Pword}");
                        pass1 = pass1 - 'g';
                        Console.WriteLine($"Замена последнего символа на g: {pass1.Pword}");

                        Console.WriteLine($"\nСравнение длин паролей");
                        Password pass2 = new Password("1234567g");
                        Console.WriteLine($"Длина первого пароля: {pass1.Pword.Length}");
                        Console.WriteLine($"Длина второго пароля: {pass2.Pword.Length}");
                        Console.WriteLine("Длина " + (pass1 > pass2 ? "первого " : "второго ") + "пароля больше");

                        Console.WriteLine("\nСравнение паролей");
                        Console.WriteLine($"Первый пароль: {pass1.Pword}");
                        Console.WriteLine($"Второй пароль: {pass2.Pword}");
                        Console.WriteLine("Пароли " + (pass1 == pass2 ? "совпадают" : "не совпадают"));

                        Console.WriteLine("\nСброс пароля по умолчанию");
                        Console.WriteLine($"Изначальный пароль: {pass1.Pword}");
                        pass1++;
                        Console.WriteLine($"Пароль после сброса: {pass1.Pword}");

                        Console.WriteLine("\nПроверка пароля на стойкость");
                        Console.WriteLine($"Пароль: {pass1.Pword}");

                        if (pass1)
                            Console.WriteLine("Пароль стойкий");
                        else
                            Console.WriteLine("Пароль не стойкий");

                        Password pass3 = new Password("1");
                        Console.WriteLine($"\nПроверка пароля на стойкость");
                        Console.WriteLine($"Пароль: {pass3.Pword}");
                        if (pass3)
                            Console.WriteLine("Пароль стойкий");
                        else
                            Console.WriteLine("Пароль не стойкий");

                        Console.WriteLine("\nПолучение среднего символа строки");
                        string str1 = "Hello, World";
                        string str2 = "Goodbye, World";
                        Console.WriteLine($"Строка: {str1}\nЕё средний символ: {str1.GetMediumChar()}");
                        Console.WriteLine($"Строка: {str2}\nЕё средний символ: {str2.GetMediumChar()}");

                        Console.WriteLine("\nПроверка допустимой длины");
                        Console.WriteLine($"Пароль: {pass1.Pword}");
                        Console.WriteLine(pass1.CorrectLength() ? "Длина допустима" : "Длина недопустима");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                    break;

                case 2:
                    try
                    {
                        Person[] people =
                        {
                            new Servant("Alex", "Smith", 20, "Marine", 2),
                            new Learner("Bob", "Johnson", 22, 3.5m, 2, "University"),
                            new Worker("Charlie", "Brown", 40, "Eltex", "Engineer"),
                            new Turner("David", "Wilson", 35, "Factory", "Turner", 10, "Hammer"),
                            new Student("Eve", "Davis", 19, 4.0m, 1, "College", "Computer Science", "Engineering"),
                            new PartTimeStudent("Frank", "Miller", 25, 3.8m, 3, "Institute", "Mathematics", "Science", 25),
                            new Programmer("Grace", "Lee", 28, "TechCorp", "Developer", "Java", 5)
                        };

                        Console.WriteLine($"Узнаем, кем является {people[6].Name}");
                        Console.WriteLine(people[6].GetRole());

                        foreach (var person in people)
                        {
                            Console.WriteLine(person.ToString());
                        }

                        Console.WriteLine(people[0].Equals(new Servant("Alex", "Smith", 20, "Navy", 1))
                            ? "\nПервый и второй солдаты равны"
                            : "\nПервый и второй солдаты не равны");

                        Console.WriteLine(people[0].Equals(new Servant("Alex", "Smith", 20, "Marine", 2))
                            ? "\nПервый и второй солдаты равны"
                            : "\nПервый и второй солдаты не равны");

                        Console.WriteLine($"\nХэш-код у {people[0].Name}:");
                        Console.WriteLine(people[0].GetHashCode());
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                    break;
            }
        }
    }
}
