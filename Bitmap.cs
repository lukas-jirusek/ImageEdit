using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ImageEdit
{
    class Bitmap
    {
        // class storing image as bitmap

        public System.Drawing.Bitmap Data { get; private set; }
        public string Path { get; private set; }
        public string Filename { get; private set; }

        public Bitmap(string path = null)
        {
            // Bitmap constructor 
            if (path != null)
                LoadImage(path);
        }


        public void LoadImage(string path)
        {
            // Loads image from given path

            // do not use System.Drawing.Bitmap.FromFile(path) or System.Drawing.Bitmap(path)
            // as it locks the input file which later complicates saving the file, especially if overwriting it
            // instead read the whole file to bytes, convert them to memory stream and convert this stream to bitmap

            byte[] bytes = File.ReadAllBytes(path);
            Data = (System.Drawing.Bitmap)Image.FromStream(new MemoryStream(bytes));
            this.Path = path;
            Filename = System.IO.Path.GetFileName(path);
        }

        public void SaveImage(string path, ImageFormat format)
        {
            // saves image in given format to path

            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write)) {
                Data.Save(fs, format);
            }
        }

        public void SetBitmap(System.Drawing.Bitmap newData)
        {
            // sets image inside bitmap

            Data = newData;
        }


        public void ApplyTransform(Transform.TransformOptions t) 
        {
            // applies chosen transformation to image

            Transform.TransformBitmap(this, t);
        }

        public void ApplyFilter(Filter.FilterOptions f) 
        {
            // applies chosen filter to image

            Filter.ApplyFilter(this, f);
        }
    }
}
