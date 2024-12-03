namespace DeconstructingObjects
{
    public partial class DeconstructingSample
    {
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public int Age { get; set; }

            public void Deconstruct(out string firstName, out string lastName)
            {
                firstName = FirstName;
                lastName = LastName;
            }

            public void Deconstruct(out string firstName, out string lastName, out int age)
            {
                firstName = FirstName;
                lastName = LastName;
                age = Age;
            }
        }     
    }

    public static class DateTimextensions
    {
        public static void Deconstruct(this DateTime dateTime, out int year, out int month, out int day)
        {
            year = dateTime.Year;
            month = dateTime.Month;
            day = dateTime.Day;
        }
    }
}
