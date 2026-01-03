namespace EDSM.NET.Exceptions;

public class MissingAPIKeyException : Exception
{
    private const string DefaultMessage = "An API key is required to send this request.";
    
    public MissingAPIKeyException() : base(DefaultMessage) { }
    public MissingAPIKeyException(string message) : base(message) { }
}
