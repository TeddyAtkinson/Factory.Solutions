# Dr. Sillystringz's Factory

#### By Teddy Atkinson

#### A many-to-many database MVC Application

## Technologies Used

* C#
* .Net 6
* ASP.Net Core 6 MVC
* EF Core 6
* SQL
* MySQL
* MySQL Workbench
* LINQ

## Description
An app for a factory to keep track of engineers and machines.

## Setup and Installation

### Open project

1. Navigate to the `Factory` directory.
2. Create a file named `appsettings.json` with the following code. Be sure to update the Default Connection to your MySQL credentials.
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];",
  }
}
```
3. Ensure you're running on .NET v6
```
dotnet tool install --global dotnet-ef --version 6.0.0
```
```
dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
```

4.Install dependencies within the `Factory` directory
```
dotnet restore
```

5. Run the command to build the database on your SQL local host machine
```
dotnet ef database update
```

6. To build & run program in development mode 
 ```
 dotnet run
 ```

7.  To build & run program in production mode 
 ```
 dotnet run --launch-profile "production"
 ```



## Known Bugs

* Added Machine/Engineers to respective Engineer/Machine name does not show up under the details view after linking eachother

## License

MIT License

Copyright & copy; 2023 Teddy Atkinson

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.