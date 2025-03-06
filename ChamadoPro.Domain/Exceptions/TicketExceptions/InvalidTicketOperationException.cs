namespace ChamadoPro.Domain.Exceptions.TicketExceptions
{
    public class InvalidTicketOperationException : DomainException
    {
        public InvalidTicketOperationException(string message) : base(message) { }
    }
}
