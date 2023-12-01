# Study Tracker: POE Part 3

## Table of Contents
1. [Changes made]
2. [Info about the project](#general-info)
3. [UML Diagram](#UML)
4. [Software Used](#software)
5. [Installation Instructions](#installation-instructions)
6. [Code Attribution and References](#code-attributions) 
***


# Changes made from part 2
## 1. Web application
   This will allow the user to log in using their username and password on a browser. They no longer need to install the software onto their device.
## 2. Data persistence
   Data will be stored in a SQL database, passwords use Hash encryption for added security.
## 3. Calculation of hours
   Formula was improved to address part 1 feedback
   
### General Info
This project can be used to track study sessions for modules taken during a semester. It tracks the Module Name, Module Code, and Module Credits, as well as the hours studied for each module on specific days, and how many hours of study is left to do based on the time spent in class and out of class.
This project makes use of WPF, LINQ and a Class Library.

### UML

[ST10029788_prog6212_poe.pdf](https://github.com/IIEWFL/prog6212-part-2-ST10029788/files/13248918/ST10029788_prog6212_poe.pdf)


### Software
* Microsoft Visual Studio 2022 was used, as well as Microsoft SQL Server Management Studio.
### Installation Instructions
* If needed, Microsoft Visual Studio and SSMS must first be downloaded in order to run the program.

A. **Download Links**
* Net Framework 4.7.2 - https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net472-web-installer
* Microsoft Visual Studio 2022 - https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false

B. **To run the program WITHOUT Microsoft Visual Studio:**
* _Download Net Framework._
* _Download the files._
* _Double click on the folder titled "https://github.com/IIEWFL/prog6212-poe-ST10029788.git"._
* _Double click on the folder titled "bin"._
* _Double click on the folder titled "Debug"._
* _Run the .exe file_
* This is an executable file that will run the code - certain antiviruses and blockers will not allow the code to be run.

C. **Clone Repository from GitHub onto Visual Studio**
*The Recipe application is stored on GitHub. The following URL will allow you to access the code and clone it to a local machine. Image-guided steps are given to help faciltate this process. 


 1. Copy the following URL:
https://github.com/IIEWFL/prog6212-poe-ST10029788.git
 2. Open Visual Studio
 3. Navigate to the left of the Start screen, under the Get Started tab
![1  Get Started Tab](https://user-images.githubusercontent.com/103359783/235125843-df242d26-a47f-4128-b204-687c461a258b.png)
 4. Click on the first option, Clone Repository
![2  Clone Repo](https://user-images.githubusercontent.com/103359783/235126097-ad757fe7-7843-4b8d-862c-fdd8d7314995.png)
 5. The next screen should be displayed as follows:
![3  Repo Screen](https://user-images.githubusercontent.com/103359783/235126560-0f0ccdc5-32c1-41f6-b2c6-bbfbf9da7f84.png)
 6. Paste the URL Link under the unfilled section
![5  Repo Location Filled](https://user-images.githubusercontent.com/103359783/235128779-50f86f58-b57b-4967-93c2-c56fd9ad07eb.png)
 7. Click Clone on the bottom right of the screen
![6  Clone](https://user-images.githubusercontent.com/103359783/235129060-b2fc506f-0429-4bff-a767-4c1d40c51e5d.png)

D. **To run the program WITH Microsoft Visual Studio installed, follow these steps:**
* _Download Microsoft Visual Studio Using the above link._
* _Download the files onto your desktop._
* _Double click on the folder titled "https://github.com/IIEWFL/prog6212-poe-ST10029788.git"._
* _Double click on the Visual Studio Solution file named "https://github.com/IIEWFL/prog6212-poe-ST10029788.git.sln"._
* _After the program has finished loading, press on the green play symbol with the words "Start" written next to it._
Download all the files from the folder to make sure the program executes, as the Calcultions and Module information is in a separate class library_

E. Run the SQL script to create the database
***


## Reference list

adegeo (2023). DataGrid - WPF .NET Framework. [online] Microsoft.com. Available at: https://learn.microsoft.com/en-us/dotnet/desktop/wpf/controls/datagrid?view=netframeworkdesktop-4.8 [Accessed 21 Sep. 2023].

GeeksforGeeks. (2022). Creating and Using DLL Class Library in C. [online] Available at: https://www.geeksforgeeks.org/creating-and-using-dll-class-library-in-c/ [Accessed 22 Sep. 2023].

Luiz Gustavo Maia (2017). MSBUILD throws error: The SDK ‘Microsoft.NET.Sdk’ specified could not be found. [online] Stack Overflow. Available at: https://stackoverflow.com/questions/46257393/msbuild-throws-error-the-sdk-microsoft-net-sdk-specified-could-not-be-found [Accessed 22 Sep. 2023].

Nyakundi, H. (2021). How to Write a Good README File for Your GitHub Project. [online] freeCodeCamp.org. Available at: https://www.freecodecamp.org/news/how-to-write-a-good-readme-file/ [Accessed 22 Sep. 2023].

Thomas (2011). WPF rounded corner textbox. [online] Stack Overflow. Available at: https://stackoverflow.com/questions/4779777/wpf-rounded-corner-textbox [Accessed 22 Sep. 2023].

https://www.c-sharpcorner.com/UploadFile/61b832/creating-class-library-in-visual-C-Sharp/

https://www.tutorialsteacher.com/linq/what-is-linqhttps://www.c-sharpcorner.com/UploadFile/raj1979/showdeleteedit-data-in-wpf-datagrid-using-linq-to-sql-classes/

https://stackoverflow.com/questions/11878217/add-items-to-combobox-in-wpf

https://www.c-sharpcorner.com/article/c-sharp-list/

https://www.w3schools.com/html/html_links.asp

https://www.aspsnippets.com/Articles/ASPNet-Core-Razor-Pages-Display-JavaScript-Alert-Message-Box.aspx

https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-7.0

