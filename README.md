# Doconnect (Backend)

Doconnect is a web application that allows students and professionals often lack a centralized, moderated platform where technical questions can be asked, answered, and verified for correctness
This repository contains the **ASP.NET Core backend API**, which handles authentication, database operations, and API endpoints.

------

## Features
- Built with **.NET 9 Web API**
- **Entity Framework Core** with SQL Server
- **JWT Authentication** for secure access
- RESTful API endpoints for patients, doctors, and appointments
- **Swagger/OpenAPI** for interactive API documentation

-------

##  Prerequisites
Make sure you have the following installed:
- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server)
- [Entity Framework Core Tools](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)

---

## Development Server
To run the backend locally:

```bash
# Navigate to project folder
cd DOCONNECT-BACKEND.Api

# Restore dependencies
dotnet restore

# Apply database migrations
dotnet ef database update

# Run the API
dotnet run
```

By default, the API will be available at:

- Swagger UI: **https://localhost:5001/swagger**  
- API base URL: **https://localhost:5001/api**

---

## Authentication
- Uses **JWT Bearer Tokens**
- Obtain a token from the `/api/auth/login` endpoint
- Include the token in API requests using:

--------

## Testing
Use:
- **Swagger UI** (built-in)
- [Postman](https://www.postman.com/) or [Insomnia](https://insomnia.rest/)

