namespace ChamadoPro.Domain.Exceptions.UserExceptions
{
    public class UserNotFoundException : DomainException
    {
        public UserNotFoundException(int userId)
            : base($"User with ID {userId} not found.")
        { }
    }
}
