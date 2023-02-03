namespace MediaStepUI.ViewModels.HomeViewModels;

public class IndexViewModel
{
    public IEnumerable<Student> Top { get; set; } = new List<Student>();
    public IEnumerable<Student> Middle { get; set; } = new List<Student>();
    public IEnumerable<Student> Bottom { get; set; } = new List<Student>();
}
