namespace JsonOOP;

using System;
using System.IO;
using System.Text.Json;

public class UserHandler
{
    // private fields for encapsulation
    private List<NewUser> _users = new List<NewUser>(); 
    private string _filePath;

    // Pass in users.json file path to know where to save the data
    public UserHandler(string filePath)
    {
        _filePath = filePath;
    }

    // I had to replace IUser with NewUser here because of errors
    public void AddUser(NewUser user)
    {   
        // Populate the _users List with each NewUser
        _users.Add(user);

        var options = new JsonSerializerOptions { WriteIndented = true };

        // Write the _users as JSON to data/users.json 
        string jsonString = JsonSerializer.Serialize(_users, options);
        File.WriteAllText(_filePath, jsonString);

    }

    // Add method here to deserialize the json file:
    // GetJsonObjects or ConvertJsonToObject or ...

    // Get all users as NewUsers objects 
    public List<NewUser> GetUsers() => _users;
}