using Friends_Console;
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

namespace FriendsWPF
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

        public ObservableCollection<Episode> episodes { get; set; }
        public ObservableCollection<Season> seasons { get; set; }

        private Season selectedSeason;

        public Season SelectedSeason
        {
            get { return selectedSeason; }
            set { selectedSeason = value; }
        }

        private Episode selectedEpisode;

        public Episode SelectedEpisode
        {
            get { return selectedEpisode; }
            set { selectedEpisode = value; OnPropertyChanged("SelectedEpisode"); }
        }

        public MainWindow()
        {
            InitializeComponent();
            InitializeComponent();
            this.DataContext = this;
            context.seasons.Load();
            context.episodes.Load();
            seasons = new ObservableCollection<Season>(context.seasons.Local);
            episodes = new ObservableCollection<Episode>(context.episodes.Local);
        }

        private void Season_CBX_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Season selectedSeason = (Season)Season_CBX.SelectedItem;
            if (selectedSeason != null)
            {
                var seasonEpisodes = new ObservableCollection<Episode>(context.episodes.Local.Where(x => x.season == selectedSeason.id));
                data_DG.ItemsSource = seasonEpisodes;
            }
        }

        private void data_DG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedEpisode = (Episode)data_DG.SelectedItem;
        }
    }
}