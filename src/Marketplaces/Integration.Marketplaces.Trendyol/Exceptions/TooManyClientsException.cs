namespace Integration.Marketplaces.Trendyol.Exceptions;
public class TooManyClientsException : Exception
{
    public TooManyClientsException(string message) : base(message)
    {
    }
}