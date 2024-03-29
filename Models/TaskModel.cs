namespace ToDoTasks.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDone { get; set; }
        public int UserId { get; set; }
    }
}