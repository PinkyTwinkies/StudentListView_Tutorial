using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using StudentListViewTutorial.Model;

namespace StudentListViewTutorial.ViewModel
{
    class ViewModel
    {
        public Student StudentInput { get; set; } = new Student(); //student who will be added to the list
        public Student SelectedStudent { get; set; } = new Student(); // student who will be deleted from the list
        public StudentModel MyStudentModel { get; set; } = new StudentModel(); // The Model which holds the list of all users

        public ICommand AddCommand { get; set; }
        public ICommand RemoveCommand { get; set; }

        public ViewModel()
        {
            AddCommand = new RelayCommand(
                e =>
                {
                    if (StudentInput != null)
                    {
                        MyStudentModel.Add(new Student { Name = StudentInput.Name, Score = StudentInput.Score });
                        Console.WriteLine("Student added");
                    }
                },
                c =>
                {
                    if (StudentInput.Name != "" && StudentInput.Score >= 0 && StudentInput.Score <= 100)
                        return true;
                    else
                    {
                        return false;
                    }
                }
                );

            RemoveCommand = new RelayCommand(
                e =>
                {
                    if (SelectedStudent != null)
                    {
                        MyStudentModel.Remove(SelectedStudent);
                        Console.WriteLine("Student removed");
                    }
                }, c => SelectedStudent != null
                );


        }

    }
}
