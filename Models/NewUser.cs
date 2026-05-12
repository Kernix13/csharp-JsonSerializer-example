namespace JsonOOP;

public class NewUser : IUser
{
  // You must implement everything the interface asked for
  public string Id { get; set; }
  public string Name { get; set; }
  public string UserName { get; set; }
  public string Email { get; set; }
  public Address HomeAddress { get; set; }

  // JsonSerializer.Serialize adds this as a new field in the JSON file
  public string FullAddress => HomeAddress.FormatAddress();
  
  // Constructor
  public NewUser(string id, string name, string userName, string email, Address homeAddress)
  {
      Id = id;
      Name = name;
      UserName = userName;
      Email = email;
      HomeAddress = homeAddress;
  }

  public string DisplayInfo()
  {
      // Simple method for now, not sure what to do here
      return $"Name: {Name}, UserName: {UserName}";
  }
}