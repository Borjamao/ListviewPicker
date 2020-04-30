using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ListviewPicker
{
    public class Printer: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name { get; set; }
        public string Path { get; set; }
    }
    public class Client: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name { get; set; }
        public Printer Printer { get; set; }
    }
}
