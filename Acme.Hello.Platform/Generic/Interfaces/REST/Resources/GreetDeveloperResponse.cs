namespace Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

public record GreetDeveloperResponse(Guid? Id, string? FullName, string Message)
{
    public GreetDeveloperResponse(string Message) : this(null, null, Message)
    {
    }
}