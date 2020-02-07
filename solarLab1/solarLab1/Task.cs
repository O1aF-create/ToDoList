using System;
using System.Collections.Generic;
using System.Text;

namespace solarLab1
{
    /// <summary>
    /// Задача
    /// </summary>
    class Task
    {
        /// <summary>
        /// Номер задания
        /// </summary>
        public int NumOfTask { get; set; }
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
