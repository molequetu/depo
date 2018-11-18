# depo
A physical space management system


# Register database, add and apply migrations for IdentityServer
-Add migrations
dotnet ef migrations add InitialIdentityServerConfigurationDbMigration -c ConfigurationDbContext -o Migrations/IdentityServer/ConfigurationDb
dotnet ef migrations add InitialIdentityServerPersistedGrantDbMigration -c PersistedGrantDbContext -o  Migrations/IdentityServer/PersistedGrantDb^
-Apply migrations for identity configuration and peristence data
dotnet ef database update -c ConfigurationDbContext
dotnet ef database update -c PersistedGrantDbContext


# Populate database with seed data
dotnet run /seed (ps)