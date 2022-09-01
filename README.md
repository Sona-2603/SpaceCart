# SpaceCart
## Description
Space Cart - Find everything in this space
## Setup
All needed preinstalled software:
- IIS Express
- MySql Server
- Microsoft Visual Studio 2019 or higher
- **ASP.NET and web development** under **Workloads** in VS Installer
- .NET Core 3.1 Runtime(LTS)

## Used frameworks and libraries:
- NET Core 3.1
- ASP NET Core 3.1
- Entity Framework Core 5.0.10

## Steps to follow:
- Open Visual Studio and click **Open a project or solution**
- Open the file **SpaceCart.sln** inside the project directory
- Open the file **appsettings.json** and replace **Default** with your SQL server       connection string
- Go to **Tools -> NuGet Package Manager -> Package Manager Console**
- Initiate database with command `update-database` in **Package Manager Console**
- Run the project by pressing **F5**
- To stop the project, press **shift+F5**
- Seed users can be found in file **./SpaceCart/Data/Seed.cs**
- admin routes **/admin/products, /admin/users**