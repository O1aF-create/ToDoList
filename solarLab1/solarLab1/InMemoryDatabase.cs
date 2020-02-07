using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace solarLab1
{
    class InMemoryDatabase
    {
        private List<Task> Tasks;
        private int numOfTask = 1;

        public InMemoryDatabase()
        {
            Tasks = new List<Task>();
        }

        public void Add(Task t)
        {
            Tasks.Add(t);
            t.NumOfTask = numOfTask;
            numOfTask++;
        }
        public void Remove(int id)
        {
            Task quest = Tasks.Where(t => t.NumOfTask == id).FirstOrDefault();
            Tasks.Remove(quest);
        }
        public List<Task> Get()
        {
            return Tasks;
        }
        public Task GetId(int id)
        {
            Task quest = Tasks.Where(t => t.NumOfTask == id).Single();
            return quest;
        }
    }
}
