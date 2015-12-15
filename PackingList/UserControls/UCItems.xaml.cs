using PackingList.Models;
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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace PackingList.UserControls
{
    public sealed partial class UCItems : UserControl
    {
        private MainViewModel vm = new MainViewModel();

        private Reis currentReis;
        public UCItems(MainViewModel vm, Reis reis)
        {
            this.vm = vm;
            InitializeComponent();
            currentReis = reis;
            loadData();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView lv = (ListView)sender;
            Reis geselecteerdeReis = lv.SelectedItem as Reis;
            var frame = Window.Current.Content as Frame;
            frame.Navigate(typeof(ReisItems), geselecteerdeReis);
        }

        public async void loadData()
        {
            // items komen van de view
            /*ListItems.ItemsSource = await vm.GetItems(currentTrip);
            LoadingItems.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            LoadingItems.IsEnabled = false;*/
        }
    }
}
