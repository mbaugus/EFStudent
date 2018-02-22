using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFStudent
{
    public class DBContextFile : DbContext
    {
        public DBContextFile() : base(){}
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
    }
}
