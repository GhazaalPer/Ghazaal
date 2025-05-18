namespace TodoList_B.Model.Dto
{
    public class GetTaskDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? DueData { get; set; }
        public bool Checked { get; set; }
        public bool Starred { get; set; }
        public int ListId { get; set; }
    }
}
