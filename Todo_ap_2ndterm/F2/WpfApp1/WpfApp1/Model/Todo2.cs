using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.ViewModel;

namespace WpfApp1.Model
{
    public class Todo2
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? DueData { get; set; }
        public bool Checked { get; set; }
        public bool Starred { get; set; }
        //public TodoList? ListId {  get; set; }
        public string ListName { get; set; }
        public ObservableCollection<TodoItemViewModel> listname_s {  get; set; }


    }
}
