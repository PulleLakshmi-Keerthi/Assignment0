using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace PhotoGallery.Model
{
    public class PhotoManger
    {
        List<Photo> PhotoObj = new List<Photo>();
        public void GetAllPhotos(ObservableCollection<Photo> photos)
        {
           
           photos.Clear();
            PhotoObj.ForEach(photo => photos.Add(photo));
        }

        

        public async void UploadImages() {
            
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            picker.FileTypeFilter.Add(".jpg");
            picker.FileTypeFilter.Add(".jpeg");
            picker.FileTypeFilter.Add(".png");
            var files = await picker.PickMultipleFilesAsync();
            
            if (files.Count > 0)
            {
                                
                foreach (Windows.Storage.StorageFile file in files)
                {
                    PhotoObj.Add(new Photo(file.Name,file.Path));
                }
                
            }
            int i = 0;
           
        }


    }
}
