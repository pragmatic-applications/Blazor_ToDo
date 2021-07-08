# Blazor_ToDo

A Blazor ToDo App that has undo, redo and full CRUD to save to a database (Uses Sqlite but this can be changed to MSSQL Server or any DB service).

It has a core Blazor project that can be served by either Wasm_Host or Blazor_Server. The uses HttpClientFactory to get data from Web_Api.

An ASP.NET Core Web API is used to serve the data. It delegates the CRUD to a single entry point, a UnitOfWork interface that is implemented by a generic repository. 
The Blazor Wep App uses typed HttpClient to gain access to the API.

The solution has five projects.
- Lib_Shared - This project provides shared features that are used by the other projects of this solution.
- Wasm - The core Blazor project that has all the pages and application functionality.
- Wasm_Host - This is an ASP.NET Core App that serves the Wasm as a Blazor ASP.NET Core hosted App.
- Blazor_Server - This is a Blazor Server App that serves Wasm.
- Web_Api - This is an ASP.NET Core Web API that provides the data needed by the Blazor applications.

Home Page
<p><img src="./docs/Images/01.png" alt="ToEditToAltInfo" width="600" border="0" /></p>

Side Navigation Open
<p><img src="./docs/Images/02.png" alt="ToEditToAltInfo" width="600" border="0" /></p>

Select List to Sort
<p><img src="./docs/Images/03.png" alt="ToEditToAltInfo" width="600" border="0" /></p>

Search Field Active
<p><img src="./docs/Images/04.png" alt="ToEditToAltInfo" width="600" border="0" /></p>

Admin Page
<p><img src="./docs/Images/05.png" alt="ToEditToAltInfo" width="600" border="0" /></p>

Admin Create Page
<p><img src="./docs/Images/06.png" alt="ToEditToAltInfo" width="600" border="0" /></p>

Admin Create Page with an entry in the form field
<p><img src="./docs/Images/07.png" alt="ToEditToAltInfo" width="600" border="0" /></p>

Admin Create Page with a couple entries added. This now causes the Undo button to become enabled and with an entry selected the Remove button become enabled.
<p><img src="./docs/Images/08.png" alt="ToEditToAltInfo" width="600" border="0" /></p>

Admin Create Page with a couple entries added. This now causes the Undo button to become enabled and with an entry selected the Remove button become enabled. More entry added and checked.
<p><img src="./docs/Images/09.png" alt="ToEditToAltInfo" width="600" border="0" /></p>

Admin Create Page with a couple entries added. This now causes the Undo button to become enabled and with an entry selected the Remove button become enabled. Undo removes the last entry causing the Redo button to become enabled.
<p><img src="./docs/Images/10.png" alt="ToEditToAltInfo" width="600" border="0" /></p>

Admin Create Page with a couple entries added. This now causes the Undo button to become enabled and with an entry selected the Remove button become enabled. Redo brings back the entry that was removed by Undo which now again disables Undo.
<p><img src="./docs/Images/11.png" alt="ToEditToAltInfo" width="600" border="0" /></p>

Admin Create Page with a couple entries added. This now causes the Undo button to become enabled and with an entry selected the Remove button become enabled. Save adds the list from the Create page. Depending on the sort order and where each entry is located in the saved list, it may be necessary to page through the list to see added entries or the entry can be found by the search field at the top-right of the page.
<p><img src="./docs/Images/12.png" alt="ToEditToAltInfo" width="600" border="0" /></p>

Admin Detail Page showing entry with Id 14
<p><img src="./docs/Images/13.png" alt="ToEditToAltInfo" width="600" border="0" /></p>

Admin Update Page showing entry with Id 14 
<p><img src="./docs/Images/14.png" alt="ToEditToAltInfo" width="600" border="0" /></p>

Admin Update Page with entry edited to Entry Changed and Done checked. This immediately updates the view to show the change. The immediate view update only happens if Done is checked but Save must be clicked to apply the changes (Done checked and or edited entry).
<p><img src="./docs/Images/15.png" alt="ToEditToAltInfo" width="600" border="0" /></p>

Admin Page showing the edited entry with Id 14.
<p><img src="./docs/Images/16.png" alt="ToEditToAltInfo" width="600" border="0" /></p>

Admin Delete Page showing entry with Id 11.
<p><img src="./docs/Images/17.png" alt="ToEditToAltInfo" width="600" border="0" /></p>

Admin Page showing that entry with Id 11 has been removed. If a search or paging is done to try finding the removed entry, the removed entry will not be found.
<p><img src="./docs/Images/18.png" alt="ToEditToAltInfo" width="600" border="0" /></p>

Admin Page showing entries sorted by descending order.
<p><img src="./docs/Images/19.png" alt="ToEditToAltInfo" width="600" border="0" /></p>



### TODO:
Guide users through getting the code up and running. 
Things to do:
1.	Setup process
2.	Software dependencies
3.	Latest releases
4.	API references

### TODO:
Learn more about creating good readme files here: [guidelines](https://docs.microsoft.com/en-us/azure/devops/repos/git/create-a-readme?view=azure-devops). 

I should also seek inspiration from the below readme files:
- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)
- [Chakra Core](https://github.com/Microsoft/ChakraCore)
