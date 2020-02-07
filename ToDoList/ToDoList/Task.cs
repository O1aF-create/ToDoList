using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    /// <summary>
    /// Задача
    /// </summary>
    class Task
    {
        /// <summary>
        /// Номер задания
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Время начала
        /// </summary>
        public DateTime Start { get; set; }

        /// <summary>
        /// Время конца
        /// </summary>
        public DateTime End { get; set; }


    }
}
