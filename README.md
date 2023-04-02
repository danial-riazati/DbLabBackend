# DbLabBackend

This project is a Web Api impelmented using of .Net 6 and Sql Server database.
In phase 1 we implemented CRUD of a list. (The functionality of Adding, Updating, Reading and Deleting Items of a list using some endpoints). 
For this purpose we use `Code First Approach`. The database is in `docker-compose.yaml` file for easier development. 
In phase 2 we added `JWT Authentication With Refresh Tokens` to our Api by using ` Microsoft.AspNetCore.Identity.EntityFrameworkCore `.
In phase 3 we secure our project by an open source captcha package named `Edi.Captcha.AspNetCore`.


## Usage
### Setup Database

Use `docker-compose up -d` command for setting up the sql server database container.
(The username and password is in file).


### Update Configuration

update the connection string of database in `appsettings.json`.

### Run the project

using `dotnet run` command the project will be started in `https://localhost:7049`

### Use Swagger

You can use and test the Api in `https://localhost:7049/swagger/index.html`

