using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;

namespace solarLab1
{
    class Program
    {
        static InMemoryDatabase Db = new InMemoryDatabase();
        static void Main(string[] args)
        {
            int menuItem = -1;

            while (menuItem != 0)
            {
                Console.Clear();
                menuItem = Menu();
                switch (menuItem)
                {
                    case 1:
                        ShowTasks();
                        Console.ReadLine();
                        break;
                    case 2:
                        AddTask();
                        Console.ReadLine();
                        break;
                    case 3:
                        RemoveTask();
                        Console.ReadLine();
                        break;
                    case 4:
                        Changing();
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Слушай, ну так нельзя как бы.");
                        Console.ReadLine();
                        break;
                }
            }
        }
        public static void RemoveTask()
        {
            int choice;
            ShowTasks();
            Console.WriteLine("Какую задачу вы бы хотели удалить? ");
            choice = Convert.ToInt32(Console.ReadLine());
            Db.Remove(choice);
        }
        static void ShowTasks()
        {
            Console.WriteLine("Ваши задачи: ");
            foreach (Task el in Db.Get())
            {
                Console.WriteLine($"  Номер задачи: {el.NumOfTask}\n" +
                                  $"  Дата создания: {el.Created}\n" +
                                  $"  Задача: {el.Name}\n" +
                                  $"  Дата начала: {el.Start}\n" +
                                  $"  Дата конца: {el.End}\n");
            }
        }
        static Task AddTask()
        {
            Task firstTask = new Task();
            Console.WriteLine("Введите название задачи: ");
            firstTask.Name = Console.ReadLine();

            firstTask.Created = DateTime.Now;

            Console.WriteLine("Введите дату начала задачи.");
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            firstTask.Start = startDate;

            Console.WriteLine("Введите дату конца задачи.");
            DateTime finishDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            firstTask.End = finishDate;
            Db.Add(firstTask);

            return firstTask;
        }
        static int Menu()
        {
            int choice;
            Console.WriteLine("Главное меню.");
            Console.WriteLine("0. Выход из программы.");
            Console.WriteLine("1. Показать список дел.");
            Console.WriteLine("2. Добавить задачу.");
            Console.WriteLine("3. Удалить задачу.");
            Console.WriteLine("4. Изменить задачу.");
            Console.WriteLine();
            Console.WriteLine("Введите ваш выбор: ");
            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        public static void Changing()
        {
            int index;
            Console.WriteLine("Вы хотите изменить задачу?");
            ShowTasks();
            Console.WriteLine("Выберите задачу которую хотели бы изменить: ");
            index = Convert.ToInt32(Console.ReadLine());
            Task task = Db.GetId(index);

            Console.WriteLine("Введите название задачи: ");
            task.Name = Console.ReadLine();

            task.Created = DateTime.Now;

            Console.WriteLine("Введите дату начала задачи.");
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            task.Start = startDate;

            Console.WriteLine("Введите дату конца задачи.");
            DateTime finishDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            task.End = finishDate;
        }
    }
}
