using PackingList.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using PackingList.Models;
using PackingList.UserControls;
using Windows.Networking.Connectivity;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PackingList
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            if (!isInternet())
                showNoWifiDialog();
        }

        private async void showNoWifiDialog()
        {
            ContentDialog noWifi = new ContentDialog()
            {
                Title = "No wifi connection",
                Content = "Check your connection and try again",
                PrimaryButtonText = "OK"
            };
            await noWifi.ShowAsync();
        }

        public static bool isInternet()
        {
            ConnectionProfile connections = NetworkInformation.GetInternetConnectionProfile();
            return connections != null && connections.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess;
        }

        private void splitViewButton_Click(object sender, RoutedEventArgs e)
        {
            splitView.IsPaneOpen = !splitView.IsPaneOpen;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (list.SelectedIndex)
            {
                case 0:
                    mainContent.Content = new UCReizen();
                    break;
                case 1:
                    mainContent.Content = new UCTaken();
                    break;
                case 2:
                    mainContent.Content = new UCItems();
                    break;
                    //books, settings...
            }
        }
    }
}
