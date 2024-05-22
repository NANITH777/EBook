# EBook E-commerce Application

Welcome to the EBook e-commerce application repository! This project is a complete online bookstore built using ASP.NET Core MVC, Entity Framework Core, and ASP.NET Core Identity. It aims to demonstrate the capabilities of ASP.NET Core in creating a robust and scalable e-commerce platform.

## Table of Contents

1. [Overview](#overview)
2. [Features](#features)
3. [Requirements](#requirements)
4. [Setup](#setup)
5. [Usage](#usage)
6. [Deployment](#deployment)
7. [Project Structure](#project-structure)
8. [Contributing](#contributing)

## Overview

EBook is an e-commerce application designed to sell books online. It includes a variety of features typical of modern e-commerce websites, such as user authentication, product management, shopping cart, and order processing. The application is built using the latest technologies provided by .NET Core.

## Features

- **User Authentication and Authorization**: Register, login, and manage user roles.
- **Product Management**: CRUD operations for books.
- **Shopping Cart**: Add books to the cart and manage cart items.
- **Order Processing**: Checkout and order history.
- **Payment Integration**: Stripe payment gateway integration.
- **Responsive Design**: Built with Bootstrap v5 for a responsive user interface.
- **Admin Dashboard**: Manage users, roles, and book inventory.
- **Email Notifications**: Send email notifications for various actions.

## Requirements

To run this project, you need the following tools:

- **Visual Studio 2022**
- **.NET 8 SDK**
- **SQL Server Management Studio**
- **Node.js** (for frontend dependencies)

## Setup

Follow these steps to set up the project locally:

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/your-repo-name.git
   cd your-repo-name
   ```

2. **Set Up the Database**:
   - Open SQL Server Management Studio and create a new database named `EBook`.
   - Update the connection string in `appsettings.json` to match your SQL Server configuration.

3. **Apply Migrations**:
   ```bash
   dotnet ef database update
   ```

4. **Install Frontend Dependencies**:
   ```bash
   cd EBook
   npm install
   ```

5. **Run the Application**:
   - Open the solution in Visual Studio.
   - Restore NuGet packages.
   - Run the project.

## Usage

Once the application is running, you can access it at `http://localhost:5000`. Use the admin dashboard to manage books, users, and orders. Regular users can browse books, add them to the cart, and complete purchases.

## Deployment

To deploy the application, follow these steps:

### Deploy to Azure

1. **Create an Azure Web App**:
   - Set up an Azure Web App service.
   - Configure the SQL Database service.

2. **Publish from Visual Studio**:
   - Right-click the project in Visual Studio and select `Publish`.
   - Choose `Azure` as the target and follow the prompts to deploy.

### Deploy to IIS

1. **Configure IIS**:
   - Install the ASP.NET Core Hosting Bundle on the server.
   - Create a new website in IIS and configure the application pool.

2. **Publish the Application**:
   - Right-click the project in Visual Studio and select `Publish`.
   - Choose `Folder` as the target and publish to a local folder.
   - Copy the published files to the IIS site directory.

## Project Structure

- **/EBook**: Main project directory.
  - **/Controllers**: MVC controllers.
  - **/Models**: Entity models and view models.
  - **/Views**: Razor views.
  - **/wwwroot**: Static files (CSS, JavaScript, images).
  - **/Data**: Database context and migrations.
  - **/Services**: Business logic and service classes.

## Contributing

Contributions are welcome! Feel free to submit issues and pull requests to enhance the project.

---

This README provides an overview and guide to the EBook e-commerce project. It includes information on setting up, using, and deploying the application, as well as a detailed look at the project structure.
