



using C.Sharp.Model;


Service service = new Service();

service.InsertUser();
var userList = service.RemoveFutureDate(service.userList.ToArray());

Console.WriteLine(userList.Length);

var list = userList.OrderBy(x => x.GPSDate).ToList();


foreach (var user in userList)
{
    //Console.WriteLine($"name{user.Name} date:{user.GPSDate}");
}

Console.WriteLine("Done.");

class Service
{
    public List<User> userList = new();
    public void InsertUser()
    {
        userList.Add(new User() { Id = 1, Name = "User1", GPSDate = DateTime.Now.AddYears(2) });
        userList.Add(new User() { Id = 3, Name = "User2", GPSDate = DateTime.Now.AddYears(20) });
        userList.Add(new User() { Id = 4, Name = "User3", GPSDate = DateTime.Now.AddYears(10) });
        userList.Add(new User() { Id = 5, Name = "User4", GPSDate = DateTime.Now.AddYears(-6) });
        userList.Add(new User() { Id = 6, Name = "User5", GPSDate = DateTime.Now });
        userList.Add(new User() { Id = 7, Name = "User6", GPSDate = DateTime.Now });
        userList.Add(new User() { Id = 8, Name = "User7", GPSDate = DateTime.Now });
        userList.Add(new User() { Id = 9, Name = "User8", GPSDate = DateTime.Now });
        userList.Add(new User() { Id = 9, Name = "User9", GPSDate = DateTime.Now.AddYears(-5) });
        userList.Add(new User() { Id = 10, Name = "User10", GPSDate = DateTime.Now.AddYears(1) });
        userList.Add(new User() { Id = 1, Name = "User1", GPSDate = DateTime.Now.AddYears(2) });
        Console.WriteLine("add 10 users success.");
    }
    public User[] RemoveFutureDate(User[] usersList)
    {
        var inFutureOrPast = usersList.Where(g => g.GPSDate.Subtract(DateTime.Now).TotalMinutes > 2 ||
        g.GPSDate.Year < DateTime.Now.AddYears(-3).Year);

        usersList = usersList.Except(inFutureOrPast).ToArray();

        return usersList;
    }
}