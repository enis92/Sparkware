# Sparkware

#Prerequisites

Install .NET Framework 4.7.2 SDK.
Install the latest version of Visual Studio 2017.
Access to restore nuget packages from nuget.org.

#Launching the project
Firstly, to run the solution you need a Microsoft SQL Server database or a SQL Server Express LocalDB.
Publish included database project to a desired database.
Then, manually execute the script from "..\Sparkware\Sparkware\Sparkware.Database\dbo.User.data.sql" to insert some sample data.
Also, change the Entity Framework connection strings to the desired database from both "..\Sparkware\Sparkware\Sparkware.DAL\App.config" and "..\Sparkware\Sparkware\Sparkware\Web.config".

Make sure that the web project (Sparkware.csproj) is selected as a start project, and that the IIS Express port from the project settings is not taken.
Finally, press CTRL+F5 to launch the application.
