using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery.Model
{
   public class Photo
    {
        public string PhotoFile { get; set; }
        public string PhotoName { get; set; }

        public Photo(string photoname,string photofile)
        {
            
            PhotoName = photoname;
            PhotoFile = photofile;

        }
    }
}
