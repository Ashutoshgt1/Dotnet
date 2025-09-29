using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.viewmodel
{
    internal class slider :INotifyPropertyChanged
    {
		private int _slidervalue;

		public int slidervalue
		{
			get { return _slidervalue; }
			set { _slidervalue = value;
				OnPropertyChanged(nameof(slidervalue));
			}
		}

        private void OnPropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v)); 
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
