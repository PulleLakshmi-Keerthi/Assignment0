using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using PhotoGallery.Model;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PhotoGallery
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Photo> Photos;
        public MainPage()
        {
            this.InitializeComponent();
            Photos = new ObservableCollection<Photo>();
            PhotoManger obj1 = new PhotoManger();
            obj1.GetAllPhotos(Photos);

        }

        private void AllPhotosView_ItemClick(object sender, ItemClickEventArgs e)
        {
            

        }

        private void browse_Click(object sender, RoutedEventArgs e)
        {

            var photos = new List<Photo>();
            PhotoManger obj = new PhotoManger();
            obj.UploadImages();
           
        
            /*BitmapImage bitmapImage = new BitmapImage();
            
            bitmapImage.UriSource = new Uri(img.BaseUri, "Assets/StoreLogo.png");
            AllPhotos.Source = bitmapImage;*/
        }
    }
}
