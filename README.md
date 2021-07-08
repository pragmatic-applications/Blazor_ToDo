# Blazor_ToDo
A To Do App with undo, redo and database CRUD features. It has a core Blazor project that can be served by either Wasm_Host or Blazor_Server. The uses HttpClientFactory to get data from Web_Api.

# To Do (Blazor)
## 
A Blazor ToDo App that has undo, redo and full CRUD to save to a database (Uses Sqlite but this can be changed to MSSQL Server or any DB service.)
An ASP.NET Core Web API is used to serve the data. It delegates the CRUD to a single entry point, a UnitOfWork interface that is implemented by a generic repository. 
The Blazor Wep App uses typed HttpClient to gain access to the API.


==========================

 
<p><img src="./docs/images/ContactAPI_Home.png"
alt="Asp.Net Core MVC API Contact Form (Angular form UI and ASP.NET Core API form processing and email sending) Demo " width="400" height="300" border="10" /></p>


### This demo App uses Angular for the contact form and ASP.NET Core API to process the posted form and send an email.

Your will need to supply the required email/smtp data for this App to work.

Contact Page with Empty Form

<p><img src="./docs/images/ContactAPI_ContactForm_Empty.png"
alt="Asp.Net Core MVC API Contact Form (Angular form UI and ASP.NET Core API form processing and email sending) Demo " width="400" height="300" border="10" /></p>

Contact Page with Incomplete Form

<p><img src="./docs/images/ContactAPI_ContactForm_Incomplete.png"
alt="Asp.Net Core MVC API Contact Form (Angular form UI and ASP.NET Core API form processing and email sending) Demo " width="400" height="300" border="10" /></p>

Contact Page with Filled-in Valid Form

<p><img src="./docs/images/ContactAPI_ContactForm_FilledInValid.png"
alt="Asp.Net Core MVC API Contact Form (Angular form UI and ASP.NET Core API form processing and email sending) Demo " width="400" height="300" border="10" /></p>



Contact Thank You Page

<p><img src="./docs/images/ContactAPI_ContactThankYou.png"
alt="Asp.Net Core MVC API Contact Form (Angular form UI and ASP.NET Core API form processing and email sending) Demo " width="400" height="300" border="10" /></p>



==========================
# Getting Started
TODO: Guide users through getting your code up and running on their own system. In this section you can talk about:
1.	Installation process
2.	Software dependencies
3.	Latest releases
4.	API references

# Build and Test
TODO: Describe and show how to build your code and run the tests. 

# Contribute
TODO: Explain how other users and developers can contribute to make your code better. 

If you want to learn more about creating good readme files then refer the following [guidelines](https://docs.microsoft.com/en-us/azure/devops/repos/git/create-a-readme?view=azure-devops). You can also seek inspiration from the below readme files:
- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)
- [Chakra Core](https://github.com/Microsoft/ChakraCore)
