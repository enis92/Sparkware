# Sparkware

#Prerequisites

1) Install .NET Framework 4.7.2 SDK.

2) Install the latest version of Visual Studio 2017.

3) Access to restore nuget packages from nuget.org.

#Launching the project

1) To run the application you need a Microsoft SQL Server database or a SQL Server Express LocalDB.

2) Publish included database project(Sparkware.Database.sqlproj) to a desired database.

3) Manually execute the script from "..\Sparkware\Sparkware\Sparkware.Database\dbo.User.data.sql" to insert some sample data.

4) Change the Entity Framework connection strings to the desired database from both "..\Sparkware\Sparkware\Sparkware.DAL\App.config" and "..\Sparkware\Sparkware\Sparkware\Web.config".

5) Make sure that the web project (Sparkware.csproj) is selected as a start project, and that the IIS Express port from the project settings is not taken.

6) Finally, press CTRL+F5 to launch the application.
