# General Notes for GRIT
- GRIT is the side project to build a better CRM tool
- This will be an open sourced CRM tool built with ASP.NET Core 2.2
- This application is built and published on Azures. So, if you fork this project, build, then try to manipulate any information, you may get an error message stating you do not have access to the db. You will need to build your own local database if you are not part of the team working on this main branch, and change the connection string.


# GRIT Stands for?
GRIT stands for Growth, Relations, and Interactions Terminal. This tool is set to redefine what CRM tools are meant to be. Yes, this is a CRM tool, but it is built in the mindset of a user, and how that user is able to see/manipulate data.




# Technologies used:

Of course the big one is ASP.NET Core with MVC, I like using the most "up-to-date" frameworks out there. ASP.NET is a clean data driven framework, that makes it clear and clean to how to derive what data I want in each view. 

I am going with Entity Framework for my data. More specifically I am going the route of code-first writing for my data bases. For example, I create a model of which I want my data to look like for a view, I implement that DbSet into a DbContext, and scaffold out my database from the terminal using dotnet ef migrations add 'SomethingMigration' and dotnet ef database update. 

More information found through this site: https://docs.microsoft.com/en-us/ef/#pivot=entityfmwk

# The Idea of GRIT
This tool is to be a Customer Relationship Management (CRM) tool. There are a few CRM tools out there that are specialized in one fraction of the tool, either the contact/leads portion of CRM, the social media marketing, or the project management for employees and customers. This application is to combine all the outstanding components that make up a CRM tool, and house them under one tool: GRIT.
