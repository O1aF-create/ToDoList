using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace ToDoList
{
    class InMemoryDatabase
    {
        private List<Task> Tasks;
        private int id = 1;

        public InMemoryDatabase()
        {
            Tasks = new List<Task>();
        }

        public void Add(Task t)
        {
            Tasks.Add(t);
            t.Number = id;
            id++;
        }
        public void Remove(int id)
        {
            Task quest = Tasks.Where(t => t.Number == id).FirstOrDefault();
            Tasks.Remove(quest);
        }
        public List<Task> Get()
        {
            return Tasks;
        }
        public Task GetId(int id)
        {
            Task quest = Tasks.Where(t => t.Number == id).Single();
            return quest;
        }
    }
}
