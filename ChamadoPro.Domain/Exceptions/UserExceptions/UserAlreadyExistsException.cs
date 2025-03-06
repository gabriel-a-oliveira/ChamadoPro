namespace ChamadoPro.Domain.Exceptions.UserExceptions
{
    public class UserAlreadyExistsException : DomainException
    {
        public UserAlreadyExistsException(string email)
            : base($"The email {email} is already registered.") 
        { }
    }
}
