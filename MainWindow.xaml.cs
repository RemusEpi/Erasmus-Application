using ErasmusApplication.Context.MainContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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

namespace ErasmusApplication
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

        private void Window_ContentRendered(object sender, EventArgs e)
        { }
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainContext oCSIMainContext = this.DataContext as MainContext;
            if (null != oCSIMainContext)
            {
               // oCSIMainContext.DoLogin();
            }
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            MainContext oCSIMainContext = this.DataContext as MainContext;
            if (null != oCSIMainContext)
            {
               // oCSIMainContext.DoClose();
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MainContext oCSIMainContext = this.DataContext as MainContext;
            if (null != oCSIMainContext)
            {
                //oCSIMainContext.DoClose();
            }
        }


        /// <summary>
        /// Manage the exit event, which closes the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Event_CloseWindow(object sender, RoutedEventArgs e)
        {
            //Close the MainWindow
            this.Close();
        }
    }
}
