using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

namespace Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;

public static class DeveloperAssembler
{
    public static Developer? ToEntityFromRequest(GreetDeveloperRequest? request)
    {
        if (request == null ||
            string.IsNullOrWhiteSpace(request.FirstName) ||
            string.IsNullOrWhiteSpace(request.LastName)) 
            return null;
        return new Developer(request.FirstName, request.LastName);
    }
}