using static DeconstructingObjects.DeconstructingSample;

var student = new Student { FirstName = "Jane", LastName = "Smith" };
var (firstName, lastName) = student;

Console.WriteLine($"First Name: {firstName}, Last Name: {lastName}");

var currentDate =  DateTime.Now;
var (year, month, day) = currentDate;

Console.WriteLine($"Year: {year}, Month: {month}, Day: {day}");

var students = new Dictionary<int, string>
{
    {1, "John"},
    {2, "Jane" }
};

foreach(var (id, name) in students)
{
    Console.WriteLine($"ID: {id}, Name: {name}");
}