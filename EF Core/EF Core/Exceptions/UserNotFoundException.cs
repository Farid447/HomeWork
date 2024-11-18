namespace EF_Core.Exceptions;

public class UserNotFoundException : Exception
{
    public UserNotFoundException(string mess) : base(mess)
    {
        
    }
}
