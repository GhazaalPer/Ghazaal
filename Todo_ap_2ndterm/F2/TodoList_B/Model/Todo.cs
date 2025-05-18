using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TodoList_B.Model
{
    public class Todo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? DueData { get; set; }
        public bool Checked { get; set; }
        public bool Starred { get; set; }
        public int ListId { get; set; }

    }
}
