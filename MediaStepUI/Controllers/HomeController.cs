using MediaStepUI.Models;
using MediaStepUI.ViewModels.HomeViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Diagnostics;

namespace MediaStepUI.Controllers;
public class HomeController : Controller
{
    private readonly IUserData _userData;

    public HomeController(IUserData userData)
    {
        _userData = userData;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var students = await _userData.GetStudentsAndSort();
        IndexViewModel viewModel = new();

        viewModel.Top = students["top"];
        viewModel.Middle = students["middle"];
        viewModel.Bottom = students["bottom"];

        return View("Index", viewModel);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View("Create");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            TempData["Message"] = "Please make sure you've fulfilled all the requirements.";
            return View();
        }


        LinkedList<Student> newStudentList = new LinkedList<Student>();

        foreach(var student in viewModel.Students)
        {
            newStudentList.AddLast(new Student { FullName = student.FullName, DateOfBirth = student.DateOfBirth });
        }

        await _userData.InsertBulkStudents(newStudentList.AsEnumerable());
        TempData["Message"] = "Ok";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
