using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ImageEdit
{
    public partial class ImageEditForm : Form
    {
        // list of images opened by program
        private readonly List<Bitmap> images;

        // currently chosen image for easier access
        private Bitmap currentImage;

        // list storing buttons that are enabled when there is any photo opened (disabled otherwise)
        private List<Button> enableableButtons;

        // dictionary for paiting buttons and transformations
        private Dictionary<Button, Transform.TransformOptions> transformations;

        // dictionary for pairing buttons and filters
        private Dictionary<Button, Filter.FilterOptions> filters;



        // data initialization

        public ImageEditForm()
        {
            /* initializes form, especially starts empty list of images */
            InitializeComponent();
            images = new List<Bitmap>();
            InitilizeData();
            AddTextToLog("Program launched");
            this.pictureBox.MouseWheel += PictureBoxMouseScroll;
        }

        private void InitilizeData()
        {
            /* stores enableable buttons in a list, matches buttons to enums using dictionary */
            enableableButtons = new List<Button> {
                btnRemove, btnRemoveAll,                        // remove buttons
                btnSaveImage,                                   // save button
                btnTransRotateLeft, btnTransRotateRight,        // transform buttons
                btnTransFlipY, btnTransFlipX,
                btnFilterGreyscale, btnFilterSepia,             // filter buttons
                btnFilterNegative, btnFilterMono,
                btnFilterBrighter, btnFilterDarker,
                btnFilterMoreColor, btnFilterLessColor,
                btnOpenFolder, btnOpenOriginal                  // open original image / folder
            };

            transformations = new Dictionary<Button, Transform.TransformOptions> {
                { btnTransRotateLeft, Transform.TransformOptions.ROTATE_LEFT },
                { btnTransRotateRight, Transform.TransformOptions.ROTATE_RIGHT },
                { btnTransFlipX, Transform.TransformOptions.FLIP_X_AXIS },
                { btnTransFlipY, Transform.TransformOptions.FLIP_Y_AXIS }
            };

            filters = new Dictionary<Button, Filter.FilterOptions> {
                { btnFilterGreyscale, Filter.FilterOptions.GREYSCALE },
                { btnFilterSepia, Filter.FilterOptions.SEPIA },
                { btnFilterNegative, Filter.FilterOptions.NEGATIVE },
                { btnFilterMono, Filter.FilterOptions.MONOCHROME },
                { btnFilterBrighter, Filter.FilterOptions.BRIGHTER },
                { btnFilterDarker, Filter.FilterOptions.DARKER },
                { btnFilterMoreColor, Filter.FilterOptions.MORE_COLOR },
                { btnFilterLessColor, Filter.FilterOptions.LESS_COLOR }
            };

            // save dialog has to be set up only once
            savePictureDialog.Filter = "JPeg Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp|Gif Image|*.gif";
            savePictureDialog.Title = "Save an Image File";
            savePictureDialog.DefaultExt = "JPeg Image|*.jpg";
        }



        // adding images

        private void AddImage(string filename)
        {
            /* adds one image to program */
            if (!File.Exists(filename))
            {
                AddTextToLog("Image " + filename + " does not exist.", Color.Red);
            }
            Bitmap image;
            try
            {
                image = new Bitmap(filename);
            }
            catch (Exception e)
            {
                AddTextToLog("Error opening '" + filename + "' :" + e.Message, Color.Red);
                return;
            }

            images.Add(image);
            AddTextToLog("Image " + image.Filename + " added.");
            dropMenuOpened.Items.Add(image.Filename);
        }

        private void LoadImages(object sender = null, EventArgs e = null)
        {
            /* uses dialog to open one or more image files */
            if (openPicturesDialog.ShowDialog() == DialogResult.OK)
            {
                // start progress bar, usually visible only if opening multiple files at once
                StartProgressBar();
                StartWait();
                foreach (string file in openPicturesDialog.FileNames)
                {
                    AddImage(file);
                    IncreaseProgressBar();
                }
                if (dropMenuOpened.Items.Count > 0)
                {
                    dropMenuOpened.SelectedIndex = dropMenuOpened.Items.Count - 1;
                    EnableComponents();
                }
                EndProgressBar();
                EndWait();
            }
        }



        // removing images

        private void RemoveImage(object sender = null, EventArgs e = null)
        {
            // removes current image from program    ! not from hard drive !
            int removedIndex = dropMenuOpened.SelectedIndex;
            AddTextToLog("Image " + currentImage.Filename + " removed.");
            dropMenuOpened.Items.RemoveAt(dropMenuOpened.SelectedIndex);
            images[removedIndex].Data.Dispose();
            images.RemoveAt(removedIndex);
            if (removedIndex == dropMenuOpened.Items.Count)
            {
                removedIndex--;
            }
            dropMenuOpened.SelectedIndex = removedIndex;
            if (dropMenuOpened.Items.Count == 0)
            {
                DisableComponents();
                pictureBox.Image = null;
                currentImage = null;
                this.Text = "ImageEdit";
            }
        }

        private void RemoveAllImages(object sender, EventArgs e)
        {
            // removes all images from program
            while (dropMenuOpened.Items.Count > 0)
            {
                RemoveImage();
            }
        }



        // saving image
        private void SaveImage(object sender = null, EventArgs e = null)
        {
            // saves current image using saveFileDialog
            if (currentImage == null)
            {
                return;
            }
            List<ImageFormat> formats = new List<ImageFormat> { ImageFormat.Jpeg, ImageFormat.Png, ImageFormat.Bmp, ImageFormat.Gif };
            savePictureDialog.FileName = currentImage.Filename;
            savePictureDialog.InitialDirectory = Path.GetDirectoryName(currentImage.Path);
            if (savePictureDialog.ShowDialog() == DialogResult.OK && savePictureDialog.FileName != "")
            {
                StartWait();
                try
                {
                    currentImage.SaveImage(savePictureDialog.FileName, formats[savePictureDialog.FilterIndex - 1]);
                    AddTextToLog("Image saved to " + savePictureDialog.FileName, Color.Green);
                }
                catch (Exception ex)
                {
                    AddTextToLog("Could not save image: " + ex.Message, Color.Red);
                }
                EndWait();
            }
        }

        // updating image

        private void UpdateImage()
        {
            // updates shown image
            pictureBox.Image = currentImage.Data;
            labelResolution.Text = $"{currentImage.Data.Width} * {currentImage.Data.Height}";
        }

        private void ChangedImage(object sender, EventArgs e)
        {
            // changes shown image
            currentImage = images[dropMenuOpened.SelectedIndex];
            UpdateImage();
            this.Text = "ImageEdit | " + currentImage.Filename;
            string text = $"Název : {currentImage.Filename}\n";
            text += $"Složka : {Path.GetDirectoryName(currentImage.Path)}\n";
            text += $"Vytvořeno : {File.GetCreationTime(currentImage.Path)}";
            labelPictureInfo.Text = text;
        }



        // logging functions

        public void AddTextToLog(string text) { AddTextToLog(text, Color.Black); }

        private void AddTextToLog(string text, Color color)
        {
            // adds text to log using given color
            textBoxLog.SelectionColor = color;
            textBoxLog.AppendText(String.Format("<{0:HH\\:mm\\:ss}> {1}\n", DateTime.Now, text));
            textBoxLog.ScrollToCaret();
        }



        // functions for editing image

        public void RotateFlipImage(object sender, EventArgs e)
        {
            // rotates or flips image using sender to detect what option was picked
            currentImage.ApplyTransform(transformations[(Button)sender]);
            UpdateImage();
        }

        public void ApplyFilter(object sender, EventArgs e)
        {
            // applies filter to image using sender to detect what option was picked
            StartWait();
            currentImage.ApplyFilter(filters[(Button)sender]);
            UpdateImage();
            EndWait();
        }



        // enabling / disabling buttons

        private void EnableComponents()
        {
            // enables buttons and drop down menu while disabling help label
            dropMenuOpened.Enabled = true;
            labelHelp.Visible = false;
            enableableButtons.ForEach(button => button.Enabled = true);
        }

        private void DisableComponents()
        {
            // disables buttons and drop down menu while enabling help label
            dropMenuOpened.Enabled = false;
            labelHelp.Visible = true;
            enableableButtons.ForEach(button => button.Enabled = false);
            labelResolution.Text = "";
            labelPictureInfo.Text = "";
        }



        // function related to progress bar

        private void StartProgressBar()
        {
            // starts progress bar used when opening files
            progressOpening.Maximum = openPicturesDialog.FileNames.Length;
            progressOpening.Value = 0;
            progressOpening.Visible = true;
        }

        private void EndProgressBar()
        {
            // hides progress bar
            progressOpening.Visible = false;
        }

        private void IncreaseProgressBar()
        {
            // progresses progress bar
            progressOpening.Value++;
        }




        // functions for waiting

        private void StartWait()
        {
            // starts waiting - disables buttons and changes cursor to wait
            Cursor.Current = Cursors.WaitCursor;
            enableableButtons.ForEach(button => button.Enabled = false);
        }

        private void EndWait()
        {
            // end waiting - enable buttons and reset cursor
            Cursor.Current = Cursors.Default;
            enableableButtons.ForEach(button => button.Enabled = true);
        }


        // open original functions 
        private void OpenSourceFolder(object sender, EventArgs e)
        {
            // opens folder of current image
            if (File.Exists(currentImage.Path))
            {
                Process.Start("explorer.exe", Path.GetDirectoryName(currentImage.Path));
                AddTextToLog("Opening folder " + Path.GetDirectoryName(currentImage.Path));
            }
            else {
                AddTextToLog("File " + currentImage.Path + " no longer exists.", Color.Red);
            }
        }

        private void OpenSource(object sender, EventArgs e)
        {
            // opens current image in default image viewer
            if (File.Exists(currentImage.Path))
            {
                Process.Start("explorer.exe", currentImage.Path);
                AddTextToLog("Opening image " + currentImage.Path);
            }
            else {
                AddTextToLog("File " + currentImage.Path + " no longer exists.", Color.Red);
            }
        }


        // function to jump to next / previous image

        private void NextImage() {
            // moves to next image, if any (used with keyboard shortcuts and mouse wheel)
            if (dropMenuOpened.SelectedIndex < dropMenuOpened.Items.Count - 1)
            {
                dropMenuOpened.SelectedIndex++;
            }
        }

        private void PreviousImage()
        {
            // moves to previous image, if any (used with keyboard shortcuts and mouse wheel)
            if (dropMenuOpened.SelectedIndex > 0)
            {
                dropMenuOpened.SelectedIndex--;
            }
        }


        // functions for handling keyboard or mouse events

        private void ImageEditForm_KeyDown(object sender, KeyEventArgs e)
        {
            // handles keyboard event
            /* shortcuts:
            Ctrl + S -> save current image
            Crtl + O -> open images
            Left or Up arrow -> previous image
            Down or Right arrow -> next image
            Escape -> remove button focus
            Delete -> remove image from program !NOT FROM HARD DRIVE!

            */
            if (e.KeyCode == Keys.S && e.Control)
            {
                SaveImage();
            }
            else if (e.KeyCode == Keys.O && e.Control)
            {
                LoadImages();
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Up)
            {
                PreviousImage();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Down)
            {
                NextImage();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape) {
                this.ActiveControl = null;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                RemoveImage();
            }
        }

        private void PictureBoxMouseScroll(object sender, MouseEventArgs e)
        {
            // handles mouse events
            /* available actions:
            Scroll up - jump to previous image
            Scroll down - jump to next image
            */
            if (e.Delta < 0)
            {
                NextImage();
            }
            else {
                PreviousImage();
            }
        }



        // cancel focus

        private void ImageClick(object sender, EventArgs e)
        {
            // removes focus when clicking image

            // sets active control to nothing, so that user can use arrows to move to previous / next image without moving active control
            this.ActiveControl = null;
        }


        // show help
        private void ShowHelp(object sender, EventArgs e) {
            string text =
@"Nápověda programu:
První otevřete obrázek v levém panelu, zde také můžete obrázek z programu smazat nebo jej uložit.
Poznámka: Smazání obrázku z programu nesmaže obrázek z pevného disku.

Po otevření obrázků můžete pomocí rozbalovacího seznamu měnit zobrazený obrázek, ten pak můžete v pravé části programu upravovat.
V současné době je možné obrázek otočit, převrátit, aplikovat vybrané filtry, zvýšit a snížit jas a nebo zvýšit nebo snížit barevnost.

V dolní části pravého panelu jsou také informace o obrázku a jeho originálu.
Je zde také možné otevřít původní obrázek a nebo složku kde se nachází.


Ovládání a klávesové zkratky:
Přesouvat se mezi obrázky jde také kolečkem myši, když je kurzor nad obrázkem.

Šipka vlevo / nahoru - předchozí obrázek    (funguje pouze pokud není zvolené tlačítko)
Šipka vpravo / dolu  - další obrázek        (funguje pouze pokud není zvolené tlačítko)
Poznámka: Zrušit výběr tlačítka jde provést kliknutím na obrázek nebo stisknutím klávesy Escape.

Ctrl + S - Uložit konkrétně otevřený obrázek
Ctrl + O - Otevřít obrázky
Delete   - Smaže obrázek z programu

Známé chyby / nedostatky:
Aplikace ukládá obrázky jako rastrový, nekompresovaný obrázek, i na jednoduchý obrázek je využito hodně paměti, při načítání více velkých obrázků dojde pamět. (Záleží na RAM počítače)

Autor: Lukáš Jirůšek, lukas.jirusek33@gmail.com
";

            MessageBox.Show(text, "Nápověda");
        }
    }
}
