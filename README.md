**Requirements:**
Developing the RESTful API to register/delete/update/get for an user using verbs such as:
@GET, @POST @PUT, @DELETE

**FreelancersAPI:**

This project is a RESTful API built using ASP.NET Core Web API that provides functionalities for managing freelance user data. It leverages SQL Server as the backend database and utilizes Entity Framework for data access and modeling.

**Technologies Used:**

ASP.NET Core Web API: The framework for building the API itself.
SQL Server: The relational database management system for storing freelance user data.
Entity Framework: An Object-Relational Mapper (ORM) that simplifies interactions between the API code and the database.

**Project Structure:**

Controllers: This folder contains the controller classes responsible for handling API requests and responses. The FreelanceController class in this project manages freelance user data.
Data: This folder houses the FreelanceUser data model class and likely the ApplicationDBContext class. These classes define the structure of freelance user data and interact with the database.
DTOs (Data Transfer Objects): This folder contain classes representing the data exchanged between the API and the client application. These DTOs help decouple the API from the specific data format used by the client.
Interfaces: This folder contain interfaces defining the functionalities of repositories and other services used by the API. These interfaces promote loose coupling and testability.
Mappers: This folder contain classes responsible for mapping between data models and DTOs.
