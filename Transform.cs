using System.Drawing;

namespace ImageEdit {
    static class Transform {
        // class storing data and methods used to transform image (rotate / flip)

        public enum TransformOptions
        {
            // enum storing transformation options
            ROTATE_LEFT = RotateFlipType.Rotate270FlipNone,
            ROTATE_RIGHT = RotateFlipType.Rotate90FlipNone,
            FLIP_Y_AXIS = RotateFlipType.RotateNoneFlipX,       // switched X and Y, seems to make more sense to me, despite microsoft naming
            FLIP_X_AXIS = RotateFlipType.RotateNoneFlipY
        }

        public static void TransformBitmap(Bitmap bitmap, TransformOptions type)
        {
            // transforms image using given transformation option
            bitmap.Data.RotateFlip((RotateFlipType)type);

        }
    }
}