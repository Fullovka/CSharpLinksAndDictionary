using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Создание списка объектов класса "Person"
        List<Person> people = new List<Person>();

        // Добавление объектов в список
        people.Add(new Person { Name = "John", Age = 25 });
        people.Add(new Person { Name = "Mary", Age = 30 });
        people.Add(new Person { Name = "Steve", Age = 35 });

        // Вставка объекта в список по индексу
        people.Insert(1, new Person { Name = "Alex", Age = 20 });

        // Удаление объекта из списка
        people.Remove(people[0]);

        // Удаление объекта из списка по индексу
        people.RemoveAt(1);

        // Проверка наличия объекта в списке
        bool isPersonInList = people.Contains(new Person { Name = "Mary", Age = 30 });

        // Поиск индекса объекта в списке
        int indexOfAlex = people.IndexOf(new Person { Name = "Alex", Age = 20 });

        // Поиск последнего индекта объекта в списке
        int lastIndexOfSteve = people.LastIndexOf(new Person { Name = "Steve", Age = 35 });

        // Создание словаря с целочисленным ключом и строковым значением (и его инициализация)
        Dictionary<int, string> dictionary = new Dictionary<int, string>()
        {
            { 1, "one" },
            { 2, "two" },
            { 3, "three" },
            { 4, "four" },
            { 5, "five" }
        };
        
        // Проверка наличия ключа в словаре
        bool isKeyInDictionary = dictionary.ContainsKey(2);

        // Получение значения по ключу из словаря
        string value = "";

        if (dictionary.TryGetValue(3, out value))
        {
            Console.WriteLine(value);
        }
    }
}
