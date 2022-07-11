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
using T2108M_UWP.Services;
using T2108M_UWP.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2108M_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class QLSP : Page
    {
        public QLSP()
        {
            this.InitializeComponent();
            ProductService ss = new ProductService();
            ProductList.ItemsSource = ss.All();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainPage.MainContent.Navigate(typeof(Pages.ProductForm));
        }

        private void GridViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Product s = ProductList.SelectedItem as Product;
            MainPage.MainContent.Navigate(typeof(Pages.ProductForm));
        }
    }
}
