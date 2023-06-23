# Company_Management_System

Simple desktop program for managing small companies or institutions. It is recommended to use this system for learning purposes only
This project was developed using Visual Studio 2022 version 17.0.31912.275 and
C# NET Framework Winforms Connected with SQL Server, and the MVP (Model - View - Presenter) design pattern was implemented.

## How to use :

### •	First call the Guna and Bunifu tools for Visual Studio, you need to follow the steps below:

1.	Go to the UI Controls folder in the project directory, then go to the Guna UI folder and unzip the files. Do the same for the Bunifu UI folder.

2.	Open Visual Studio, right-click on General in the Toolbox menu, and select Choose Items.


3.	A window will appear, click on the Browser button and select the dll files that are inside the files you extracted in the previous step.

### •	Secondly, you need to install the FontAwesome libraries as follows:

In Visual Studio, go to the Tools menu and select Nuget Package Manager. Then select Manage Nuget Packages for Solution. A list of packages will appear, search for the following two packages and install them:

1.	FontAwesome 4.7.0
2.	FontAwesome.Sharp 6.1.1.

### •	Third, create the database, you need to execute the Script:
After creating the database by script.sql in project files, open the project and go to the Solution Explorer menu. Right-click on the project name and select Properties. The properties window will appear. From the properties window, go to the Settings tab and in the ServicesName field, enter the name of your server.

Note: If you change the name of the database, you need to update it in the place where you changed the name of your server. In the DBname field, enter the new name.


## •Note 
when run program and show login window  the username "admin"  password "123"
