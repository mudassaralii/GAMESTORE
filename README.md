# GAMESTORE
ASP.net core
1. vs code extensions
.net install tool
c#
C# dev kit
intellicode for c# dev kit
REST Client
SQLite (alexcvzz)

2. Check Dotnet Status
>dotnet --version (to check dotnet version)
>dotnet --info

3. Create New Project
>dotnet new list (to list all the items of application that can be build, select ASP.NET Core empty) OR
ctrl+shift+p to open command pallete, and type .net:new it list the sameitems as above but little limited

4.appsettings.json (for production environment)
This file is used for configurations

5. appsettings.Development.json (for development environment) 

6. obj directory includes the intermediate files

7. bin directory includes the final files

8. Building asp dot net project in vs code
    i. Through solution nexplorer
        click on your project(here GameStore.API) and click Build
        after this the dll of the projecct (compiler version) is generated andd placed inside bin -> Debug -> net9.0 
    ii. through command line
        >dotnet build

        or ctrl+shift+B and select dotnet build

9. Run the application 
    by [pressing F5] and select debugger (c#) -> default configuration



