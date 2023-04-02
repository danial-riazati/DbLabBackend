# DbLabBackend

This project is a Web Api impelmented using of .Net 6 and Sql Server database.
<br/>
<br/>
In phase 1 we implemented CRUD of a list. (The functionality of Adding, Updating, Reading and Deleting Items of a list using some endpoints). Also we implemented `index.html` file that is a simple html file. It is connected to the endpoints.(Adding an item, updating, removing, and viewing the history of each item)
<br/>
<br/>
For this purpose we use `Code First Approach`. The database is in `docker-compose.yaml` file for easier development. 
<br/>
<br/>
In phase 2 we added `JWT Authentication With Refresh Tokens` to our Api by using ` Microsoft.AspNetCore.Identity.EntityFrameworkCore `.
<br/>
<br/>
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

### Images

#### Swagger
![image](https://user-images.githubusercontent.com/58943927/229371982-aaca6835-6920-4c23-bb3c-f616b677b7e2.png)

#### Captcha
![image](https://user-images.githubusercontent.com/58943927/229371954-ebad0c2d-b2a8-435e-a5db-d50ece3199de.png)

#### Index.html
<img width="1440" alt="Screenshot 2023-04-02 at 11 07 54 PM" src="https://user-images.githubusercontent.com/58943927/229372303-e401a4c8-9135-4506-9d30-3bc1b19a054b.png">

