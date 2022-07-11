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
using T2108M_UWP.Models;
using T2108M_UWP.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2108M_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StudentForm : Page
    {
        private bool edited = false;
        public StudentForm()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(sID.Text);
            string name = sName.Text;
            int age = Convert.ToInt32(sAge.Text);
            string address = sAddress.Text;
            Student s = new Student() { Id = id, Name = name, Age = age, Address = address };
            StudentService ss = new StudentService();
            if (edited)
            {
                ss.Update(s);
            }
            else
            {
                ss.Create(s);
            }
            ss.Create(s);
            MainPage.MainContent.Navigate(typeof(Pages.QLSV));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if(e.Parameter != null)
            {
                Student s = e.Parameter as Student;
                sID.Text = s.Id.ToString();
                sName.Text = s.Name;
                sAge.Text = s.Age.ToString();
                sAddress.Text = s.Address;
                sID.IsReadOnly = true;

            }
        }
    }
}
