# Console App - "Reading AppSettings.json" (In a non-ASP.NET Core project)

This is project is to purely show to add appsettings.json file in any .NET Core project.
The steps for adding this featuire was taken from this link (added mhtml in this project):
https://www.adamrussell.com/appsettings-json-in-a-net-core-console-application/

## Summorize steps

 - Adding the following Nuget Packages (Use Package Manager to download these)
  - `Install-Package Microsoft.Extensions.Configuration.Json -Version 5.0.0`
  - `Install-Package Microsoft.Extensions.Options.ConfigurationExtensions -Version 5.0.0`
 - Add you appsettings.json file
 - in the file properties, make sure "Copy to output directory" is set to "copy if newer" or "copy always"
 - Create the `AppSettings` class along with the sub-classes
 - Do the following in as done in the "programs" CS file