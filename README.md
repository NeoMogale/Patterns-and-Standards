[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/QXrtxkgT)

## TelemetryPortal_MVC
![TelemetryMVC_Home](https://github.com/user-attachments/assets/cba3057d-bc36-4ae3-9108-20dd25cc5255)

TelemetryPortal_MVC is a web application designed for managing project and client data through CRUD (Create, Read, Update, Delete) operations. This application is built with clean architecture principles, focusing on modularity, scalability, and best practices in coding standards. It utilizes the repository pattern to streamline data access, ensuring efficient management of projects and clients.

### Key Features:
Project Management: Create, view, edit, and delete projects.
Client Management: Manage client information associated with projects.
Clean Architecture: Ensures maintainability by separating concerns.
Repository Pattern: Implements both generic and specific repositories for flexible data handling.
ASP.NET Core MVC: Built with ASP.NET Core MVC framework for a robust and flexible development environment.


### Getting Started - Prerequisites:

Before you begin, ensure you have the following installed:

.NET 8.0 SDK
SQL Server (for database management)
Visual Studio 2022 (for development and running the application)

### Installation and Setup
Clone your Repositoryfrom GitHub, by using git clone command.
Configure your Database: Update the appsettings.json file with your own SQL Server connection string.
Apply Migrations, using the following command to apply database migrations.
#### dotnet ef database update
Launch and Run your application using Visual Studio.

### Project Structure:
The application is organized into the following projects:

TelemetryPortal_MVC.Data: Handles the database context and migrations.
TelemetryPortal_MVC.Repositories: Contains repository implementations, including both generic and specific repositories.
TelemetryPortal_MVC.Models: Defines the data models used throughout the application.
TelemetryPortal_MVC.Web: The main web application, responsible for the user interface and controllers.

### Future Enhancements:

Unit Testing: Adding unit tests for repository and controller layers.
Role-Based Access Control: Implementing user roles to manage access levels within the application.
API Integration: Exposing data management functionalities through a RESTful API.
