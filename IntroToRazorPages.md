# Razor Pages

1) makes coding page focused scenarios easier and more productive 
2) routing, models, actionresult and tag helpers so on and so forth.

## points about the application

1) The Properties folder has the `launchSettings.json` file which tells you how to run the webapp, which portal will it be available on etc.

2) `wwwroot` folder - contains all static files, js, html , css and all. it will not have any c# code. all static files have to go here.

3) `appsettings.json` file contains all the secret keys or connections strings that connect to the database and so on, 3rd party dependencies/APIs that needed to be added. 

4) `appsettings.development.json` is for dev environment, so for diff environments you can make diff json files like `appsettings.production.json` . 

5) pipeline in the `Program.cs` file - pipeline tells you about how application should respond to a web request. 
pipeline is made of different types of middlewares like `UserRouting` , `RazorPages` , `StaticFiles` , `Authetication`, `Verification` middlewares. the response is sent back to the server. 
order of middlewares in the pipeline is very important. 
`Authentication` middleware should always come before authorising the user to do anything. so you just cant add it anywhere you wish/like. 

6) `tag helpers` 
Tag Helpers are a feature in ASP.NET Core MVC that enable you to dynamically modify HTML elements in your Razor views. They provide an easy way to work with HTML elements and generate dynamic content, making your code more readable and easier to maintain. Tag helpers are like server-side components that extend the HTML elements, making them more powerful and expressive.



## routing in razor pages

1) rotuing in asp.net razor pages maps urls to physical file on the disk/
2) razor pages needs a root folder. this is the `Pages` folder.
3) `Index.cshtml` is the default document.
4) routing has direct mapping of how the files are stored in the folder.

## Pages folder

1) plays a central role in organising and handling the views (UI) and pages like web pages or routes. 
2) razor pages are a combination of C# code and HTML allows you to handle HTTP request, process form submissions, interact with data models and generate dynamic content.
3) page razor file `.cshtml` : contains html and razor markup. They have the frontend code obviously.
    -> defines structure and layout of the page.
    -> `@page` makes it a razor page, indicates that this file handles request.
    -> `@model` binds the razor page to a page model/ class that will be present in the logic/ or the `.cs` file.
4) page model `cshtml.cs` : contains the C# code to handle request, data binding, data processing and other server-side logic. they contain the backend, logic.
    -> acts as a controller for the razor page.
    -> defining methods like `OnGet()` and `OnPost()` which are trigerred when different HTTP methods like `GET`, `POST` are used. `OnGet()` and `OnPost()` are handlers.
5) `Pages/Shared` folder typically contains shared components that can be used across different razor pages: 
    -> layouts `_Layout.cshtml`
    -> Partial views `_Header.cshtml`, `_Footer.cshtml`
    -> `_ViewStart.cshtml` : defines configuration or settings that apply to all razor pages in the application, such as specifying the default layout.
    -> `_ViewImports.cshtml` : used to import namespaces and tag helpers that can be used across all razor pages. Stores the common namespace, global declaration.
    -> `Error.cshtml` is used to show all the errors that you might face in production application.
    -> when a file starts with underscore, `_` then those pages are partial view or partial pages.
    they are being called inside some other pages. these files are inside the `shared` folder.

## basic flow of a razor page request 

1) a ruser requests a page like `/Index` 
2) the razor page `Index.cshtml` is processed on the server, and the associated Page Model `Index.cshtml.cs` handles the request.
3) the page model may interact with a database, perform logic or set properties like `UserName`.
4) the razor page renders the html, embedding the dynamic data (`@Model.UserName`), and sends the response the client.