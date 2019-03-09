# Home Care Medical Technical Test for Web Developer role:

 

## Technology

- ASP.NET MVC
- C#
- SQL Server

## Database
Create a SQL Server database containing a table to hold basic personal details including first name, middle name, surname and date of birth.

## Webpages
Each page in the website will contain a heading at the top to the page called 'Personal Database' and a footer at the bottom of the page containing a copyright symbol and the current year.

### First page (display and search)
Create a webpage that will initially display a table of all people in the database and a search box to search the database for a given name.
This page also needs to contain a link to an ‘add person to database’ page.
The data to always display in the table will be first name, surname and age (in years). The table must display a header and footer.
The footer should display the count of records currently displayed.
If there are no records to display, the table will not show and a message will be displayed stating that there are no records.
Entering text into the search box and clicking 'find' will filter the table to display only those records where the first name or surname start with the search text.
If there are no records matching the search criteria the table will not show and a message will be displayed stating that there are no records matching the search criteria.

### Second page (insert)
Create a webpage which enables records to be added to the database.
This page will ask for first name, middle name, surname and date of birth.
The name of this page is 'Add person to database'

Clicking 'Add' will insert the new person into the database with the input details however the following validation rules must be met:
* duplicate individuals are not permitted in the database (i.e. same first name, middle name and surname)
* nobody under the age of 16 can be inserted into the database
* first name, middle name and surname can ~~only contain alphabetic characters, spaces or hyphens~~ contain alphabetic charaters with space and hyphens in between words like abc-xyz, abc xyz, abc xyz-pqr.

A feedback message will be displayed showing the result of clicking the 'add' button.

Page Style
The web pages, tables and inputs can have any visual style you see fit.

 

 
 ##Finished Project 
###First Page Display
![image](https://user-images.githubusercontent.com/9668906/54071610-c3adf100-42d3-11e9-8b2b-98c3ec9a01bf.png)
### First Page Search
![image](https://user-images.githubusercontent.com/9668906/54071628-0c65aa00-42d4-11e9-8847-541277be3671.png)
