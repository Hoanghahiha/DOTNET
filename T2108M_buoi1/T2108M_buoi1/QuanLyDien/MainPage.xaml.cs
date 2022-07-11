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
using QuanLyDien.Helper;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace QuanLyDien
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static Frame MainContent;
        public MainPage()
        {// mainframe ở đây là khi mở hiện luôn ra trang home
            this.InitializeComponent();
            MainFrame.Navigate(typeof(Pages.Account));
            SQLiteHelper sq = SQLiteHelper.GetInstance();
            MainContent = MainFrame;
        }

        private void QLKH_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.QLKH));
        }

        private void KhachHang_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.Account));
        }
    }
}
