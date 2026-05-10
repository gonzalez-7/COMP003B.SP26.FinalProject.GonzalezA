Barber Shop Appointment System
Project Purpose: This website is for managing a barber shop. 
It lets the user keep track of customers, barbers, services,
appointments and payments.

Functionality:
- Add, view, edit, and delete customers
- Add, view, edit, and delete barbers
- Add, view, edit, and delete barber services
- Add, view, edit, and delete appointments
- Add, view, edit, and delete payments
- Test barber services with Swagger

Key Dependencies:
- ASP.NET Core MVC
- Entity Framework Core
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- .NET 10

Setup Instructions:
1. Open the project in Visual Studio.
2. Make sure the required NuGet packages are installed.
3. Add the connection string in secrets.json.
5. Run the project.
6. Use the navigation links to test the MVC pages.
7. Go to /swagger to test the API.

Design Inspiration:

The design uses the default ASP.NET Core MVC layout. I dint made any major changes in the design of the page

Feature Descriptions:

The project includes five main sections: 
Customers, Barbers, Services, Appointments, and Payments. 
Each section has CRUD pages. 
The project also includes a Web API for barber services, 
Swagger testing, reusable partial views, and custom request timing middleware.