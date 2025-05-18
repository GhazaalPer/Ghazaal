using Newtonsoft.Json;
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
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string? Name { get; set; }
        [JsonProperty("duedata")]
        public DateTime? DueData { get; set; }
        [JsonProperty("checked")]
        public bool Checked { get; set; }
        [JsonProperty("starred")]
        public bool Starred{ get; set; }
        //public TodoList? ListId {  get; set; }
        [JsonProperty("listid")]
        public int ListId { get; set; }


    }
}
