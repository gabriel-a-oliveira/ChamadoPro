namespace ChamadoPro.Domain.Exceptions.UserExceptions
{
    public class InvalidUserOperationException : DomainException
    {
        public InvalidUserOperationException(string message)
            : base(message) { }
    }
}
