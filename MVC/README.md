# MVC (Knockout.js And jQuery)

This project revolves around the usage of ASP.NET MVC with the tools used around it (e.g. jQeury).

Since MVC does not contain any builtin interactive tools to dynamically change the views after rendering the page initially,
This MVC project shows examples on how to use JS libraries like:

- jQuery for Ajax calls and simple UI manipulation
- Knockout.js for MVVM 
- Angular

## Note

- Too add JS libraries, use VS' "Client-Side libraries" to download into the wwwroot folder
- Too add their respect Typescipt defintion, add it in "packages.json". You'll have to search for it and add it manually or use NPM, VS will detect the changes to the package.json file and will download the packages on building the project