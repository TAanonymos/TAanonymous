using System;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string OtherInfo { get; set; }

    public Student()
    {
    }

    public Student(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public bool IsOlderThan(Student other)
    {
        DateTime firstBirthDate = this.BirthDate;
        DateTime secondBirthDate = other.BirthDate;

        bool isOlder = firstBirthDate < secondBirthDate;
        return isOlder;
    }

    static void Main()
    {
        Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
        peter.OtherInfo = "From Sofia, born at 17.03.1992";
        peter.BirthDate = new DateTime(1992, 03, 17);

        Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
        stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";
        stella.BirthDate = new DateTime(1993, 11, 03);

        Console.WriteLine("{0} older than {1} -> {2}",
            peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
    }
}
