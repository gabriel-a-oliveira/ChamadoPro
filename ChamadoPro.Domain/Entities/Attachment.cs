namespace ChamadoPro.Domain.Entities
{
    public class Attachment
    {
        public int Id { get; set; }
        public Ticket Ticket { get; set; }
        public string Name { get; set; }
        public string File_Url { get; set; }
        public DateTime Date_created { get; set; }
    }
}
