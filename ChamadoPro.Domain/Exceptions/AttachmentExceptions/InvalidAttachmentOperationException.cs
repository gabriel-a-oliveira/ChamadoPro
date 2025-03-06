namespace ChamadoPro.Domain.Exceptions.AttachmentExceptions
{
    public class InvalidAttachmentOperationException : DomainException
    {
        public InvalidAttachmentOperationException(string message) : base(message) { }

    }
}
