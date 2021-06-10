using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List.Database.Entities
{
    class TaskEntity
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DayOfPerformance { get; set; }
        public bool isDone { get; set; }
    }
}
