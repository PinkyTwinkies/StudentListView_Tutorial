using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentListViewTutorial.Model
{
    class Student : INotifyPropertyChanged
    {

        private int score = 0;
        private String name = "";

        public int Score
        {
            get => score;
            set
            {
                score = value;
                RaisePropertyChanged(nameof(Score));
            }
        }

        public String Name
        {
            get => name;
            set
            {
                name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
