using Relay_Command.Helper_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp5
{
    public class viewmodel
    {
        public Frame mainframe {  get; set; }

        public RelayCommand NavigatePage1Command {  get;}
        public RelayCommand NavigatePage2Command {  get;}
        public RelayCommand BackCommand {  get;}
        public RelayCommand ForwardCommand {  get; }
        public viewmodel()
        {
            NavigatePage1Command = new RelayCommand(_ => mainframe?.Navigate(new Page1()));
            NavigatePage2Command = new RelayCommand(_ => mainframe?.Navigate(new Page2()));
            BackCommand = new RelayCommand(_ => { if (mainframe?.CanGoBack == true) mainframe.GoBack(); });
            ForwardCommand = new RelayCommand(_ => { if (mainframe?.CanGoForward == true) mainframe.GoForward(); });
        }
    }
}
