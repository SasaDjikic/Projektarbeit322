using Projektarbeit322.Models;
using Projektarbeit322.Database;
using System.Collections.ObjectModel;

namespace Projektarbeit322.ViewModels
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            Kundenliste = new ObservableCollection<Kunde>(Database.Database.GetKunden());
        }
        public ObservableCollection<Kunde> Kundenliste { get; set; }
    }
}
