[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/QXrtxkgT)

# Patterns & Standards : MVC 


![TelemetryMVC_Home](https://github.com/user-attachments/assets/fcccd0ce-f8b9-4dc6-a6b4-a039c879991d)

### Overview
TelemetryPortal_MVC is a web application designed for managing project and client data through CRUD (Create, Read, Update, Delete) operations. This application is built with clean architecture principles, focusing on modularity, scalability, and best practices in coding standards. It utilizes the repository pattern to streamline data access, ensuring efficient management of projects and clients.
For this project, I have been tasked with enchancing and improving the existing MVC application while paying specific attention to architectural patterns, coding principles, and design patterns.

### Key Features
#### Project Management: 
Create, view, edit, and delete projects.
#### Client Management: 
Manage client information associated with projects.
#### Clean Architecture: 
Ensures maintainability by separating concerns.
#### Repository Pattern: 
Implements both generic and specific repositories for flexible data handling.
### ASP.NET Core MVC: 
Built with ASP.NET Core MVC framework for a robust and flexible development environment.

### Functional Requirements
Data Access Operations: Implement repository classes for both Projects and Clients.
Repository Pattern: Transfer all data access operations from controllers to repository classes.
Controller Integration: Implement the use of repository classes in controllers.

### Non-Functional Requirements
Clean Code: Ensure adherence to coding standards and best practices.
Modularity: Maintain separation of concerns for easier maintenance and scalability.
Security: Ensure that no credentials are stored on GitHub.

### Project Structure
The application is organized into the following projects:

#### TelemetryPortal_MVC.Data: 
Handles the database context and migrations.
#### TelemetryPortal_MVC.Repositories:
Contains repository implementations, including the generic and specific repositories, namely client and project class repositories. Their interfaces are also included in this folder. 
#### TelemetryPortal_MVC.Models: 
Defines the data models used throughout the application.
#### TelemetryPortal_MVC.Web: 
The main web application, responsible for the user interface and controllers.

### Hosting the MVC Application
The Telemetry Management Portal Application has been published via Visual Studio and deployed to Azure.


![DeploymentImage](https://github.com/user-attachments/assets/427c92dc-1e7b-484a-ba80-beeb9c97798a)


### Future Enhancements
#### Unit Testing: 
Adding unit tests for repository and controller layers.
#### Role-Based Access Control: 
Implementing user roles to manage access levels within the application.
#### API Integration: 
Exposing data management functionalities through a RESTful API.

### Using the Application
#### Manage user roles and access:
New user should Register.
Then proceed to Account Comfirmation.
Existing users prooced to Login.

#### Manage Projects:
Navigate to the Projects section.
Create, view, edit, or delete projects as needed.

#### Manage Clients:
Navigate to the Clients section.
Manage client information associated with your projects.

### Resource Group
https://portal.azure.com/#@nwuac.onmicrosoft.com/resource/subscriptions/c4031aae-2e16-4167-8093-e8189511611b/resourceGroups/rgCMPG323Proj3/overview

### Deployed MVC Application
https://cmpg323telemetryportalmvc.azurewebsites.net/

### Havard Reference List
https://github.com/NeoMogale/CMPG323-Project-3--35407972/blob/main/Project%203%20Reference%20List.docx

