namespace JsonOOP;

public interface IUser
{
  int Id { get; set; }
  string Name { get; set; }
  string UserName { get; set; }
  string Email { get; set; }
  Address HomeAddress { get; set; }

  // Add this so it's accessible via the interface type if I change 
  // the user objects back to IUser in Program.cs 
  // string FullAddress { get; }

  string DisplayInfo();
}