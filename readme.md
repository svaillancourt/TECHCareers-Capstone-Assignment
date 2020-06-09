![banner](https://github.com/svaillancourt/TECHCareers-Capstone-Assignment/blob/master/Booze-pedia/Booze-pedia/wwwroot/img/banner.jpg)

# Project Title: BoozePedia

### Group Name: Delivery-Focused

Students Involved: [Stephane](http://github.com/svaillancourt), [Soham](http://github.com/sohampatelk), [Marvin](http://github.com/MarvRoldan), [Karan](http://github.com/KaranPandher)

Resources: [GitHub](https://github.com/svaillancourt/TECHCareers-Capstone-Assignment) | [Trello](https://trello.com/b/MdkAHVEd/delivery-focused) | [Google Drive](https://drive.google.com/drive/folders/1qXbzhE4FHtSnGMNoGACNNct19g7GrCTs?usp=sharing) | Wireframes: [Desktop](https://drive.google.com/file/d/1UmdGpzQzBbiEvVv2DdXmY4wOgfS_y9lx/view?usp=sharing) | [Mobile](https://drive.google.com/file/d/1TwnjqiPZsnNKU6ZfRq8WkeyB94HoKwlP/view?usp=sharing)

Communication Platform: [Discord](https://discord.com/)

### Problem Statement

[Client](https://happy-hour-liquor.myshopify.com/) recently converted there store for online sales. They stated they had 4 platforms that they were getting sales from; Drizzly, SkiptheDishes, there own online website and walk in orders. 

With the recent influx due to COVID-19 there was a big demand from there online orders. This resulted in disorganization and refusal of orders that were already placed. Client requested an inventory management system to be created that can help log live inventory. 

With this information they could update there stock on Drizzly and SkiptheDishes ultimately resulting in happier customers, organization and structure.


### Description of how the app solves the stated problem is included

As discussed above with minimum inventory management control and a big influx of orders [Happy Hour Liquor](https://happy-hour-liquor.myshopify.com/) was having trouble dealing with the intense. 

They were having trouble keeping up with sales and the workload altogether. They didn't have an appropriate way to manage inventory, added on top of there workload this was causing customer service issues. 

With a proper system in place that tracks there inventory, they can implement changes quickly and plan for inventory control ahead of time. They can also use this data to help them with future orders; predict how much inventory is needed for the next week. 


### Installation Guide:
    
Please be sure to have the following software installed prior.

- [Microsoft-Visual-Studio](https://visualstudio.microsoft.com/)
- Internet Browser of your choice. (Chrome, IE, Safari, Firefox)


### User manual for using application: 

Open a internet browser of your choice.

Please following instructions listed in our [Instruction Manual Doc](https://docs.google.com/document/d/1l7tFdRHui9e1BtYUHvEDM1YZK1_7VAyDhJdUelIFL8E/edit?usp=sharing)

### Citations 

#### Image source

* [Pixelbay](https://pixabay.com/)

#### Code : 
    
* [.Net Core MVC Tutorial](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/?view=aspnetcore-3.1)

* [Validation and constraints for user inputs](https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/adding-validation)

* [Integrating SQL with .Net Core](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/working-with-sql?view=aspnetcore-3.1&tabs=visual-studio)

* Identity: [Youtube](https://www.youtube.com/watch?v=CzRM-hOe35o) | [Microsoft Doc 1 ](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-3.1&tabs=visual-studio#pw) | [Microsoft Doc 1 ](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-2.2&tabs=visual-studio#scaffold-identity-into-an-mvc-project-without-existing-authorization) | [Stack Overflow](https://stackoverflow.com/questions/50179696/how-add-asp-net-core-identity-to-existing-core-mvc-project) 

* [HttpClient Class](https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netcore-3.1)

* [Sorting and Filtering](https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/sorting-filtering-and-paging-with-the-entity-framework-in-an-asp-net-mvc-application)

* [Search functionality](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/search?view=aspnetcore-3.1)

* Image upload and retrieval: [codaffection.com](http://www.codaffection.com/asp-net-core-article/asp-net-core-mvc-image-upload-and-retrieve/) | [c-sharpcorner.com](https://www.c-sharpcorner.com/article/upload-and-display-image-in-asp-net-core-3-1/)

* [Logo on Nav](https://stackoverflow.com/questions/29602413/how-to-add-logo-in-mvc-layout)

* [Using font awesome](https://stackoverflow.com/questions/57275813/font-awesome-icons-not-showing-up-in-asp-net-core-mvc-project)

* [Styling Razor pages](https://stackoverflow.com/questions/19494493/razor-syntax-in-style)


### Webpages Index

> #### Homepage:

- User login page. Should have an account set up to login in to the page to manage inventory. 
- Works as a fully functional login page with the ability to register and request a password reset. 

> #### Forgot Password

- Enter email to reset your password (not actively set up) 


> #### Register Account

   - Ability to create a new account with many account restrictions as expected but not limited too :
   - Email address must be valid including a valid email domain 
   - Passwords must match in the confirm box and regular box
   - Password must be atleast 6 and at max 100 characters long. 
   - Password must have atleast 1 non alphanumeric character. 
   - Password must have atleast one uppercase

#### User must enter a valid email and a password that aligns with our restrictions. 

- Username: john.doe@gmail.com 
- Password: @SillyGuy1

- Rejected User Information

- Username: john.doe@asdaadasdasdasdsdas.live 
- Password: thisismypassword


### Full-Stack Requirements

- [x] Create Persistent Records.
- [x] Must demonstrate at least one data constraint.
(Example: A user’s first name or last name cannot contain numbers)
- [x] Data constraint must be protected at every layer of the application.
- [x] Record must exist after user has logged out, cleared their browser cache, and returned to the website.
- [x] Read Records From Database.
- [x] Sample data or dummy data must be stored in the database.

#### One of the following may apply:

- [ ] You must include a .sql script with INSERT statements for your database. 
- [ ] (README must include instruction on how to run this script)
> OR
- [x] INSERT equivalent (using Entity / Identity Framework in .NET). 
- [ ] (README must include instructions for installation and setup as well).
- [x] Update Persistent Records In Database.
- [x] Updates must enforce the same data constraints that were mentioned in the create.
- [x] Record’s state must remain updated after user has logged out, cleared their browser cache, and returned to the website.
- [x] (This includes dummy data or any starting data your app has).
- [x] Delete Records in Database.
- [x] Must demonstrate the safe deletion of records.
- [x] Child records must never be orphaned.
- [x] No view may display any part of the deleted record, or any part of the deleted child records.
- [ ] Choosing to ‘archive’ records rather than delete them is acceptable only if: 
- [ ] Child records are also archived.
- [ ] User is presented with text stating that record was archived and not permanently deleted
- [x] Record must remain deleted after user has logged out, cleared their browser cache, and returned to the website

### Project Management Principles and Practices

- [x] Problem Definition must be included in README

#### Project Plan must include a Work Breakdown Structure

- [x] Work Breakdown Structure hosted on Trello
- [x] Each card in the completed column must have a Member attached to it so we can see who did what at a glance
- [x] Link to Trello must be included in README
- [x] Project Plan must include some form of wireframe (feel free to use MS Paint)
- [x] Include the final wireframe(s) in Trello as attachments on a card (don’t put this on git though, we want git reserved for the finished, polished project)

#### Testing Plan must include instructions on how to test each feature

- [x] Each test case must define the input, action and expected result for each test case
- [x] (Example: User with firstname == “B0b” cannot register, user with firstname == “Bob” can register, user with name == “B” can register)
- [ ] (Example: Hamburger nav is visible on phone-sized device, full sized nav is visible on tablet-sized device, full sized nav is visible on desktop sized device) (not required as our webpage nav bar is minimal)
- [x] List of test cases and testing instructions are included in README

#### Scope of the project must be well managed

- [x] Unfinished features must not be apparent on the web page (Delete non functional code)
- [x] Dead code must be deleted
- [ ] The problem that you defined in your problem statement must be solved
- [ ] Any features not related to the problem should be deprioritized or removed completely (Focus on solving one problem and solving it well)

#### Presentation must include the following talking points:

#### Final Project Report

- [ ] Did you complete all in-scope tasks?
- [ ] Did you complete any extra tasks?

#### Satisfaction Assessment

- [ ] Does your app solve your problem?
- [ ] Have you or someone else started using the app? What do they think of it so far?

#### Lessons Learned

- [ ] If you had to build another full-stack CRUD app what lessons would you apply that you have learned from this project.

### Technical Requirements

#### Data Validation must be done in each layer of the application

- [x] Webforms must not allow users to enter incorrect data
- [x] Webforms must display validation errors with tips on how to resolve the errors
- [x] Server layer must check all input values BEFORE processing or storing data
- [x] Database must not allow invalid data to be stored

#### Data Persistence

- [ ] All scripts to create the database and tables are included in the git repository
- [ ] All scripts to insert data are included in the git repository

#### Intuitive User Interface

- [x] Consistent navigation across all pages
- [x] Links don’t grow or shrink or run away from the mouse
- [x] Links are in the same place every time
- [ ] The link for the page we are currently on uses the :active pseudo class
- [x] Buttons do what they say they are going to do
- [x] Error messages explain how to fix the error
- [x] Web controls are used appropriately and consistently
- [ ] On-screen instructions - if necessary - are easy to understand (Add in final Build)

#### Mobile First

- [x] All content is legible on a small screen
- [x] Content is contained on the screen without horizontal scrolling
- [x] Buttons and forms all work on mobile
- [x] Buttons are not too close together
- [x] Form fields and labels are visible while typing with on-screen keyboard
- [x] All key features needed to solve your problem are available in mobile mode

#### Responsive

- [x] Uses media queries to manage different devices
- [x] Uses fluid units of measurement consistently
- [x] May use px measurements for min-width
- [x] All content is legible
- [x] Content is contained on the screen without horizontal scrolling
- [ ] All html pages have the appropriate meta tag for accessing the device’s width

#### Accessible

- [ ] Source code and website passes WCAG validator

#### W3C Compliance

- [ ] HTML passes W3C Validator
- [ ] CSS passes W3C Validator

#### Separation of Concerns

- [ ] Presentation layer contains only presentation code, and some data validation code to prevent users from entering erroneous data
- [ ] Business logic held in appropriate services, single-purpose principle is applied throughout the project.
- [ ] Data storage and data access layer does not contain any data transformations and reinforces data validation

####  Browser Console

- [x] No error messages when using application
- [x] No console log messages while using application
- [x] Does not reveal sensitive user information

#### Code is commented

- [x] Citations must include full urls for any code found, borrowed, modified, from the internet, from the class, or from any source other than yourself. If you borrow code from a book, provide the title of the book, the author(s), and the ISBN.
- [x] Citations must be duplicated in README.md
- [ ] Comments describe what methods are meant to do.
- [ ] Comments do not contain old/dead code.

#### Naming Conventions

- [x] Proper casing on file names
- [x] Proper casing on variables/functions/modules
- [x] Variables/functions/modules have descriptive names

####  General Good coding practices

- [ ] Look for blocks of code with more than a few lines of code that look similar. Is it possible to refactor to reduce duplication? DRY your code!
- [ ] Simplify “too smart” and over-engineered code.
- [ ] No hardcoded values, use constants values.
- [ ] User input is sanitized (escape characters, leading and trailing whitespace, and inappropriate values are removed)

#### Spelling and Grammar

- [x] Contents of each web page is spell-checked
- [x] Contents of each web page is grammar-checked
- [ ] Contents of README is spell-checked
- [ ] Contents of README is grammar-checked
- [ ] Use up-to-date language features (const and let instead of var, section instead of div, string interpolation instead of string concatenation, etc.)

### Design Requirements

#### Contrast

- [ ] Font colours must pass the Web AIM contrast checker
- [ ] Contrast does not cause eye strain (black on white, red on green, etc)
- [ ] Size contrasts are used correctly if size contrast is used at all
- [ ] (big buttons for important actions, small buttons for unimportant actions)

#### Alignment

- [ ] Content does not overflow from it’s boundaries
- [ ] Content appears organized and structured
- [ ] Text content is not center-aligned
- [ ] (exceptions permitted for poetry and wedding invitations)

#### Repetition

- [x] Navigation placement is consistent across the whole application
- [x] Button and link styles are consistent across the whole application
- [x] Button and link behaviour is consistent across the whole application
- [x] Text styles are consistent across the application

#### Proximity

- [x] Alike content items are grouped closer to one another
- [x] No content is crowded against other content or the edges of the browser
- [x] Controls are grouped together logically with their labels
- [x] Proper use of whitespace

### Deliverables

- [x] GitHub link
- [x] README.md

#### Name of project is included

- [x] List of contributors is included
- [x] Problem Statement is included
- [x] Description of how the app solves the stated problem is included
- [x] Instructions for installing application are complete
- [x] Instructions for using application are complete
- [x] List of all citations is complete
- [x] List of test cases and testing instructions are included
- [x] Link to public Trello board is included
- [x] Master branch contains all final code needed to run the project

### Presentation 

#### Final Project Report

- [ ] Did you complete all in-scope tasks?
- [ ] Did you complete any extra tasks?

#### Satisfaction Assessment

- [ ] Does your app solve your problem?
- [ ] Have you or someone else started using the app? What do they think of it so far?

#### Lessons Learned

- [ ] If you had to build another full-stack CRUD app what lessons would you apply that you have learned from this project.

#### Group Member Performance Review

- [ ] Each group member has been evaluated
- [ ] All fields filled out

#### Personal Reflection

- [ ] Written reflection
- [ ] Video reflection