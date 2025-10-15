using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Data {
    public class Person {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
       public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }
}
