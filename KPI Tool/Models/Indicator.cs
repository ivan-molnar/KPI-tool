namespace KPI_Tool.Models
{
    public class Indicator
    {
        public string Title { get; set; }
        public List<TaskDropZone> Zones { get; set; }
        public List<TaskDropItem> Items { get; set; }
        public int Id { get; set; }

        public double[] Data = new double[] { };
        public string[] Labels = new string[] { };

        public Indicator(string title, int id) { 
            this.Title = title; 
            this.Id = id;
            this.Zones = new List<TaskDropZone>();
            this.Items = new List<TaskDropItem>();
        }
    }
}
