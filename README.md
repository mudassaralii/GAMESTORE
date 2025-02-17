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
        after this the dll of the projecct (compiler version) is generated and placed inside bin -> Debug -> net9.0 
    ii. through command line
        >dotnet build

        or ctrl+shift+B and select dotnet build

9. Run the application 
    by [pressing F5] and select debugger (c#) -> default configuration

10. dotnet run (run application without debugging)

11. REST API
    An API helps client communicate what they want to the service so it can understand and fulfill the request.

    REpresentational State Transfer (A set of guiding principles that impose conditions on how an API should work)

12. Interact with REST API
        HTTP Methods
           C POST: create new resources
           R GET: retrieve the resources representation/ state
           U PUT: update an existing resource
           D DELETE: delete an existing resource

           (CRUD)

           GET    /games
           GET    /games/1
           POST   /games
           PUT    /games/1
           DELETE /games/1

13. To better interact with our API create a file with extension .http e.g. games.http
    install REST Client extension inside vs code

14. to execute the requests inside .http file 
    click on Send Request
    ctrl+alt+R

15. ctrl+shift+E to open solution explorer

16. to automatically close opening the browser, select launchBrowser=false insiode launchSettings.json file

17. Start Implementing API

    Data Transfer Objeccts: DTO are the objects that carries data between processes/applications, it encapsulates the data in a form that can be transmit across the applications/ within application.

    Create a new folder Dtos -> add new file (Record), from Solution Explorer, as records are immutables, meeans once their properties are set they cannot be changed



