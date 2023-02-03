using System.ComponentModel.DataAnnotations;

namespace MediaStepUI.ViewModels.HomeViewModels;

public class CreateStudentViewModel
{
    [Required]
    [MinLength(2)]
    [MaxLength(100)]
    public string FullName { get; set; }
    [Required]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }
}
