


List<Employee> employees = new();
Employee emp1 = new Employee { Name = "Stefan", Skills = new List<string> { "C", "C++", "Java" } };
Employee emp2 = new Employee { Name = "Karan", Skills = new List<string> { "SQL Server", "C#", "ASP.NET" } };
Employee emp3 = new Employee { Name = "Lalit", Skills = new List<string> { "C#", "ASP.NET MVC", "Windows Azure", "SQL Server" } };

employees.Add(emp1);
employees.Add(emp2);
employees.Add(emp3);

var result = employees.Select(x=> x.Skills).ToList();


Console.WriteLine("---------- useing select() ---------");

foreach (var skills in result)
{

    foreach (var skill in skills)
    {
        Console.WriteLine(skill);
    }
}


Console.WriteLine("---------- useing selectMany() ---------");


//Console.WriteLine("click enter to show SelectMany()");
//Console.ReadLine();

var resultMany = employees.SelectMany(x => x.Skills).ToList();

foreach (var skill in resultMany)
{
    Console.WriteLine(skill);
}



Console.ReadLine();

public class Employee
{
    public string Name { get; set; }
    public List<string> Skills { get; set; }
}
