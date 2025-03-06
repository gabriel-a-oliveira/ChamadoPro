using ChamadoPro.Domain.Enums;

namespace ChamadoPro.Domain.Exceptions.UserExceptions
{
    public class InvalidUserStatusException :  DomainException
    {
        public InvalidUserStatusException(Status status)
            : base($"Action not allowed. User has no status: {status}.") 
        { }
    }
}
