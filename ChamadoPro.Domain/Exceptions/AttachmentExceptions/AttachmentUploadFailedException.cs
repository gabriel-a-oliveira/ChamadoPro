namespace ChamadoPro.Domain.Exceptions.AttachmentExceptions
{
    public class AttachmentUploadFailedException : DomainException
    {
        public AttachmentUploadFailedException()
            : base("Attachment upload failed. Please try again.")
        { }

        public AttachmentUploadFailedException(string message)
            : base(message)
        { }

        public AttachmentUploadFailedException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
