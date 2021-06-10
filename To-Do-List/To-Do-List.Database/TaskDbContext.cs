using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_Do_List.Database.Entities;

namespace To_Do_List.Database
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext() : base (@"Server=(localdb)\mssqllocaldb;Database=To-Do-List;Trusted_Connection=True")
        {

        }

        public DbSet<TaskEntity> Tasks { get; set; }
    }
}
