namespace MediaStepUI.ViewModels.HomeViewModels;

public class CreateViewModel
{
    public string Message { get; set; } = "Test";
    public IList<CreateStudentViewModel> Students { get; set; } = new List<CreateStudentViewModel>(30);

}
