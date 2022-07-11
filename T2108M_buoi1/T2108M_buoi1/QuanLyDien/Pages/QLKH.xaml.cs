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
using QuanLyDien.Services;
using QuanLyDien.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace QuanLyDien.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class QLKH : Page
    {
        public QLKH()
        {
            this.InitializeComponent();
            CustomerServices ss = new CustomerServices();
            CustomerList.ItemsSource = ss.All();
        }

        private void GridViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Customer s = CustomerList.SelectedItem as Customer;
            MainPage.MainContent.Navigate(typeof(Pages.CustomerForm));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainPage.MainContent.Navigate(typeof(Pages.CustomerForm));
        }
    }
}
