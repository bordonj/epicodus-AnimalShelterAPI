## Building an API: Animal Shelter

#### _Building an API: Animal Shelter- 08/25/21 - Code Review013_

#### By _**Jennifer Bordon**_
## Description
This is a project to practice building an API, using C#, that has CRUD and pagination.

The API will be for an **Animal Shelter**.
- this will list all availabe
  - `Cat`s 
  - `Dog`s

## Technologies Used

* _C#_
* _MySQL_ && _MySQL Workbench_
* _Postman_
* _.NET 5 SDK_
* _ASP .NET CORE 5.0_
* _Entity Framework Core_
* _Git_/_Github_
* _RESTful Routing_/_CRUD_
* _Pagination_
* _VS Code_

## Setup/Installation Requirements

1. Download or clone `https://github.com/bordonj/epicodus-AnimalShelterAPI` to your local machine

2. Open terminal and navigate to the `epicodus-AnimalShelterAPI` of the directory

3. Navigate to the the `AnimalShelter` directory, install dependencies by running command:
`$ dotnet restore`

4. Create your database- this can be done by using Migrations
  - first, you'll need to create an appsettings.json file in the `AnimalShelter` directory
    - add the following code to the file:
```
{
  "ConnectionStrings":
  {
    "DefaultConnection": "Server=localhost;Port=3306;database={first_last};uid={YOUR_USERNAME_NAME};pwd={YOUR_PASSWORD};"
  }
}
```
Be sure to replace `{first_last}` `{YOUR_USERNAME_NAME}` and `{YOUR_PASSWORD}` with the appropriate terms.
- for `{first_last}`, this refers to the database or schema
  - make sure to replace this input with what you decide to name the schema/database
- for `{YOUR_USERNAME_NAME}` and `{YOUR_PASSWORD}`, this refers to your username and password for MySQL
- NOTE: usually the username is `root`

- NOTE: _Do not include the curly brackets in your code snippet of appsettings.json_

  - in order to use a migration, first make sure you download "dotnet ef" tool by running `dotnet tool install --global dotnet-ef --version 3.0.0`
  - next make sure you are in the `Bakery` directory, and run `dotnet ef migrations add Initial`
    - this will create a new `Migrations` folder in the root of that directory
  - Finally, to apply the migration, run `dotnet ef database update`
    - this will actually create the database in MySQL so you don't have to manually create it yourself!


5. In order view the API in the browser/use Postman to access different methods to the API, make sure you've navigated to the `AnimalShelter` diretory
  - run the code `dotnet run`


## API EndPoints



## Bugs

_No known bugs at this time. But if any found, please contact me so I can fix them._

## License

_MIT_

_Copyright (c) 2021 Jennifer Bordon_


## Contact Information

_jennifer.bordon@gmail.com_