# CSharp OOP using Interfaces and JsonSerializer

This project uses an interface and 3 classes to create user objects, then uses `JsonSerializer` and the `Serialize` method with `JsonSerializerOptions` to create a JSON file of the objects.

There is one main class `NewUser` that implements the `IUser` interface. I intend create other classes such as AdminUser, GuestUser, etc.

> The is the final deliverable for week 5 module 2 of the C# Software Development pathway for [Code:You](https://code-you.org/).

<!--
  Repo name: csharp-JsonSerializer-example
  Project name: JsonOOP
  About text: C# Object Oriented Programming example that uses the JsonSerializer class for creating JSON data.
 -->

<span aria-hidden="true"><br></span>

## Installation & Usage

1. Clone this repository and switch into project folder

   ```sh
   git clone https://github.com/Kernix13/csharp-JsonSerializer-example.git JsonOOP
   cd JsonOOP
   ```

2. Run the application

   ```bash
   dotnet run
   ```

3. Build the application

   ```bash
   dotnet build
   ```

### Quick Start

```sh
git clone https://github.com/Kernix13/csharp-JsonSerializer-example.git JsonOOP
cd JsonOOP
dotnet run
```

### Example JSON

I used `users.json` from [{JSON} Placeholder](https://jsonplaceholder.typicode.com/) as sample JSON for my objects, though I did not include every field. Here is an example:

```json
{
   "id": 1,
   "name": "Leanne Graham",
   "username": "Bret",
   "email": "Sincere@april.biz",
   "address": {
      "street": "Kulas Light",
      "suite": "Apt. 556",
      "city": "Gwenborough",
      "zipcode": "92998-3874",
   }
},
```

<span aria-hidden="true"><br></span>

## Code to use in this project

### Module 2 code I want to include

| Code to use                | Used? |
| :------------------------- | :---: |
| System.IO                  |  ✅   |
| System.Text.Json           |  ✅   |
| Interface                  |  ✅   |
| Class                      |  ✅   |
| Instance constructors      |  ✅   |
| Class methods              |  ✅   |
| public keyword             |  ✅   |
| private keyword            |  ✅   |
| Path.Combine               |  ✅   |
| Path.GetDirectoryName      |  📌   |
| Directory.Exists           |  ✅   |
| Directory.CreateDirectory  |  ✅   |
| Directory.EnumerateFiles   |  📌   |
| File.WriteAllText          |  ✅   |
| JsonSerializer.Serialize   |  ✅   |
| JsonSerializer.Deserialize |  📌   |
| JsonSerializerOptions      |  ✅   |
| `new List<type>`           |  ✅   |
| `IEnumerable<Type>`        |  📌   |
| try/catch                  |  📌   |
| -- throw new Exception     |  📌   |
| -- ex.Message              |  📌   |

Consider `StreamReader` and `StreamWriter` classes to maybe create a .csv file. I just do not know why I would do that if I am creating a users.json file. `StreamReader` will give me the opportunity to use a `while` loop which seems to always be used with that class.

I do not understand the lesson on `JsonSerializer.Deserialize` though I think it is vital to implement for for a full CRUD app. I plan to add it so that I can enable deleting and updating user objects.

### Module 1 code I want to include

| Code to use         | Used? |
| :------------------ | :---: |
| foreach             |  ✅   |
| while/do-while loop |  📌   |
| Split               |  📌   |
| ToUpper             |  ✅   |
| Add                 |  ✅   |
| IndexOf             |  📌   |
| =>                  |  ✅   |
| ? :                 |  📌   |
| !, !=, \|\|         |  📌   |

- I will use foreach with maybe IEnumerable and Directory.EnumerateFiles but I will need a folder with multiple files in it?!?
