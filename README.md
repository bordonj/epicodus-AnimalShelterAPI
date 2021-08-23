## Building an API: Animal Shelter

#### _Building an API: Animal Shelter- 08/25/21 - Code Review013_

#### By _**Jennifer Bordon**_
## Description
This is a project to practice building an API, using C#, that has CRUD and pagination. The API will be for an **Animal Shelter**, so a user can view all its available animals. The seed data this project begins with has 15 animals.

Note: there is no UI to view this in the browser, please use Postman to access CRUD for the API

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
    "DefaultConnection": "Server=localhost;Port=3306;database={database_name};uid={YOUR_USERNAME_NAME};pwd={YOUR_PASSWORD};"
  }
}
```
Be sure to replace `{database_name}` `{YOUR_USERNAME_NAME}` and `{YOUR_PASSWORD}` with the appropriate terms.
- for `{database_name}`, this refers to the database or schema
  - make sure to replace this input with what you decide to name the schema/database
- for `{YOUR_USERNAME_NAME}` and `{YOUR_PASSWORD}`, this refers to your username and password for MySQL

- NOTE: _Do not include the curly brackets in your code snippet of appsettings.json_

  - in order to use a migration, first make sure you download "dotnet ef" tool by running `dotnet tool install --global dotnet-ef --version 3.0.0`
  - next make sure you are in the `AnimalShelter` directory, and run `dotnet ef migrations add NewUserSeededData`
    - this will create a new `Migrations` folder in the root of that directory
  - Finally, to apply the migration, run `dotnet ef database update`
    - this will actually create the database in MySQL so you don't have to manually create it yourself!


5. In order view the API data in the browser/use Postman to access different methods to the API, make sure you've navigated to the `AnimalShelter` diretory
  - run the code `dotnet run`


## API Endpoints
Upon running the command `dotnet run` in the `AnimalShelter` directory, please use Postman to access the different API endpoints

the keyword in brackets designates the specific `CRUD` functionality per endpoint

  - **[READ]** -- to view ALL animals, send a `GET` request to `/api/animals`
  - **[CREATE]** -- to create a new animal available at the shelter, send a `POST` request to `/api/animals`
    - you can insert the code below into the body as raw JSON, to create your animal with the `POST` method
  ```
      {
        "name": "{insert name}",
        "species": "{insert species type}",
        "age": "{insert age}",
        "size": "{insert size}",
        "gender": "{insert gender}",
        "description": "{insert description}"
      }
  ```
  - **[READ]** -- to view a specific animal given an id, send a `GET` request to `/api/animal/{id}`
    - the {id} should be replaced by the specific id of the animal, without the curly brackets
  - **[UPDATE]** -- to update/edit a specific animal's information, send a `PUT` request to `/api/animals/{id}`
    - you can insert the code below into the body as raw JSON for editing the information
```
      {
        "animalId" : {insert id},
        "name": "{insert name}",
        "species": "{insert species type}",
        "age": "{insert age}",
        "size": "{insert size}",
        "gender": "{insert gender}",
        "description": "{insert description}"
      }
```
  - **[DELETE]** -- to delete an animal entry, locate the animal id you want to delete. Then send a `DELETE` request to `/api/animals/{id}`

## Parameters to a Get Request
You may add parameters to search for an animal with specific queries.

For example, if you wanted the animals returned to be filtered by a certain search criteria (e.g., all cats), you can type in the following url into the API request.

```
http://localhost:5000/api/animals?species=cat
```
You may also input multiple parameters by adding the & prior to the next query you'd like to combine the request with. This will return the one specific animal that matches each of the queries, as long as it exists. See the following code below.

```
http://localhost:5000/api/animals/?species=rabbit&gender=male&name=ron
```



## Pagination
Upon sending a general `GET` request to `/api/animals`, the user may opt to use `page` and `perPage` parameters to specify which page the user wants to view, and how many animals per page should be viewed. 

_please note that the first page starts on `0`. The last page, will vary depending on how many animals per page you want to view._

To use view the API responses using pagination in Postman:
- select the `Params` tab
- add a `KEY` with the name `page`
  - for this `VALUE`, you can start at `0`
  - this will default to showing `3` animals per page, and this will show `3` animals even if you manually type in `0` animals perPage
- if you want to edit how many animals to view per page, add a second `KEY` labeled `perPage`
  - for the `perPage` value, as long as the value is between 1 and the total number of animals available, then it will correctly return that amount to view
  - you can find the `total` amount of animals as the `total` property shown on the bottom of the page details in the API response

## Bugs

_For the "nextPage" property shown in the JSON response for an API request, it may not be the most accurate. It should show the next page when even one final entry is on, however, this is not always perfect. This feature has not been tested thoroughly, so if specific cases are found when it does not return a correct next page, please let me know!_

_Additionally, the "parameters" combined with the pagination will not account for any parameters added. Please keep this in mind when adding any queries to the API requests._

## License

_MIT_

_Copyright (c) 2021 Jennifer Bordon_


## Contact Information

_jennifer.bordon@gmail.com_