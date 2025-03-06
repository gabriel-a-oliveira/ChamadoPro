namespace ChamadoPro.Domain.Exceptions.TicketExceptions
{
    public class TicketNotFoundException : DomainException
    {
        public TicketNotFoundException(int ticketId)
            : base($"Ticket with ID {ticketId} not found.")
        { }
    }
}
