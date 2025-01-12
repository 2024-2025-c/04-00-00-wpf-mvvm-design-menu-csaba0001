using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.Students;

public partial class StudentsViewModel : BaseViewModel
{
    private StudentViewModel _studentViewModel;
    private StudentPlaceholderViewModel _studentPlaceholderViewModel;

    public StudentsViewModel()
    {
        _studentPlaceholderViewModel = new StudentPlaceholderViewModel();
        _studentViewModel = new StudentViewModel();
        
        _studentViewModel = new StudentViewModel();
        _studentPlaceholderViewModel = new StudentPlaceholderViewModel();
    }

    public StudentsViewModel(StudentViewModel studentViewModel, StudentPlaceholderViewModel studentPlaceholderViewModel)
    {
        _studentViewModel = studentViewModel;
        _studentPlaceholderViewModel = studentPlaceholderViewModel;
        
        _currentStudentChildViewModel = new StudentPlaceholderViewModel();
        _currentStudentChildViewModel = new StudentViewModel();
    }
    
    [ObservableProperty]
    private BaseViewModel? _currentStudentChildViewModel;

    [RelayCommand]
    public void ShowStudentView()
    {
        _currentStudentChildViewModel = _studentViewModel;
    }

    [RelayCommand]
    public void ShowStudentPlaceholderView()
    {
        _currentStudentChildViewModel = _studentPlaceholderViewModel;
    }
    
}