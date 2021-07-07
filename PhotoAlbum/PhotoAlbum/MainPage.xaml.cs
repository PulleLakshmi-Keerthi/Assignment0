using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using PhotoAlbum.Model;
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

namespace PhotoAlbum
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Photo> Photos;
        private List<MenuItem> MenuItems;

        public MainPage()
        {
            this.InitializeComponent();
            Photos = new ObservableCollection<Photo>();
            PhotoManager.GetAllPhotos(Photos);


            MenuItems = new List<MenuItem>
            {
                new MenuItem
                {
                    Category = SoundCategory.Animals,
                    IconFile = "/Assets/Icons/animals.png"
                },
                new MenuItem
                {
                    Category = SoundCategory.Cartoons,
                    IconFile = "/Assets/Icons/cartoon.png"
                },
                new MenuItem
                {
                    Category = SoundCategory.Taunts,
                    IconFile = "/Assets/Icons/taunt.png"
                },
                new MenuItem
                {
                    Category = SoundCategory.Warnings,
                    IconFile = "/Assets/Icons/warning.png"
                },

            };


        }

        
        private void AllAlbumsView_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void CreateNewAlbum_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
