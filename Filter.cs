
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageEdit
{
    static class Filter
    {
        // class storing data and methods used to apply filter to image

        public enum FilterOptions
        {
            // enumeration storing filter type
            GREYSCALE,
            SEPIA,
            NEGATIVE,
            MONOCHROME,
            BRIGHTER,
            DARKER,
            MORE_COLOR,
            LESS_COLOR
        }

        private static class ColorMatrices
        {
            // class for storing color matrices used to apply filter
            public static ColorMatrix GREYSCALE = new ColorMatrix(new float[][]
            {
             new float[] {.3f, .3f, .3f, 0, 0},
             new float[] {.59f, .59f, .59f, 0, 0},
             new float[] {.11f, .11f, .11f, 0, 0},
             new float[] {0, 0, 0, 1, 0},
             new float[] {0, 0, 0, 0, 1}
            });
            public static ColorMatrix MONOCHROME = new ColorMatrix(new float[][]
            {
               new float[] { 1.5f, 1.5f, 1.5f, 0, 0 },
               new float[] { 1.5f, 1.5f, 1.5f, 0, 0 },
               new float[] { 1.5f, 1.5f, 1.5f, 0, 0 },
               new float[] { 0, 0, 0, 1, 0 },
               new float[] { -1, -1, -1, 0, 1 }
            });
            public static ColorMatrix SEPIA = new ColorMatrix(new float[][]
            {
             new float[] {.393f, .349f, .272f, 0, 0},
             new float[] {.769f, .686f, .534f, 0, 0},
             new float[] {.189f, .168f, .131f, 0, 0},
             new float[] {0, 0, 0, 1, 0},
             new float[] {0, 0, 0, 0, 1}
            });
            public static ColorMatrix NEGATIVE = new ColorMatrix(new float[][]
            {
             new float[] {-1, 0, 0, 0, 0},
             new float[] {0, -1, 0, 0, 0},
             new float[] {0, 0, -1, 0, 0},
             new float[] {0, 0, 0, 1, 0},
             new float[] {1, 1, 1, 0, 1}
            });
            public static ColorMatrix BRIGHTER = new ColorMatrix(new float[][]
            {
             new float[] {1, 0, 0, 0, 0},
             new float[] {0, 1, 0, 0, 0},
             new float[] {0, 0, 1, 0, 0},
             new float[] {0, 0, 0, 1, 0},
             new float[] {0.05f, 0.05f, 0.05f, 0, 1}
            });
            public static ColorMatrix DARKER = new ColorMatrix(new float[][]
            {
             new float[] {1, 0, 0, 0, 0},
             new float[] {0, 1, 0, 0, 0},
             new float[] {0, 0, 1, 0, 0},
             new float[] {0, 0, 0, 1, 0},
             new float[] {-0.05f, -0.05f, -0.05f, 0, 1}
            });
            public static ColorMatrix MORE_COLOR = new ColorMatrix(new float[][]
            {
             new float[] {1.2f, 0, 0, 0, 0},
             new float[] {0, 1.2f, 0, 0, 0},
             new float[] {0, 0, 1.2f, 0, 0},
             new float[] {0, 0, 0, 1, 0},
             new float[] {0, 0, 0, 0, 1}
            });
            public static ColorMatrix LESS_COLOR = new ColorMatrix(new float[][]
            {
             new float[] {0.8f, 0, 0, 0, 0},
             new float[] {0, 0.8f, 0, 0, 0},
             new float[] {0, 0, 0.8f, 0, 0},
             new float[] {0, 0, 0, 1, 0},
             new float[] {0, 0, 0, 0, 1}
            });
        }

        private static readonly Dictionary<FilterOptions, ColorMatrix> filters = new Dictionary<FilterOptions, ColorMatrix>
        // dictionary mapping filter type to color matrix
        {
            {FilterOptions.GREYSCALE, ColorMatrices.GREYSCALE},
            {FilterOptions.SEPIA, ColorMatrices.SEPIA},
            {FilterOptions.NEGATIVE, ColorMatrices.NEGATIVE},
            {FilterOptions.MONOCHROME, ColorMatrices.MONOCHROME},
            {FilterOptions.BRIGHTER, ColorMatrices.BRIGHTER},
            {FilterOptions.DARKER, ColorMatrices.DARKER},
            {FilterOptions.MORE_COLOR, ColorMatrices.MORE_COLOR},
            {FilterOptions.LESS_COLOR, ColorMatrices.LESS_COLOR}
        };

        private static ImageAttributes GetAttributes(FilterOptions f)
        // returns ImageAttributes for given filter
        {
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(filters[f]);
            if (f == FilterOptions.MONOCHROME)
            {
                attributes.SetThreshold(0.8f);
            }
            return attributes;
        }

        public static void ApplyFilter(Bitmap bitmap, FilterOptions filter) {
            // applies chosen filter to image

            // used code from https://web.archive.org/web/20110827032809/http://www.switchonthecode.com/tutorials/csharp-tutorial-convert-a-color-image-to-grayscale
            // in order to make filters fast using ColorMatrix, with manual iteration using for loop and .Get/.Set Pixel took too long
            //create a blank bitmap the same size as original

            System.Drawing.Bitmap newBitmap = new System.Drawing.Bitmap(bitmap.Data.Width, bitmap.Data.Height);

            //get a graphics object from the new image
            using (Graphics g = Graphics.FromImage(newBitmap))
            {
                g.DrawImage(bitmap.Data,                            // source image
                            new Rectangle(0,                        // destination rectangle
                                          0,
                                          bitmap.Data.Width,
                                          bitmap.Data.Height
                            ),
                            0,                                      // source x origin
                            0,                                      // source y origin 
                            bitmap.Data.Width,                      // source width
                            bitmap.Data.Height,                     // source height
                            GraphicsUnit.Pixel,                     // unit
                            GetAttributes(filter)                   // image attributes
                );
            }
            bitmap.SetBitmap(newBitmap);
        }
    }
}
