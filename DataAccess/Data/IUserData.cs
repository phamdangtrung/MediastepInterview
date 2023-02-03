using DataAccess.Models;

namespace DataAccess.Data;
public interface IUserData
{
    Task DeleteAllStudent();
    Task<IDictionary<string, IEnumerable<Student>>> GetStudentsAndSort();
    Task InsertStudent(Student student);
    Task InsertBulkStudents(IEnumerable<Student> students);
}