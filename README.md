# Clean Architecture Project

This repository is an implementation of a Clean Architecture design pattern using .NET Core. The project separates concerns into distinct layers, making it scalable, testable, and maintainable.

## Table of Contents

- [Project Structure](#project-structure)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
- [Running the Application](#running-the-application)
- [Running Tests](#running-tests)
- [Contributing](#contributing)
- [License](#license)

---

## Project Structure

The project follows the Clean Architecture principles and is organized into the following layers:

- **Domain**: Core business logic and entities.
- **Application**: Application-specific business rules, including DTOs, interfaces, and service implementations.
- **Infrastructure**: External concerns like data persistence, email sending, etc.
- **API**: Entry point for the application, providing RESTful endpoints.

---

## Technologies Used

- **.NET Core 8.0**
- **Entity Framework Core 8.0**
- **AutoMapper**
- **FluentValidation**
- **SQL Server**
- **Swagger UI**

---

## Getting Started

### Prerequisites

Ensure you have the following installed:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server)


### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/your-repo-name.git
   cd your-repo-name
