



using AutoMapper;
using C.Sharp.Model;


Service service = new Service();

service.InsertUser();
var userList = service.RemoveFutureDate(service.userList.ToArray());

Console.WriteLine(userList.Length);

var list = userList.OrderBy(x => x.GPSDate).ToList();


foreach (var user in userList)
{
    Console.WriteLine($"name{user.Name} date:{user.GPSDate}");
}

Console.WriteLine("Done.");

class Service
{
    public List<User> userList = new();
    public void InsertUser()
    {
        userList.Add(new User() { Id = 7, Name = "User6", GPSDate = DateTime.Now.AddSeconds(50) });
        userList.Add(new User() { Id = 8, Name = "User7", GPSDate = DateTime.Now.AddSeconds(90) });
        userList.Add(new User() { Id = 9, Name = "User8", GPSDate = DateTime.Now.AddSeconds(160) });

        Console.WriteLine("add 10 users success.");
    }
    public User[] RemoveFutureDate(User[] usersList)
    {
        usersList = usersList.Where(g => g.GPSDate.Subtract(DateTime.Now).TotalMinutes <= 2 ||
        g.GPSDate.Year >= DateTime.Now.AddYears(-3).Year).ToArray();
        return usersList;
    }
}
