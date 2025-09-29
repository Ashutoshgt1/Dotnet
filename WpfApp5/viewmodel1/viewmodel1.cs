using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.viewmodel
{
    class viewmodel1:INotifyPropertyChanged
	{
		private string _name;

		public string name
		{
			get { return _name; }
			set { _name = value; 
				Onpropertychanged(nameof(name));
			}
		}

        private void Onpropertychanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
