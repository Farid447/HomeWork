namespace EF_Core.Exceptions;

public class ProductNotFoundException : Exception
{
    public ProductNotFoundException(string mess) : base(mess)
	{

	}
}
