//=================================================================
// Solution: Blazor_ToDo
//=================================================================
// Programmer: Maurice Antonio Kelly
// Description: A To Do App with undo, redo and database CRUD features.
// ASP.NET Core 5.0
// Date: 2021-07-07
// Stop: 23:00
//=================================================================

// A To Do App with undo, redo and database CRUD features. It has a core Blazor project that can be served by either Wasm_Host or Blazor_Server. The uses HttpClientFactory to get data from Web_Api.
// Todo: PageFeature => PageFeature

// Do_To with DB CRUD - Create, Read and Update with IsDone complete - Todo: Delete, and update style.

// Wasm served by Wasm_Host and Blazor_Server (Both Apps can run together using separate ports).

// Remove Lib_Shared_Host because I moved its content to Lib_Host_Service

// Todo: clean up this solution and share it on GitHub.
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