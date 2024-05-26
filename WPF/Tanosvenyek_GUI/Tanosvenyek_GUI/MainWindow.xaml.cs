using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tanosvenyek_GUI.Models;

namespace Tanosvenyek_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string tulajdonsagNev)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(tulajdonsagNev));
        }

        TanosvenyContext context = new TanosvenyContext();

        public ObservableCollection<Telepules> telepulesek { get; set; }

        private ObservableCollection<Utvonal> utvonalak;

        public ObservableCollection<Utvonal> Utvonalak
        {
            get { return utvonalak; }
            set { utvonalak = value; OnPropertyChanged("Utvonalak"); }
        }

        private Utvonal selectedUt;

        public Utvonal SelectedUt
        {
            get { return selectedUt; }
            set { selectedUt = value; OnPropertyChanged("SelectedUt"); }
        }


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            context.Ut.Load();
            context.Telepules.Load();
            telepulesek = context.Telepules.Local.ToObservableCollection();
        }

        private void telepules_CBX_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Telepules selected = (Telepules)telepules_CBX.SelectedItem;
            if(selected != null)
            {
                Utvonalak = new ObservableCollection<Utvonal>(context.Ut.Local.Where(x => x.telepulesid == selected.id).ToList());
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Utvonal sel = (Utvonal)adatok_DG.SelectedItem;
            if(sel != null)
            {
                SelectedUt = sel;
            }
        }
    }
}