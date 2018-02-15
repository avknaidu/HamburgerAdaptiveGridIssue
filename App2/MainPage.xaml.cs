using Microsoft.Toolkit.Uwp.UI.Controls;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App2
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void HamburgerMenu_ItemInvoked(object sender, HamburgetMenuItemInvokedEventArgs e)
        {
            ObservableCollection<string> Items = new ObservableCollection<string>();
            for (int i = 0; i < 25; i++)
            {
                Items.Add(i.ToString());
            }
            myGrid.ItemsSource = Items;
        }
    }
}
