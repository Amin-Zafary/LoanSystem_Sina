# LoanSystem_Full_2025

This scaffold includes a full Clean Architecture sample for the LoanSystem project.
- .NET 8, Razor Pages
- EF Core with SQL Server LocalDB (configured)
- AutoMapper, DTOs
- Generic repository, DbContext
- Simple Razor CRUD pages for FacilityGroup and Facility
- Basic Unit test template

## Quick start (LocalDB)
1. Ensure .NET 8 SDK and Visual Studio 2022 (Enterprise) installed.
2. Open the solution `LoanSystem.sln` in Visual Studio.
3. Restore packages: `dotnet restore`
4. Create the database and apply migrations:
   ```bash
   cd src/LoanSystem.Web
   dotnet tool install --global dotnet-ef
   dotnet ef migrations add InitialCreate --project ../LoanSystem.Infrastructure --startup-project .
   dotnet ef database update --project ../LoanSystem.Infrastructure --startup-project .
   ```
5. Run the web project:
   `dotnet run --project src/LoanSystem.Web`

