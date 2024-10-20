# Book Management System

## Introduction
The **Book Management System** is a web application designed to simplify the registration, searching, and management of books. Users can easily add books with details such as title, author, genre, publication date, and access links. This system is built to be scalable, secure, and user-friendly.

## Technologies Used
- **ASP.NET Core**: Framework for web application development.
- **Entity Framework Core**: ORM for database interactions.
- **PostgreSQL**: Database for storing book information.
- **Bootstrap**: CSS framework for a responsive interface.
- **HTML5 & CSS3**: Core technologies for the frontend.
- **JavaScript/jQuery**: Enhances interactivity.

## Features

### 1. Book Registration
Users can add books with detailed information:
- Title
- Author
- Genre
- Publication Date
- Book URL

### 2. Book Search
Users can search books by title or author, displaying results in an organized list.

### 3. Book Management
Registered books can be viewed, edited, or deleted.

### 4. PDF Viewing
Books can be accessed via links embedded directly on the application pages.

## Application Architecture

### 1. Layered Structure
The application is divided into layers for better scalability and maintainability:
- **Presentation Layer**: Handles the UI with Razor pages.
- **Business Logic Layer**: Manages the application's core logic.
- **Data Layer**: Manages database interactions with models and `DbContext`.

### 2. Data Modeling
A `Book` entity stores the details such as title, author, genre, and publication date.

### 3. DbContext Configuration
`BookContext` manages the database setup, including the conversion of the `PublishedDate` field to UTC.

## Local Execution Instructions

### Prerequisites
- .NET Core SDK
- PostgreSQL
- Entity Framework Core CLI

### Setup Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/DijaniraMuachifi/task.git
   ```
2. Update the PostgreSQL credentials in `appsettings.json`.
3. Run migrations:
   ```bash
   dotnet ef database update
   ```
4. Start the application and navigate to `https://localhost:5001` or port `5000`.

## Security Considerations
- **HTTPS**: All requests are redirected to HTTPS.
- **Model Validation**: Data input is validated to prevent invalid entries.

## Database Configuration
To change the database connection:
1. Update the connection string in `appsettings.json` with new host, database, username, and password.
2. Apply new migrations:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

## Conclusion
The **Book Management System** provides a robust and intuitive platform for managing books. It is designed with modularity in mind, allowing for easy future enhancements and scalability.
