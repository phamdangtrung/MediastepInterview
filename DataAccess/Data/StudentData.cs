using DataAccess.DbAccess;
using DataAccess.Models;
using System.Text;

namespace DataAccess.Data;
public class StudentData : IStudentData
{
    private readonly ISqlDataAccess _db;

    public StudentData(ISqlDataAccess db)
    {
        _db = db;
    }

    public async Task<IDictionary<string, IEnumerable<Student>>> GetStudentsAndSort()
    {
        var studentList = await _db.LoadData<Student, dynamic>("dbo.spStudent_GetAllAndSort", new { });

        IDictionary<string, IEnumerable<Student>> newStudentTable = new Dictionary<string, IEnumerable<Student>>
        {
            { "top", studentList.Skip(10).Take(10) },
            { "middle", studentList.Skip(0).Take(10) },
            { "bottom", studentList.Skip(20).Take(10) }
        };

        return newStudentTable;
    }

    public Task InsertStudent(Student student) =>
        _db.SaveData("dbo.spStudent_Insert", student);

    public Task DeleteAllStudent() =>
       _db.SaveData("dbo.spStudent_DeleteAll", new { });

    public Task InsertBulkStudents(IEnumerable<Student> students)
    {
        StringBuilder sql = new();

        sql.Append("INSERT INTO dbo.[Student](FullName, DateOfBirth) VALUES ");

        foreach(var student in students)
        {
            sql.Append($"('{student.FullName}', '{student.DateOfBirth.ToString("yyyy-MM-dd")}')");

            if (student != students.Last())
            {   
                sql.Append(",");
            }
        }

        return _db.ExecuteQuery(sql.ToString());  
    }
}
