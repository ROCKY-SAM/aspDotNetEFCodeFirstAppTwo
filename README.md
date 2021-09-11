# aspDotNetEFCodeFirstAppTwo
ASP.NET Core Web API with EF Core Code-First Approach




## add-migration

## initialCreate

## update-database

## add-migration -context datacontext

## update-database -context datacontext

## Remove-Migration

## Script-Migration


#aspDotNetEFCodeFirstAppOne
##entityframework
    Microsoft.EntityFrameworkCore
    Microsoft SQL Server database provider for Entity Framework Core.
    Entity Framework Core Tools for the NuGet Package Manager Console in Visual Studio.

##From the Manage NuGet Packages dialog:

Right-click the project in Solution Explorer > Manage NuGet Packages
Set the Package source to "nuget.org"
Ensure the "Include prerelease" option is enabled
Enter "Swashbuckle.AspNetCore" in the search box
Select the latest "Swashbuckle.AspNetCore" package from the Browse tab and click Install

```
public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<TodoContext>(opt =>
        opt.UseInMemoryDatabase("TodoList"));
    services.AddControllers();

    // Register the Swagger generator, defining 1 or more Swagger documents
    services.AddSwaggerGen();
}
```
```
public void Configure(IApplicationBuilder app)
{
    // Enable middleware to serve generated Swagger as a JSON endpoint.
    app.UseSwagger();

    // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
    // specifying the Swagger JSON endpoint.
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });

    app.UseRouting();
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });
}
```
