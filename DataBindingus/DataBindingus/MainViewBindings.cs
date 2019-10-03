using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingus
{
    internal class MainViewBindings : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _Tekstas;

        public string TekstoProperty
        {
            get
            {
                return _Tekstas;
            }
            set
            {
                if (value != _Tekstas)
                {
                    _Tekstas = value;
                    NotifyChange("TekstoProperty");
                }
            }
        }

        private string _Labas;

        public string LabasProperty
        {
            get { return _Labas; }
            set
            {
                if (value != _Labas)
                {
                    _Labas = value;
                    NotifyChange("LabasProperty");
                }
            }
        }

        private void NotifyChange(string property)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}