using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListviewPicker
{
    public class MainPageVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand Alert { get; set; }
        public string TheText { get; set; }
        public MainPageVM()
        {
            Alert = new Command(() => TheText = JsonConvert.SerializeObject(Clients) , ()=> true);
        }
        public ObservableCollection<Printer> AvailablePrinters { get; set; } = new ObservableCollection<Printer>()
        {
            new Printer { Name="printer 1", Path=@"\\192.168.1.1\printer1"},
            new Printer { Name="printer 2", Path=@"\\192.168.1.1\printer2"},
            new Printer { Name="printer 3", Path=@"\\192.168.1.1\printer3"},
        };

        public ObservableCollection<Client> Clients { get; set; } = new ObservableCollection<Client>()
        {
            new Client { Name = "John Smith", Printer = new Printer { Name="printer 1", Path=@"\\192.168.1.1\printer1"}},
            new Client { Name = "Rebecca", Printer = new Printer { Name="printer 2", Path=@"\\192.168.1.1\printer2"}},
            new Client { Name = "Tonny", Printer = new Printer { Name="printer 3", Path=@"\\192.168.1.1\printer3"}},
            new Client { Name = "George", Printer = new Printer { Name="printer 1", Path=@"\\192.168.1.1\printer1"}},
            new Client { Name = "Andy", Printer = new Printer { Name="printer 3", Path=@"\\192.168.1.1\printer3"}}
        };
    }
}
