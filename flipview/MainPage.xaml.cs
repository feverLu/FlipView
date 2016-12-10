using FlipViewDemo.Model;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace FlipViewDemo
{
    public sealed partial class MainPage : Page
    {
        public List<SampleItem> flipViewData { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            flipViewData = new List<SampleItem>();
            flipViewData.Add(new SampleItem() { Name = "Item 1", Image = "Assets/images/hotel.jpg" });
            flipViewData.Add(new SampleItem() { Name = "Item 2", Image = "Assets/images/hotel (2).jpg" });
            flipViewData.Add(new SampleItem() { Name = "Item 3", Image = "Assets/images/hotel (3).jpg" });
            flipViewData.Add(new SampleItem() { Name = "Item 4", Image = "Assets/images/hotle.jpg" });
            flipViewData.Add(new SampleItem() { Name = "Item 5", Image = "Assets/images/avalanche (2).jpg" });
            flipView1.ItemsSource = flipViewData;
        }
    }
}
