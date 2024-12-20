# CMPG323-Project-3-37460366

## Project Overview
This project is a Web Application designed to manage CRUD (Create, Read, Update, Delete) functionality for project and client data. 
The application is built using  ASP.NET Core MVC and follows best practices in software design patterns, such as the Repository pattern. 
The application is hosted on Azure and connected to an Azure SQL Database.

## Prerequisites
Before setting up the project, ensure that the following software and resources are installed and accessible:
- **Visual Studio 2022 Community Edition** with ASP.NET and .NET Core workloads.
- **.NET 8 SDK** installed on your local machine.
- **Azure Account** with access to the Azure tenant.
- **Azure SQL Database** set up and ready for connection.

## Setup Instructions

### 1. Clone the Repository
- First, clone the repository to your local machine
- Using Visual Studio 2022 Community Edition

### 2. Open the Project in Visual Studio
- Open Visual Studio 2022.
- Select File > Open > Project/Solution.
- Navigate to the cloned repository and select the .sln file to open the solution.

### 3. Configure the Database Connection
- Azure SQL Database: Ensure your Azure SQL Database is set up.
- Connection String: Add the appsettings.json file in the project with your Azure SQL Database connection string.

### 4. Run the Application Locally
**To run the application on your local machine:**

- Press F5 in Visual Studio or click on the Start button.
- The application will launch in your default web browser
### 5. Publish the Application to Azure
**To deploy the application to Azure:**

- Right-click on the project in Solution Explorer and select Publish.
- Choose Azure as the target, then select App Service.
- Configure the App Service details (Resource Group, App Name, etc.) and click Publish.
- After deployment, access your application using the Azure-provided URL

### 6. Using the Application
**Access the Application:** After deployment, you can access the application via the Azure URL.
**CRUD Operations:** The application allows you to Create new projects and clients.
- View and Read existing project and client data.
- Update project and client details.
- Delete projects and clients as necessary.


**Reference Documentation:**
- Microsoft Learn (2023) �Web API design best practices - Azure Architecture Center�. Available at: https://learn.microsoft.com/en-us/azure/architecture/best-practices/api-design (Accessed: 24 August 2024).
- Mitchell, A. (2024) �How to Design an API: An Expert Guide to Best Practices�, ExpertBeacon. Available at: https://expertbeacon.com/how-to-design-an-api-an-expert-guide-to-best-practices/ (Accessed: 24 August 2024).
- Toptal (2024) �Web API Design: 5 Best Practices to Know�. Available at: https://www.toptal.com/api-developers/5-golden-rules-for-designing-a-great-web-api (Accessed: 24 August 2024).
- Webflow (2024) �API development: The complete guide to development best practices�. Available at: https://webflow.com/blog/api-development (Accessed: 24 August 2024).
- Microsoft Learn (2023) �Logging in .NET Core and ASP.NET Core�. Available at: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/logging (Accessed: 24 August 2024).
- Microsoft Learn (2023) �Enable Cross-Origin Requests (CORS) in ASP.NET Core�. Available at: https://learn.microsoft.com/en-us/aspnet/core/security/cors (Accessed: 24 August 2024).
- Microsoft Learn (2023) �Health checks in ASP.NET Core�. Available at: https://learn.microsoft.com/en-us/aspnet/core/host-and-deploy/health-checks (Accessed: 24 August 2024).
- Microsoft Learn (2023) �ASP.NET Core fundamentals�. Available at: https://learn.microsoft.com/en-us/aspnet/core/fundamentals (Accessed: 24 August 2024).


**Contact Information**
For any issues or queries regarding the project, please contact: Alonemapitlula@gmail.com


[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/QXrtxkgT)
