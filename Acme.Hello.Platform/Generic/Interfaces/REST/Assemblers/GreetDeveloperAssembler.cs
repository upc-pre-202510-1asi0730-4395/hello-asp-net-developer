using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

namespace Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;

public static class GreetDeveloperAssembler
{
    public static GreetDeveloperResponse ToResponseFromEntity(Developer? developer)
    {
        if (developer == null || developer.IsAnyNameEmpty())
            return new GreetDeveloperResponse("Welcome Anonymous ASP.NET Developer");
        return new GreetDeveloperResponse(
            developer.Id,
            developer.GetFullName(),
            $"Congrats {developer.GetFullName()}! You are a great ASP.NET Developer!");
    }
}