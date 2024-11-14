using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens
{
    public partial class SchoolCitizensViewModel : BaseViewModel
    {
        private TeacherViewModel _teacherViewModel;
        private ParentViewModel _parentViewModel;
        private StudentViewModel _studentViewModel;

        public SchoolCitizensViewModel()
        {
            _currentSchoolCitizensChildView = new StudentViewModel();
            _studentViewModel = new StudentViewModel();
            _parentViewModel = new ParentViewModel();
            _teacherViewModel = new TeacherViewModel();
        }

        public SchoolCitizensViewModel(StudentViewModel studentViewModel)
        {
            _studentViewModel = studentViewModel;

            _currentSchoolCitizensChildView= new StudentViewModel();
        }
public SchoolCitizensViewModel(TeacherViewModel teacherViewModel)
        {
            _teacherViewModel = teacherViewModel;

            _currentSchoolCitizensChildView= new TeacherViewModel();
        }
public SchoolCitizensViewModel(ParentViewModel parentViewModel)
        {
            _parentViewModel = parentViewModel;

            _currentSchoolCitizensChildView= new ParentViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentSchoolCitizensChildView;

        [RelayCommand]
        public void ShowStudentView()
        {
            CurrentSchoolCitizensChildView = _studentViewModel;
        }

        [RelayCommand]
        public void ShowParentView()
        {
            CurrentSchoolCitizensChildView = _parentViewModel;
        }

        [RelayCommand]
        public void ShowTeacherView()
        {
            CurrentSchoolCitizensChildView = _teacherViewModel;
        }
    }
}
