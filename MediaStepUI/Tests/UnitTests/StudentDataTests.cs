namespace MediaStepUI.Tests.UnitTests;

using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class StudentDataTests
{
    private readonly IStudentData _studentData;

    public StudentDataTests(IStudentData studentData)
    {
        _studentData = studentData;
    }

    [TestMethod]
    public async Task GetStudentsAndSort_ShouldReturnADictionary()
    {
        var expected = typeof(IDictionary<string, IEnumerable<Student>>);

        var studentList = await _studentData.GetStudentsAndSort();

        var result = studentList.GetType();
        Assert.IsInstanceOfType(result, expected); 
    }

    [TestMethod]
    public async Task GetStudentsAndSort_ShouldReturnADictionaryWith30Items()
    {
        int expected = 30;

        var studentList = await _studentData.GetStudentsAndSort();

        var result = studentList.Count();
        Assert.AreEqual(expected, result);
    }
}
