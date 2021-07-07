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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ImageGallery
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public partial class MainPage : Page
    {
       static int i = 1;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void goNext_Click(object sender, RoutedEventArgs e)
        {
            i++; // increase i by 1

            // if i's value gets larger than 6 then reset i back to 1

            if (i > 6)
            {
                i = 1;
            }
            

            picHolder.Source = new BitmapImage(new Uri($"ms-appx:///pics/{i}.jpg"));
        }

        private void goBack_Click(object sender, RoutedEventArgs e)
        {
            i--; // this will decrease 1 from i


            // if the value of i is less than 1
            // then give i the value of 6
            if (i < 1)
            {
                i = 6;
            }

            // change the picture according to the i's value
            picHolder.Source = new BitmapImage(new Uri($"ms-appx:///pics/{i}.jpg"));
        }
    }
}
