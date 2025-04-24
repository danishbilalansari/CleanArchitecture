# Clean Architecture With CQRS (.NET)

This repository demonstrates a Clean Architecture implementation using **.NET**. The solution is designed to be modular, testable, and maintainable, adhering strictly to separation of concerns. It features a basic **Employee Management** module using **CQRS**, **AutoMapper**, and **Entity Framework Core**.


## Project Structure

<pre lang="text"><code>
CleanArchitecture/
├── CleanArchitecture.Application/
│   ├── Commands/
│   │   └── CreateEmployeeCommand.cs
│   ├── Handlers/
│   │   └── CreateEmployeeHandler.cs
│   ├── Mappers/
│   │   ├── EmployeeMapper.cs
│   │   └── EmployeeMappingProfile.cs
│   ├── Queries/
│   │   └── GetAllEmployeeQuery.cs
│   └── Responses/
│       └── EmployeeResponse.cs
│
├── CleanArchitecture.Domain/
│   ├── Entities/
│   │   └── Employee.cs
│   └── Repositories/
│       └── Base/
│           └── IEmployeeRepository.cs
│
├── CleanArchitecture.Infrastructure/
│   ├── Data/
│   │   └── EmployeeContext.cs
│   └── Repositories/
│       └── Base/
│           └── EmployeeRepository.cs
│
├── CleanArchitecture/ (Web Layer)
│   ├── Controllers/
│   │   └── EmployeeController.cs
│   ├── Program.cs
│   ├── Startup.cs
│   ├── appsettings.json
│   ├── appsettings.Development.json
│   └── CleanArchitecture.csproj
</code></pre>


## Layers Breakdown

### Application Layer
Located in `CleanArchitecture.Application/`

- **Commands** – Write operations (e.g., `CreateEmployeeCommand.cs`)
- **Handlers** – Processors for commands and queries
- **Queries** – Read operations (e.g., `GetAllEmployeeQuery.cs`)
- **Mappers** – AutoMapper profiles and DTO converters
- **Responses** – DTOs returned to the API consumer

### Domain Layer
Located in `CleanArchitecture.Domain/`

- **Entities** – Core business models like `Employee.cs`
- **Repositories** – Abstractions for data access (`IEmployeeRepository.cs`)

### Infrastructure Layer
Located in `CleanArchitecture.Infrastructure/`

- **Data** – EF Core `DbContext` (`EmployeeContext.cs`)
- **Repositories** – Concrete implementations of domain interfaces

### Web Layer (API)
Located in the root `CleanArchitecture/` project

- **Controllers** – API endpoints (`EmployeeController.cs`)
- **Program.cs** – Entry point for .NET application
- **Startup.cs** – Configures services, middleware, DI
- **Configuration** – `appsettings.json`, etc.

## Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download)
- SQL Server or any EF Core-compatible database

### Setup Instructions

```bash
# Clone the repository
git clone https://github.com/danishbilalansari/CleanArchitectureCQRSNet.git
cd CleanArchitecture

# Restore dependencies
dotnet restore

# Run the application
dotnet run --project CleanArchitecture

```

## Configuration

This project uses `appsettings.json` and `appsettings.Development.json` for environment-specific configuration.

### Connection String

Make sure to update your connection string in `appsettings.json` before running the application:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=CleanArchitectureDb;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
