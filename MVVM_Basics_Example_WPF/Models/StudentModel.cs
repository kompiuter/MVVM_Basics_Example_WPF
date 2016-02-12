using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Basics_Example_WPF.Models
{
    public class StudentModel : INotifyPropertyChanged
    {
        public StudentModel() { }

        public StudentModel(StudentModel student)
        {
            _firstName = student.FirstName;
            _lastName = student.LastName;
            _course = student.Course;
            _numericalGrade = student.NumericalGrade;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(FirstName)));
            }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(LastName)));
            }
        }

        private string _course;
        public string Course
        {
            get { return _course; }
            set
            {
                _course = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Course)));
            }
        }

        private double _numericalGrade;
        public double NumericalGrade
        {
            get { return _numericalGrade; }
            set
            {
                _numericalGrade = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(NumericalGrade)));
            }
        }

    }
}
