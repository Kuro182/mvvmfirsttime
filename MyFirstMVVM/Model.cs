using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVVM
{
    public class Model : INotifyPropertyChanged
    {
        private string what;
        private string action;
        private string who;

        public string What
        {
            get { return what; }
            set
            {
                what = value;
                OnPropertyChanged("What");
            }
        }
        public string Action
        {
            get { return action; }
            set
            {
                action = value;
                OnPropertyChanged("Action");
            }
        }
        public string Who
        {
            get { return who; }
            set
            {
                who = value;
                OnPropertyChanged("Who");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
