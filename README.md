<h1>Library Lending System</h1>

<a>A C# WinForms desktop application for managing library members, books, and lending records.
The Library Lending System allows staff to manage:

Members (create, update, delete, search)
Books (track title, author, ISBN, total copies, available copies)
Loans (borrow/return books, track due dates)

The system stores all data in a SQL Server relational database, utilizing tables with primary keys and defined relationships.</a>

<a>To open this project in Visual Studio, press the Code button and click Launch in Visual Studio or download the code<br><br>
To use the database file, do the following
<br>Download the LibraryDB.bacpac separately
<br>Go to SQL Server
<br>Right-click Databases
<br>Import Data-tier Application
<br>Select the LibraryDB.bacpac<br>
<br>Notice: Change the database location string based on your SQL Server in app.config</a>

<a>To use the Member section:

Enter at a name, phone number(optional), and email(optional)
Click the Add Member Button

You can update the members on file by clicking on their name
changing the information
then clicking 'Update.'

If you click a member's name and then the delete button
It will prompt you to confirm, and if you click 'yes', it will delete the member.</a>

<a>To use the Book section:

Enter a Title, Author, ISBN, and the total number of books
Click the Add Book Button

You can update the Book on file by clicking on the Title
changing the information
then clicking 'Update.'

If you click a Book Title and then the delete button
It will prompt you to confirm, and if you click 'yes', it will delete the Book.</a>

<a>To use the Loan section:

Select a name and book
Choose a loan date
Choose a due date
Click the Loan Button


If you click a member's name and then the Return button
It will prompt you to confirm, and if you click 'yes', it will return the Book.



