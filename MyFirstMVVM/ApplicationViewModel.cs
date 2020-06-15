using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVVM
{
  
        public class ApplicationViewModel : INotifyPropertyChanged
        {
            private Model selectedBad;

            public ObservableCollection<Model> Phrases { get; set; }
            public Model SelectedBad
            {
                get { return selectedBad; }
                set
                {
                    selectedBad = value;
                    OnPropertyChanged("SelectedBad");
                }
            }

            public ApplicationViewModel()
            {
                Phrases = new ObservableCollection<Model>
            {
                new Model {What="Hello there", Action="Said", Who="Obi wan" },
                new Model {What="Luke, I'm ur father!", Action="Said", Who ="Darth Vader" },
                new Model {What="WUWUAUWAUWUWUW", Action="Shouted", Who="Chewbacca" },
                new Model {What="cogito ergo sum", Action="propositioned", Who="Rene Descart" }
            };
            }

            public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged([CallerMemberName]string prop = "")
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    
}
