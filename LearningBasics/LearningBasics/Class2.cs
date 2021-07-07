using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LearningBasics
{
    class Class2
    {
        public List<string> getPhotoFile()
        {
            var dataGridImage = new List<string>();
            string path = @"C:\Users\Purnima\source\repos\LearningBasics\LearningBasics\Photos\";
            string[] filePaths = Directory.GetFiles(path, "*.jpg");
            for (int i = 0; i < filePaths.Length; i++)
            {
                dataGridImage.Add(filePaths[i]);
                Uri uri = new Uri($"{filePaths[i]}");
                Console.WriteLine(filePaths[i].Split(Path.DirectorySeparatorChar).Last());

            }
            return dataGridImage;

        }



    }
}
