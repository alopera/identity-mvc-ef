# identity-mvc-ef
implementación de identity para autorización en una aplicación mvc con entity framework


# install identy with owin

Let's start with installing the Microsoft.AspNet.Identity.Owin package. This package has a dependency on the Microsoft.AspNet.Identity.Core package as well as a number of OWIN related packages. Make sure that the Treehouse.FitnessFrog project is selected in the "Default project" drop down list and run the command:

Install-Package Microsoft.AspNet.Identity.Owin
Once that package and all of its dependencies have finished installing, then let's install the Microsoft.AspNet.Identity.EntityFramework package in order to support persisting user identity data to SQL Server.

Install-Package Microsoft.AspNet.Identity.EntityFramework
And then let's install the Microsoft.Owin.Host.SystemWeb package in order to support using OWIN with ASP.NET and Microsoft's IIS web server.

Install-Package Microsoft.Owin.Host.SystemWeb
Sometimes NuGet packages don't install the latest versions of dependent packages. Let's go ahead and update the dependencies to the latest versions.

Update-Package Microsoft.Owin.Security
Update-Package Microsoft.Owin.Security.Cookies
Update-Package Microsoft.Owin.Security.OAuth
Update-Package Newtonsoft.Json
Important Note: Don't update the versions of jQuery and Bootstrap that the web app is currently using (jQuery 2.2.4 and Bootstrap 3.0.0). Upgrading to newer versions of either of these libraries would break the web app's styles and datepicker control (https://bootstrap-datepicker.readthedocs.io/en/latest/).

We'll be adding Identity related code to the Treehouse.FitnessFrog.Shared project so we need to install some of the Identity packages there too.

Note: Before running any of the following commands, be sure that the Treehouse.FitnessFrog.Shared project is selected in the "Default project" drop down list.

Two packages need to be installed—the Microsoft.AspNet.Identity.Owin and Microsoft.AspNet.Identity.EntityFramework packages. Installing these packages will enable us to make the necessary changes to the Entity Framework related classes in the shared class library.

Install-Package Microsoft.AspNet.Identity.Owin
Install-Package Microsoft.AspNet.Identity.EntityFramework
And then let's update the dependent packages that were installed.

Update-Package Microsoft.Owin
Update-Package Microsoft.Owin.Security
Update-Package Microsoft.Owin.Security.Cookies
Update-Package Microsoft.Owin.Security.OAuth
Update-Package Newtonsoft.Json
Excellent! Now that we've installed the necessary NuGet packages, we're ready for the next step in the development process: adding user registration. Which is what we'll do in the next section.

NuGet Packages
Here's more information about the NuGet packages that we just installed.

Reading this information is optional and not necessary to continue to the next step in the course.

Microsoft.AspNet.Identity.Core

This package has the core interfaces for ASP.NET Identity
This package can be used to write an implementation for ASP.NET Identity that targets different persistence stores such as Azure Table Storage, NoSQL databases, etc.
Dependencies
None
Microsoft.AspNet.Identity.Owin

This package contains functionality that is used to plug in OWIN authentication with ASP.NET Identity in ASP.NET applications
This is used when you add login functionality to your application and call into OWIN Cookie Authentication middleware to generate a cookie
Dependencies
Microsoft.AspNet.Identity.Core
Microsoft.Owin.Security
Microsoft.Owin.Security.Cookies
Microsoft.Owin.Security.OAuth
Microsoft.AspNet.Identity.EntityFramework

This package has the Entity Framework implementation of ASP.NET Identity which will persist the ASP.NET Identity data and schema to SQL Server
Dependencies
EntityFramework
Microsoft.AspNet.Identity.Core
Microsoft.Owin.Host.SystemWeb

This package provides an OWIN implementation that can be used with ASP.NET applications hosted on Microsoft's IIS web server
Dependencies
Microsoft.Owin
Owin
