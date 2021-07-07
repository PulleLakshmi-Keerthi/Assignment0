using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGallery.Model
{
    class PhotoManager
    {

        public static void GetAllPhotos(ObservableCollection<Photo> photos)
        {
            var alls = getSounds();
            sounds.Clear();
            allSounds.ForEach(sound => sounds.Add(sound));
        }

    }
}
