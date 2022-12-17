using Projektarbeit322.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projektarbeit322.Views
{
    /// <summary>
    /// Interaction logic for KundeErfassenView.xaml
    /// </summary>
    public partial class KundeErfassenView : Window
    {
        private Kunde _kunde;

        private KundeErfassenView() => InitializeComponent();

        public KundeErfassenView(Kunde kunde)
            : this()
        {
            _kunde = kunde;
            DataContext = _kunde;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

            string[] service = new string[]
            {
                "Kleiner Service",
                "Grosser Service",
                "Rennski Service",
                "Bindung montieren und einstellen",
                "Fell zuschneiden",
                "Heisswachsen"
            };

            string[] priority = new string[]
            {
                "Tief",
                "Standart",
                "Express"
            };

            string[] status = new string[]
            {
                "Abgeschlossen",
                "In-Arbeit",
                "Offen"
            };

            DialogResult = true;
            Close();
        }
    }
}
