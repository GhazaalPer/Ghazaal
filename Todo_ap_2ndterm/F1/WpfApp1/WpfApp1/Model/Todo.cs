using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1List.Model;

namespace WpfApp1Todo.Model
{
    public class Todo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? DueData { get; set; }
        public bool Checked { get; set; }
        public bool Starred{ get; set; }
        //public TodoList? ListId {  get; set; }
        public int ListId { get; set; }


    }
}
