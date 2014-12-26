using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoTask.Android
{
    public class TodoModel
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Create { get; set; }
        public int Status { get; set; }
    }
}
