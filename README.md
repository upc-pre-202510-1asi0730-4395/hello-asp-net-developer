# hello-asp-net-developer

## Summary
An ASP.NET Core REST API application to illustrate the use of Minimal APIs.

## Features
The API supports both GET and POST requests to generate personalized greetings based on the provided first name and last name.
-**GET /greetings**: Returns a personalized greeting message.
-**POST /greetings**: Accepts a JSON payload with first name and last name, and returns a personalized greeting message.

## Dependencies
- NET 9 SDK
- Swashbuckle.AspNetCore (for API documentation)

## Getting Started
1. Clone the repository
   ```bash
   git clone <repository-url>
   cd hello-asp-net-developer 
   ```
2. Restore the dependencies
   ```bash
    dotnet restore
    ```
3. Run the application
    ```bash
   dotnet run
    ```
   

