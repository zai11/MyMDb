using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace MyMDb
{
    class Film
    {
        private string title;
        private string year;
        private string rated;
        private string released;
        private string runtime;
        private string genre;
        private string director;
        private string writer;
        private string actors;
        private string plot;
        private string language;
        private string country;
        private string awards;
        private string poster;
        private List<Rating> ratings = new List<Rating>();
        private string type;
        private string dvd;
        private string boxOffice;
        private string production;
        private string website;

        public string Title { get; set; }
        public string Year { get; set; }
        public string Rated { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Awards { get; set; }
        public string Poster { 
            
            get { return poster; } 
        
            set
            {
                if (value.Equals("N/A") || value == null)
                    poster = "https://safetyaustraliagroup.com.au/wp-content/uploads/2019/05/image-not-found.png";
                else
                    poster = value;
            }

        }

        public List<Rating> Ratings
        {
            get { return ratings; }
        }

        public string Type { get; set; }

        public string DVD { get; set; }

        public string BoxOffice { get; set; }

        public string Production { get; set; }

        public string Website { get; set; }

        public void BuildContent(ref Grid G_Content)
        {
            Grid topGrid = new Grid();
            ColumnDefinition cd1 = new ColumnDefinition
            {
                Width = new GridLength(1, GridUnitType.Star)
            };
            ColumnDefinition cd2 = new ColumnDefinition
            {
                Width = new GridLength(2, GridUnitType.Star)
            };
            ColumnDefinition cd3 = new ColumnDefinition
            {
                Width = new GridLength(2, GridUnitType.Star)
            };
            topGrid.ColumnDefinitions.Add(cd1);
            topGrid.ColumnDefinitions.Add(cd2);
            topGrid.ColumnDefinitions.Add(cd3);
            Image poster = new Image();
            if (Poster != null)
            {
                poster.Source = new BitmapImage(new Uri(Poster));
            }
            StackPanel stackPanelLeft = new StackPanel();
            Label labelTitle = new Label
            {
                Name = "L_Title",
                Height = 20,
                Padding = new Thickness(0),
                Margin = new Thickness(0, 5, 0, 0),
                FontSize = 15,
                FontWeight = FontWeights.Bold,
                Content = Title + " (" + Year + ")"
            };
            Label labelGenre = new Label
            {
                Name = "L_Genre",
                Height = 20,
                Padding = new Thickness(0),
                FontSize = 13,
                Content = "Genre: " + Genre
            };
            Label labelReleased = new Label
            {
                Name = "L_Released",
                Height = 20,
                Padding = new Thickness(0),
                FontSize = 13,
                Content = "Released: " + Released
            };
            Label labelRated = new Label
            {
                Name = "L_Rated",
                Height = 20,
                Padding = new Thickness(0),
                FontSize = 13,
                Content = "Rated: " + Rated
            };
            Label labelLanguage = new Label
            {
                Name = "L_Language",
                Height = 20,
                Padding = new Thickness(0),
                FontSize = 13,
                Content = "Language: " + Language
            };
            Label labelBoxOffice = new Label
            {
                Name = "L_BoxOffice",
                Height = 20,
                Padding = new Thickness(0),
                FontSize = 13,
                Content = "Box Office: " + BoxOffice
            };
            stackPanelLeft.Children.Add(labelTitle);
            stackPanelLeft.Children.Add(labelGenre);
            stackPanelLeft.Children.Add(labelReleased);
            stackPanelLeft.Children.Add(labelRated);
            stackPanelLeft.Children.Add(labelLanguage);
            stackPanelLeft.Children.Add(labelBoxOffice);
            RowDefinition rd1 = new RowDefinition
            {
                Height = new GridLength(1, GridUnitType.Star)
            };
            RowDefinition rd2 = new RowDefinition
            {
                Height = new GridLength(10, GridUnitType.Star)
            };
            Grid gridRight = new Grid();
            gridRight.RowDefinitions.Add(rd1);
            gridRight.RowDefinitions.Add(rd2);
            Label labelPlot = new Label
            {
                Name = "L_Plot",
                HorizontalAlignment = HorizontalAlignment.Center,
                FontSize = 15,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 5, 0, 0),
                Padding = new Thickness(0),
                Content = "Plot:"
            };
            ScrollViewer scrollViewerPlot = new ScrollViewer()
            {
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto
            };
            TextBlock textBlockPlot = new TextBlock()
            {
                Name = "TB_Plot",
                TextWrapping = TextWrapping.Wrap,
                FontSize = 13,
                Text = Plot
            };
            scrollViewerPlot.Content = textBlockPlot;
            Grid.SetRow(labelPlot, 0);
            Grid.SetRow(scrollViewerPlot, 1);
            gridRight.Children.Add(labelPlot);
            gridRight.Children.Add(scrollViewerPlot);
            Grid.SetColumn(poster, 0);
            Grid.SetColumn(stackPanelLeft, 1);
            Grid.SetColumn(gridRight, 2);
            topGrid.Children.Add(poster);
            topGrid.Children.Add(stackPanelLeft);
            topGrid.Children.Add(gridRight);
            StackPanel stackPanelMid = new StackPanel
            {
                Margin = new Thickness(0, 10, 0, 0)
            };
            Label labelCast = new Label
            {
                Name = "L_Cast",
                HorizontalAlignment = HorizontalAlignment.Center,
                FontSize = 15,
                FontWeight = FontWeights.Bold,
                Content = "Cast:"
            };
            StackPanel stackPanelCast = new StackPanel()
            {
                Name = "SP_Cast",
                VerticalAlignment = VerticalAlignment.Center
            };
            Label labelDirector = new Label
            {
                Name = "L_Director",
                Height = 20,
                Padding = new Thickness(0),
                HorizontalContentAlignment = HorizontalAlignment.Center,
                FontSize = 13,
                Content = "Director: " + Director
            };
            Label labelWriter = new Label
            {
                Name = "L_Writer",
                Height = 20,
                Padding = new Thickness(0),
                HorizontalContentAlignment = HorizontalAlignment.Center,
                FontSize = 13,
                Content = "Writer: " + Writer
            };
            Label labelActors = new Label
            {
                Name = "L_Actors",
                Height = 20,
                Padding = new Thickness(0),
                HorizontalContentAlignment = HorizontalAlignment.Center,
                FontSize = 13,
                Content = "Actors: " + Actors
            };
            stackPanelCast.Children.Add(labelDirector);
            stackPanelCast.Children.Add(labelWriter);
            stackPanelCast.Children.Add(labelActors);
            stackPanelMid.Children.Add(labelCast);
            stackPanelMid.Children.Add(stackPanelCast);
            StackPanel stackPanelBottom = new StackPanel
            {
                Margin = new Thickness(0, 10, 0, 10)
            };
            Label labelRatings = new Label
            {
                Name = "L_Ratings",
                HorizontalAlignment = HorizontalAlignment.Center,
                FontSize = 15,
                FontWeight = FontWeights.Bold,
                Content = "Ratings:"
            };
            StackPanel stackPanelRatings = new StackPanel
            {
                Name = "SP_Ratings",
                VerticalAlignment = VerticalAlignment.Center
            };
            foreach (Rating rating in Ratings)
            {
                Label label = new Label
                {
                    Name = "L_" + rating.Source.Replace(" ", ""),
                    Height = 20,
                    Padding = new Thickness(0),
                    HorizontalContentAlignment = HorizontalAlignment.Center,
                    FontSize = 13,
                    Content = rating.Source + ": " + rating.Value
                };
                stackPanelRatings.Children.Add(label);
            }
            stackPanelBottom.Children.Add(labelRatings);
            stackPanelBottom.Children.Add(stackPanelRatings);
            Grid.SetRow(topGrid, 0);
            Grid.SetRow(stackPanelMid, 1);
            Grid.SetRow(stackPanelBottom, 2);
            G_Content.Children.Add(topGrid);
            G_Content.Children.Add(stackPanelMid);
            G_Content.Children.Add(stackPanelBottom);
        }
    }
}
