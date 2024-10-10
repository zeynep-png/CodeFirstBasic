
# Code First Approach - Entity Framework Core

This project demonstrates the *Code First approach* using *Entity Framework Core* to create a database with two independent tables: Movies and Games.

## Project Overview

The Code First approach allows us to define our database structure using C# classes. In this project, we will create a database called *PatikaCodeFirstDb1* with the following two tables:

### 1. Movie Table
The Movies table stores information about different movies with the following columns:
- *Id*: Primary key, automatically incrementing.
- *Title*: The title of the movie.
- *Genre*: The genre of the movie (e.g., "Action", "Comedy", "Drama").
- *ReleaseYear*: The year the movie was released.

### 2. Game Table
The Games table stores information about video games with the following columns:
- *Id*: Primary key, automatically incrementing.
- *Name*: The name of the game.
- *Platform*: The platform the game is played on (e.g., "PC", "PlayStation", "Xbox").
- *Rating*: The rating of the game on a scale from 0 to 10.

---

## Technologies Used

- *.NET Core SDK*: Required for building and running the project.
- *Entity Framework Core*: Used for database communication via the Code First approach.
- *SQL Server*: The database system used for data storage.

---

## Steps to Set Up and Run the Project

### 1. Install Dependencies

Before running the project, install the following NuGet packages by running the commands below in the terminal:

bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools


These dependencies allow the project to interact with SQL Server and handle database migrations.

### 2. Define the Entities

The project includes two entity classes (Movie and Game) that map to the respective database tables. You don’t need to manually define these tables; Entity Framework Core will generate them based on the entity definitions.

### 3. Configure the Database

The database connection is configured in the PatikaFirstDbContext class. Ensure that the OnConfiguring method points to your SQL Server instance. By default, the connection string assumes you have SQL Server running locally:


Server=.;Database=PatikaCodeFirstDb1;Trusted_Connection=True;


### 4. Create Migrations

Once the entities and context are defined, create a migration to generate the database schema. Use the following command:

bash
dotnet ef migrations add InitialCreate


This command generates a migration file, which includes the necessary SQL commands to create the database schema.

### 5. Update the Database

Apply the migration to the database with the following command:

bash
dotnet ef database update


This command will create the *PatikaCodeFirstDb1* database in SQL Server with Movies and Games tables.

---

## Testing the Database

Once the database is created, you can interact with it using LINQ queries in the project, or directly via SQL Server. You can insert new Movies or Games, and retrieve data for testing and further development.

---
