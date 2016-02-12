using MVVM_Basics_Example_WPF.Common;
using MVVM_Basics_Example_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Basics_Example_WPF.ViewModels
{
    public class MainViewModel
    {
        private ObservableCollection<StudentModel> _studentCollection = new ObservableCollection<StudentModel>();
        public ObservableCollection<StudentModel> StudentCollection
        {
            get { return _studentCollection; }
            set { _studentCollection = value; }
        }

        private StudentModel _student = new StudentModel();
        public StudentModel Student
        {
            get { return _student; }
            set { _student = value; }
        }

        public RelayCommand AddStudentCommand => new RelayCommand(p => AddStudent(), p => CanAddStudent());

        private void AddStudent()
        {
            StudentCollection.Add(new StudentModel(Student));
        }

        private bool CanAddStudent() => !(string.IsNullOrWhiteSpace(Student.FirstName) || 
                                          string.IsNullOrWhiteSpace(Student.LastName) || 
                                          string.IsNullOrWhiteSpace(Student.Course) );



    }
}
