# Order Management System API

## Overview
A backend RESTful API designed to manage orders, customers, users, and products in a structured and secure manner. The system follows enterprise-style architecture and simulates real-world order processing workflows.

## Tech Stack
- ASP.NET Core Web API
- C#
- SQL Server
- Entity Framework Core
- JWT Authentication

## Features
- User authentication and authorization using JWT
- Role-based access control
- CRUD operations for orders, customers, and products
- Secure and structured API endpoints
- Validation and error handling

## Architecture
- Clean Architecture
- Repository Pattern
- 3-Tier Architecture (Presentation, Business, Data Access)
- DTO-based request/response models

## How to Run
1. Clone the repository
2. Configure the SQL Server connection string
3. Apply migrations using Entity Framework
4. Run the application
5. Test endpoints using Postman or Swagger

## Future Improvements
- Add refresh token support
- Implement logging and monitoring
- Add automated unit tests
