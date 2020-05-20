using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentListViewTutorial.Model
{
    class StudentModel
    {
        public ObservableCollection<Student> Students { get; private set; } = new ObservableCollection<Student>();

        public StudentModel()
        {
            Students.Add(new Student { Name = "Thomas", Score = 80 });
            Students.Add(new Student { Name = "Lukas", Score = 50 });
            Students.Add(new Student { Name = "Thorsten", Score = 56 });
        }

        public void Add(Student studentToAdd)
        {
            if (studentToAdd == null)
                return;

            Students.Add(studentToAdd);
            Console.WriteLine("Student added to List");
        }

        public void Remove(Student studentToDelete)
        {
            if (studentToDelete == null)
                return;

            Students.Remove(studentToDelete);
            Console.WriteLine("Student deleted");
        }
    }
}
