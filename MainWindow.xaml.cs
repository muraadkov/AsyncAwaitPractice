using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
using System.Xml.Serialization;


namespace GamesNews
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void findGames_Click(object sender, RoutedEventArgs e)
        {
            ToList();
        }
        private async void ToList()
        {
            var games = await Games();
            grid.ItemsSource = games;
        }
        private Task<List<Item>> Games()
        {
            return Task.Run(() =>
            {
                var url = "https://www.gamespot.com/feeds/new-games/";
                XmlRootAttribute xRoot = new XmlRootAttribute();
                xRoot.ElementName = "channel";
                xRoot.ElementName = "rss";
                xRoot.IsNullable = false;
                XmlSerializer serializer = new XmlSerializer(typeof(Rss), xRoot);
                WebClient client = new WebClient();
                string data = Encoding.Default.GetString(client.DownloadData(url));
                Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(data));
                var xml = (Rss)serializer.Deserialize(stream);
                var _allGames = xml.Channel.Item;
                return _allGames;
            });
        }
    }
}
