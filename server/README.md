# Back-End 🤖

## Table of Contents

- [About](#about)
- [Getting Started](#getting-started)
- [Author](#author)

## About

The `ASP .NET Core` 🚀 project follows a RESTful API architectural style, emphasizing the principles of statelessness, resource identification, and uniform interface. By adhering to RESTful principles, the project aims to provide a clear and consistent approach to designing web services, promoting scalability, flexibility, and ease of maintenance.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

Run server

```bash
dotnet watch run
```

Run migrate again to create those model tables in database:

```bash
dotnet ef migrations add init
dotnet ef database update
```

## Author

Copyright &copy; 2024 by [ZIN](http://www.github.com/losertowinner).
