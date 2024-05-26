using GyakorlasSulibaWPF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GyakorlasSulibaWPf
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

            DataContext context = new DataContext();


        public ObservableCollection<Car> Cars { get; set; }
        public ObservableCollection<Owner> Owners { get; set; }

        private Owner selOwner;

        public Owner SelOwner
        {
            get { return selOwner; }
            set { selOwner = value; OnPropertyChanged("SelOwner"); }
        }


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            context.Cars.Load();
            context.Owners.Load();
            Cars = new ObservableCollection<Car>(context.Cars.Local);
            Owners = new ObservableCollection<Owner>(context.Owners.Local);
        }

        private void name_CBX_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Owner selectedOwner = (Owner)name_CBX.SelectedItem;
            if (selectedOwner!=null)
            {
                var ownersCars = new ObservableCollection<Car>(context.Cars.Local.Where(x => x.ownerid == selectedOwner.id));
                data_DG.ItemsSource = ownersCars;
            }
        }
    }
}
