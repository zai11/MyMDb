using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace MyMDb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void B_Search_Click(object sender, RoutedEventArgs e)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                List<SearchResult> totalResults = new List<SearchResult>();
                for (int i = 0; i < 4; i++)
                {
                    var response = httpClient.GetStringAsync(new Uri("http://www.omdbapi.com/?apikey=2618e734&page=" + i + "&s=" + TB_Search.Text)).Result;

                    SearchResults sr = JsonConvert.DeserializeObject<SearchResults>(response);
                    sr.Search.ForEach(r => { totalResults.Add(r); });
                }
                List<SearchResult> sortedResults = totalResults.OrderBy(r => r.Year).ToList();
                SP_Search.Children.Clear();
                foreach (SearchResult result in sortedResults)
                {
                    Button button = new Button();
                    button.Background = new SolidColorBrush(Colors.WhiteSmoke);
                    button.Height = 25;
                    button.Content = result.Title + " (" + result.Year + ")";
                    SP_Search.Children.Add(button);
                    button.Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string title = ((Button)sender).Content.ToString();
                title = title.Substring(0, title.IndexOf('(')).Trim();
                var response = httpClient.GetStringAsync(new Uri("http://www.omdbapi.com/?apikey=2618e734&plot=full&t=" + title)).Result;
                Film film = JsonConvert.DeserializeObject<Film>(response);
                G_Content.Children.Clear();
                film.BuildContent(ref G_Content);
                Console.WriteLine(G_Content.Children.Count);
            }
        }
    }
}
