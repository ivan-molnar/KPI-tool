namespace KPI_Tool.Models
{
    public class TaskDropItem
    {
        public string Name { get; set; }
        public string InZone { get; set; }
        public int Priority { get; set; }
        public int Id { get; set; }

        public TaskDropItem(string name, string inZone, int priority, int id)
        {
            Name = name;
            InZone = inZone;
            Priority = priority;
            Id = id;
        }
    }
}
