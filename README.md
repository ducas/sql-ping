# sql-ping
A simple app that pings a SQL Server database

## Requirements

* A SQL server
* dotnet core

## Getting started

1. Clone the repository
1. Update the connection string in appsettings.json
1. Make any changes required to `Models\PingContext.cs` to ensure your model matches a database table
1. Run `dotnet restore`
1. Run `dotnet run`
1. Open http://localhost:5000
1. Click Start
