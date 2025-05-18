namespace TodoList_B.Model.Dto
{
    public class CreatTaskDto
    {
        public string? Name { get; set; }
        public DateTime? DueData { get; set; }
        public bool Checked { get; set; }
        public bool Starred { get; set; }
        public int ListId { get; set; }
    }
}
