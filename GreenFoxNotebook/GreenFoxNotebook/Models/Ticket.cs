namespace GreenFoxNotebook.Models
{
    public class Ticket
    {
        public long? Id { get; set; }
        public string Reporter { get; set; }
        public string Manufacturer { get; set; }
        public long Serialnumber { get; set; }
        public string Description { get; set; }
        public string ReportedAt { get; set; }
    }
}
