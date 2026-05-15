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
        // Populate _users: sync the _users list with the .json file
        InitializeData();
    }

    // I had to replace IUser with NewUser here because of errors
    public void AddUser(IUser user)
    {
        if (user is NewUser CurrentUser)

        {
            // Populate the _users List with each NewUser
            _users.Add(CurrentUser);

            var options = new JsonSerializerOptions { WriteIndented = true };

            // Write the _users as JSON to data/users.json 
            string jsonString = JsonSerializer.Serialize(_users, options);
            File.WriteAllText(_filePath, jsonString);
        }
    }

    public void InitializeData()
    {
        if (File.Exists(_filePath))
        {
            var options = new JsonSerializerOptions { WriteIndented = true };

            string jsonString = File.ReadAllText(_filePath);

            // How can I access _users for update &/or delete options?
            _users = JsonSerializer.Deserialize<List<NewUser>>(jsonString, options) ?? new List<NewUser>();
        }
    }

    // Get all users as NewUsers objects 
    public List<NewUser> GetUsers() => _users;
}