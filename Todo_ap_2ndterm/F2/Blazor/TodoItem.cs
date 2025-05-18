namespace BlazorSample;

public class TodoItem
{
    public int Id { get; set; }
 public string? Name { get; set; }
 public string? DueData { get; set; }
 public bool Checked { get; set; }
 public bool Starred{ get; set; }
 //public TodoList? ListId {  get; set; }
 public int ListId { get; set; }
}







// using System.ComponentModel.DataAnnotations;

// namespace Blazor.TodoModels;

// public class TodoModel
// {
//     public int Id { get; set; }
//     public string? Name { get; set; }
//      public string? DueData { get; set; }
//      public bool Checked { get; set; }
//      public bool Starred{ get; set; }
//      //public TodoList? ListId {  get; set; }
//      public int ListId { get; set; }


// }

