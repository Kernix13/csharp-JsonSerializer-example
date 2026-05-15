using System;
using System.IO;
using System.Text.Json;

using JsonOOP;

string folderName = "Data";
string fileName = "users.json";
string fullPath = Path.Combine(folderName, fileName);

// Check if directory exists, create if not
if (!Directory.Exists(folderName))
{
    Directory.CreateDirectory(folderName);
}

// Create address objects
Address user1Address = new Address("Kulas Light", 123, "Apt. 556", "Gwenborough", "KY", "92998");
Address user2Address = new Address("Victor Plains", 234, "Apt. 879", "Wisokyburgh", "PA", "90566");
Address user3Address = new Address("Douglas Extension", 345, "Apt. 847", "McKenziehaven", "NJ", "59590");

// Create user objects
IUser user1 = new NewUser(1, "Leanne Graham", "Bret", "Sincere@april.biz", user1Address);
IUser user2 = new NewUser(2, "Ervin Howell", "Antonette", "Shanna@melissa.tv", user2Address);
IUser user3 = new NewUser(3, "Clementine Bauch", "Samantha", "Nathan@yesenia.net", user3Address);

UserHandler handler = new UserHandler(fullPath);

// Serialize the objects to JSON
handler.AddUser(user1);
handler.AddUser(user2);
handler.AddUser(user3);

Console.WriteLine("--- Current User Directory ---");
foreach (var user in handler.GetUsers())
{
    Console.WriteLine(user.Name.ToUpper());
    Console.WriteLine(user.FullAddress.ToUpper());
    Console.WriteLine("------------------------------");
}

/* 
  Create code in here to create a new user object using: 
  - Console.ReadLine statements to get each value 
  - return a new NewUser object 
  - make sue to handle exceptions (try/catch)
  - Do I need while loops?

  Maybe break out of the console/program if the user enters a bad value
  I may output a description of the values needed for a new user in that case
*/

