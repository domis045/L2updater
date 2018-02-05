using System;
using System.Collections.Generic;
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
// apacioj
/*using System.Windows.Forms;
using System.Drawing;*/
// mano pridetas
//using System.Timers.Timer;
//using System.Timers;
/*
 * Config File
 */
using System.IO;
using System.Xml;
using System.Xml.Serialization;
/*
 * Config File
 */

namespace L2Updater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            narsykle.Navigate("http://www.goo");
        }
        // window move drag function
        private void window_drag_function(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        // exit button function
        private void Exit_Button(object sender, RoutedEventArgs e)
        {
            var response = MessageBox.Show("Do you really want to exit?", "",
                       MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (response == MessageBoxResult.No)
            {

            }
            else
            {
                Application.Current.Shutdown();
            }
        }
        // Slider clicable image 1
        private void Slider_img1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AD.Source = new BitmapImage(new Uri("../../l2post070822a.jpg", UriKind.RelativeOrAbsolute));
        }
        private void Slider_img2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AD.Source = new BitmapImage(new Uri("../../l2post070912a.jpg", UriKind.RelativeOrAbsolute));
        }
        private void Slider_img3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AD.Source = new BitmapImage(new Uri("../../l2post070919a.jpg", UriKind.RelativeOrAbsolute));
        }
        private void Slider_img4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AD.Source = new BitmapImage(new Uri("../../l2post071001a.jpg", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            File_Download_Proggres_bar.Value = File_Download_Proggres_bar.Value + 1;
            TotalProgress_Proggres_bar.Value = File_Download_Proggres_bar.Value;
        }

        private void Settings_button_topleft_Click(object sender, RoutedEventArgs e)
        {
            if(config_popup.Visibility == Visibility.Hidden)
            {
            config_popup.Visibility = Visibility.Visible;
            }
            else
            {
                config_popup.Visibility = Visibility.Hidden;
            }
        }

        //public bool Login_Music_bool{ get; set; }
        // muzikos checkboxas
        private void Login_Music_Checked(object sender, RoutedEventArgs e)
        {
            Lineage_2____Hunters_Village_mp3.Play();
            Music_debugger.Content = "Debugger: Music Running"; 
        }
        private void Login_Music_Unchecked(object sender, RoutedEventArgs e)
        {
            Lineage_2____Hunters_Village_mp3.Stop();
            Music_debugger.Content = "Debugger: Music Stopped";
        }

        private void Lineage_2____Hunters_Village_mp3_MediaEnded(object sender, RoutedEventArgs e)
        {
           // Lineage_2____Hunters_Village_mp3.Position = TimeSpan.FromMilliseconds(1);
            Lineage_2____Hunters_Village_mp3.Position = TimeSpan.FromSeconds(2);
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            Username.Text = "";
        }
    }
}
// www.google.lt/#q=wpf+external+config+file
//www.stackoverflow.com/questions/11296897/repeating-a-function-every-few-seconds