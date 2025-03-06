namespace ChamadoPro.Domain.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public Category Category { get; set; }
        public DateTime Date_created { get; set; }
        public DateTime Conclusion { get; set; }
        public User Id_User { get; set; }
        public User requester_user_id { get; set; }
        public User responsible_user_id { get; set; }
    }
}
