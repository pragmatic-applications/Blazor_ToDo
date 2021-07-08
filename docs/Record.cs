//=================================================================
// Solution: Blazor_ToDo
//=================================================================
// Programmer: Maurice Antonio Kelly @MAKMaurice
// Description: A To Do App with undo, redo and database CRUD features.
// ASP.NET Core 5.0
// Date: 2021-07-08
// Stop: 20:00
//=================================================================

// Commit Message: Sort now has Id, Title and IsDone (Check)
// Todo: Tidy up, style and add features to this solution.

// A To Do App with undo, redo and database CRUD features. It has a core Blazor project that can be served by either Wasm_Host or Blazor_Server. The uses HttpClientFactory to get data from Web_Api.

// Do_To with DB CRUD - Create, Read, Update with IsDone and Delete is complete - update style.

// Lib_Shared - This project provides shared features that are used by the other projects of this solution.

// The solution has five projects.
// Wasm - The core Blazor project that has all the pages and application functionality.
// Wasm_Host - This is an ASP.NET Core App that serves the Wasm as a Blazor ASP.NET Core hosted App.
// Blazor_Server - This is a Blazor Server App that serves Wasm.
// Web_Api - This is an ASP.NET Core Web API that provides the data needed by the Blazor applications.

// Wasm served by Wasm_Host and Blazor_Server (Both Apps can run together using separate ports).

// Initial commit after cloaning to GitHub from Azure DevOps and solution rename from To_Do to Blazor_ToDo.

//==========================================================================
// Migrations S (2021-07-07)
//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
//
// DotNet CLI
// dotnet ef migrations add InitialMigration
// dotnet ef database update
//
// VS PMC - 2021-07-07
// ApplicationDbContext (Current App)
// Add-Migration ApplicationDbContext_Initial -Context ApplicationDbContext
// Update-Database -Context ApplicationDbContext
//
// ApplicationDbContext (Web_Api & Blazor_Server)
// Add-Migration ApplicationDbContext_Initial -Context ApplicationDbContext -OutputDir Database/Migrations/ApplicationDbContextMigrations
// Update-Database -Context ApplicationDbContext
//
//==========================================================================
//
// AeeDbContext (Web_Api & Blazor_Server)
// Add-Migration AeeDbContext_Initial -Context AeeDbContext -OutputDir AeeDomain/Migrations
// Update-Database -Context AeeDbContext
//
// ItemDbContext (Web_Api & Blazor_Server)
// Add-Migration ItemDbContext_Initial -Context ItemDbContext -OutputDir ItemDomain/Migrations
// Update-Database -Context ItemDbContext
//
// AppApiAuthorizationDbContext (Blazor_Wasm)
// Add-Migration AppApiAuthorizationDbContext_Initial -Context AppApiAuthorizationDbContext -OutputDir Database/Migrations/AppApiAuthorizationDbContextMigrations
// Update-Database -Context AppApiAuthorizationDbContext
//
// AuthDbContext (IS_AspNet_Identity)
// Add-Migration AuthDbContext_Initial -Context AuthDbContext -OutputDir Database/Migrations/AuthDbContextMigrations
// Update-Database -Context AuthDbContext
//
// Blazor_Server
// AppAuthDbContext
// AppAuthDbContext (Web_Api & Blazor_Server)
// Add-Migration AppAuthDbContext_Initial -Context AppAuthDbContext -OutputDir Database/Migrations
// Update-Database -Context AppAuthDbContext
//
//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// Migrations E
//==========================================================================


/*



//*/
