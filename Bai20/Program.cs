// See https://aka.ms/new-console-template for more information
Console.WriteLine("2415053122143 - Nguyen Vuong Trong - 225LTC#02");

List<Student> students = new List<Student>()
{
    new Student { Id = 1, Name = "An", Score = 8 },
    new Student { Id = 2, Name = "Binh", Score = 6 },
    new Student { Id = 3, Name = "Chi", Score = 9 },
    new Student { Id = 4, Name = "Dung", Score = 7 }
};

Console.WriteLine("Top 3 sinh vien diem cao nhat:");
var chianhom = students.OrderByDescending(x => x.Score).Take(3);
foreach (var s in chianhom)
    Console.WriteLine($"Id: {s.Id}, Name: {s.Name}, Score: {s.Score}");
class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public double Score { get; set; }
}