namespace DataAccess.Models;
public class Student
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public bool Archived { get; set; }
}
