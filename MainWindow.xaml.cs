using Projektarbeit322.Models;
using Projektarbeit322.ViewModels;
using Projektarbeit322.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace Projektarbeit322
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel _model = new ();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _model;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Kunde kunde = new();
            KundeErfassenView erfassenDialog = new(kunde)
            {
                // Owner setzen
                Owner = this
            };

            // Window anzeigen
            erfassenDialog.ShowDialog();

            // Prüfen, ob Dialog mit OK beendet wurde
            if (erfassenDialog.DialogResult == true)
            {
                _model.Kundenliste.Add(kunde);
            }
        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filter = filterColumn.Text;
            var tbx = sender as TextBox;
            if (tbx.Text != "")
            {
                if (filter == "Vorname")
                {
                    var filteredList = _model.Kundenliste.Where(x => x.Vorname.Contains(tbx.Text, System.StringComparison.CurrentCultureIgnoreCase));
                    dgKunden.ItemsSource = null;
                    dgKunden.ItemsSource = filteredList;
                }
                else if(filter == "Nachname")
                {
                    var filteredList = _model.Kundenliste.Where(x => x.Nachname.Contains(tbx.Text, System.StringComparison.CurrentCultureIgnoreCase));
                    dgKunden.ItemsSource = null;
                    dgKunden.ItemsSource = filteredList;
                }
                else if (filter == "E-Mail")
                {
                    var filteredList = _model.Kundenliste.Where(x => x.EMail.Contains(tbx.Text, System.StringComparison.CurrentCultureIgnoreCase));
                    dgKunden.ItemsSource = null;
                    dgKunden.ItemsSource = filteredList;
                }
                else if (filter == "Telefon")
                {
                    var filteredList = _model.Kundenliste.Where(x => x.Telefon.Contains(tbx.Text, System.StringComparison.CurrentCultureIgnoreCase));
                    dgKunden.ItemsSource = null;
                    dgKunden.ItemsSource = filteredList;
                }
                else if (filter == "Service")
                {
                    var filteredList = _model.Kundenliste.Where(x => x.Service.Contains(tbx.Text, System.StringComparison.CurrentCultureIgnoreCase));
                    dgKunden.ItemsSource = null;
                    dgKunden.ItemsSource = filteredList;
                }
                else if (filter == "Priorität")
                {
                    var filteredList = _model.Kundenliste.Where(x => x.Priority.Contains(tbx.Text, System.StringComparison.CurrentCultureIgnoreCase));
                    dgKunden.ItemsSource = null;
                    dgKunden.ItemsSource = filteredList;
                }
                else if (filter == "Status")
                {
                    var filteredList = _model.Kundenliste.Where(x => x.Status.Contains(tbx.Text, System.StringComparison.CurrentCultureIgnoreCase));
                    dgKunden.ItemsSource = null;
                    dgKunden.ItemsSource = filteredList;
                }
                else if (filter == "Kommentar")
                {
                    var filteredList = _model.Kundenliste.Where(x => x.Kommentar.Contains(tbx.Text, System.StringComparison.CurrentCultureIgnoreCase));
                    dgKunden.ItemsSource = null;
                    dgKunden.ItemsSource = filteredList;
                }
            }
            else
            {
                dgKunden.ItemsSource = _model.Kundenliste;
            }
        }

        private void dgKunden_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var kunde = dgKunden.SelectedItem as Kunde;
            if (kunde != null)
            {
                txtVorname.Text = kunde.Vorname;
                txtNachname.Text = kunde.Nachname;
                txtEMail.Text = kunde.EMail;
                txtTelefon.Text = kunde.Telefon;
                cbService.Text = kunde.Service;
                cbPriority.Text = kunde.Priority;
                cbStatus.Text = kunde.Status;
                txtKommentar.Text = kunde.Kommentar;
            }
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            var kunde = dgKunden.SelectedItem as Kunde;

            if (kunde != null)
            {
                kunde.Vorname = txtVorname.Text;
                kunde.Nachname = txtNachname.Text;
                kunde.EMail = txtEMail.Text;
                kunde.Telefon = txtTelefon.Text;
                kunde.Service = cbService.Text;
                kunde.Priority = cbPriority.Text;
                kunde.Status = cbStatus.Text;
                kunde.Kommentar = txtKommentar.Text;
                dgKunden.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Du hast nichts ausgewählt", "Achtung", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var kunde = dgKunden.SelectedItem as Kunde;

            if (kunde != null)
            {
                var result = MessageBox.Show("Bist du dir sicher?", "Kunde löschen", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);

                if (result == MessageBoxResult.Yes)
                {
                    ObservableCollection<Kunde> data = (ObservableCollection<Kunde>)dgKunden.ItemsSource;
                    data.Remove(kunde);

                    dgKunden.Items.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Du hast nichts ausgewählt", "Achtung", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginView loginDialog = new()
            {
                // Owner setzen
                Owner = this
            };

            // Window anzeigen
            loginDialog.ShowDialog();

            // Prüfen, ob Dialog mit OK beendet wurde
            if (loginDialog._isLoggedIn == true)
            {
                txtEMail.IsReadOnly = false;
                txtNachname.IsReadOnly = false;
                txtVorname.IsReadOnly = false;
                txtTelefon.IsReadOnly = false;
                txtKommentar.IsReadOnly = false;
                cbPriority.IsHitTestVisible = true;
                cbPriority.Focusable = true;
                cbStatus.IsHitTestVisible = true;
                cbStatus.Focusable = true;
                cbService.IsHitTestVisible = true;
                cbService.Focusable = true;
                newBtn.IsEnabled = true;
                saveBtn.IsEnabled = true;
                deleteBtn.IsEnabled = true;
            }
            else if (loginDialog._isLocked == true)
            {
                loginBtn.IsEnabled = false;
            }
        }
    }
}
