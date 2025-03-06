namespace ChamadoPro.Domain.Exceptions.AttachmentExceptions
{
    public class AttachmentNotFoundException : DomainException
    {
        public AttachmentNotFoundException(int attachmentId) 
            : base($"Attachment with ID {attachmentId} was not found.") 
        { }
    }
}
