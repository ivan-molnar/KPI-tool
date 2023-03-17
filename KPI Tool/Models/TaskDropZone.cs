namespace KPI_Tool.Models
{
    public class TaskDropZone
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public TaskDropZone(string name, string id)
        {
            Name = name;
            Id = id;
        }
    }
}
