namespace ImageEdit
{
    partial class ImageEditForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label labelMainLeft;
            System.Windows.Forms.Label labelMainRight;
            System.Windows.Forms.Label labelMainMiddle;
            System.Windows.Forms.TableLayoutPanel layoutMain;
            System.Windows.Forms.Label labelLog;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageEditForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnShowHelp = new System.Windows.Forms.Button();
            this.labelHelp = new System.Windows.Forms.Label();
            this.labelRemoveImage = new System.Windows.Forms.Label();
            this.labelSaveImage = new System.Windows.Forms.Label();
            this.labelOpenImage = new System.Windows.Forms.Label();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.progressOpening = new System.Windows.Forms.ProgressBar();
            this.textBoxLog = new System.Windows.Forms.RichTextBox();
            this.labelOpenedImages = new System.Windows.Forms.Label();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.dropMenuOpened = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.labelResolutionHeader = new System.Windows.Forms.Label();
            this.labelResolution = new System.Windows.Forms.Label();
            this.labelPictureInfoHeader = new System.Windows.Forms.Label();
            this.btnOpenOriginal = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.labelPictureInfo = new System.Windows.Forms.Label();
            this.layoutRight5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFilterLessColor = new System.Windows.Forms.Button();
            this.btnFilterMoreColor = new System.Windows.Forms.Button();
            this.labelColor = new System.Windows.Forms.Label();
            this.layoutRight4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFilterDarker = new System.Windows.Forms.Button();
            this.btnFilterBrighter = new System.Windows.Forms.Button();
            this.labelBrightness = new System.Windows.Forms.Label();
            this.layoutRight3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFilterNegative = new System.Windows.Forms.Button();
            this.btnFilterMono = new System.Windows.Forms.Button();
            this.btnFilterGreyscale = new System.Windows.Forms.Button();
            this.btnFilterSepia = new System.Windows.Forms.Button();
            this.labelFilter = new System.Windows.Forms.Label();
            this.layoutRight2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTransFlipY = new System.Windows.Forms.Button();
            this.btnTransFlipX = new System.Windows.Forms.Button();
            this.labelFlip = new System.Windows.Forms.Label();
            this.layoutRight1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTransRotateLeft = new System.Windows.Forms.Button();
            this.btnTransRotateRight = new System.Windows.Forms.Button();
            this.labelRotate = new System.Windows.Forms.Label();
            this.openPicturesDialog = new System.Windows.Forms.OpenFileDialog();
            this.savePictureDialog = new System.Windows.Forms.SaveFileDialog();
            labelMainLeft = new System.Windows.Forms.Label();
            labelMainRight = new System.Windows.Forms.Label();
            labelMainMiddle = new System.Windows.Forms.Label();
            layoutMain = new System.Windows.Forms.TableLayoutPanel();
            labelLog = new System.Windows.Forms.Label();
            layoutMain.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelRight.SuspendLayout();
            this.layoutRight5.SuspendLayout();
            this.layoutRight4.SuspendLayout();
            this.layoutRight3.SuspendLayout();
            this.layoutRight2.SuspendLayout();
            this.layoutRight1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMainLeft
            // 
            labelMainLeft.AutoSize = true;
            labelMainLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            labelMainLeft.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            labelMainLeft.Location = new System.Drawing.Point(4, 1);
            labelMainLeft.Name = "labelMainLeft";
            labelMainLeft.Size = new System.Drawing.Size(190, 25);
            labelMainLeft.TabIndex = 0;
            labelMainLeft.Text = "Správa obrázků";
            labelMainLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMainRight
            // 
            labelMainRight.AutoSize = true;
            labelMainRight.Dock = System.Windows.Forms.DockStyle.Fill;
            labelMainRight.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            labelMainRight.Location = new System.Drawing.Point(790, 1);
            labelMainRight.Name = "labelMainRight";
            labelMainRight.Size = new System.Drawing.Size(190, 25);
            labelMainRight.TabIndex = 2;
            labelMainRight.Text = "Úprava obrázku";
            labelMainRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMainMiddle
            // 
            labelMainMiddle.AutoSize = true;
            labelMainMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            labelMainMiddle.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            labelMainMiddle.Location = new System.Drawing.Point(201, 1);
            labelMainMiddle.Name = "labelMainMiddle";
            labelMainMiddle.Size = new System.Drawing.Size(582, 25);
            labelMainMiddle.TabIndex = 3;
            labelMainMiddle.Text = "Náhled obrázku";
            labelMainMiddle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutMain
            // 
            layoutMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            layoutMain.ColumnCount = 3;
            layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            layoutMain.Controls.Add(labelMainMiddle, 1, 0);
            layoutMain.Controls.Add(labelMainRight, 2, 0);
            layoutMain.Controls.Add(labelMainLeft, 0, 0);
            layoutMain.Controls.Add(this.panelLeft, 0, 1);
            layoutMain.Controls.Add(this.pictureBox, 1, 1);
            layoutMain.Controls.Add(this.panelRight, 2, 1);
            layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutMain.Location = new System.Drawing.Point(0, 0);
            layoutMain.Name = "layoutMain";
            layoutMain.RowCount = 2;
            layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            layoutMain.Size = new System.Drawing.Size(984, 511);
            layoutMain.TabIndex = 0;
            layoutMain.Click += new System.EventHandler(this.ImageClick);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btnShowHelp);
            this.panelLeft.Controls.Add(this.labelHelp);
            this.panelLeft.Controls.Add(this.labelRemoveImage);
            this.panelLeft.Controls.Add(this.labelSaveImage);
            this.panelLeft.Controls.Add(this.labelOpenImage);
            this.panelLeft.Controls.Add(this.btnSaveImage);
            this.panelLeft.Controls.Add(this.btnRemoveAll);
            this.panelLeft.Controls.Add(this.btnRemove);
            this.panelLeft.Controls.Add(this.progressOpening);
            this.panelLeft.Controls.Add(labelLog);
            this.panelLeft.Controls.Add(this.textBoxLog);
            this.panelLeft.Controls.Add(this.labelOpenedImages);
            this.panelLeft.Controls.Add(this.btnAddImage);
            this.panelLeft.Controls.Add(this.dropMenuOpened);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(4, 30);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(190, 477);
            this.panelLeft.TabIndex = 0;
            // 
            // btnShowHelp
            // 
            this.btnShowHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowHelp.Location = new System.Drawing.Point(3, 286);
            this.btnShowHelp.Name = "btnShowHelp";
            this.btnShowHelp.Size = new System.Drawing.Size(184, 25);
            this.btnShowHelp.TabIndex = 13;
            this.btnShowHelp.Text = "Zobrazit nápovědu programu";
            this.btnShowHelp.UseVisualStyleBackColor = true;
            this.btnShowHelp.Click += new System.EventHandler(this.ShowHelp);
            // 
            // labelHelp
            // 
            this.labelHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHelp.Location = new System.Drawing.Point(3, 97);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(184, 80);
            this.labelHelp.TabIndex = 12;
            this.labelHelp.Text = "Otevřete soubory pomocí tlačítka výše";
            this.labelHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRemoveImage
            // 
            this.labelRemoveImage.AutoSize = true;
            this.labelRemoveImage.Location = new System.Drawing.Point(3, 97);
            this.labelRemoveImage.Name = "labelRemoveImage";
            this.labelRemoveImage.Size = new System.Drawing.Size(89, 13);
            this.labelRemoveImage.TabIndex = 7;
            this.labelRemoveImage.Text = "Odebrat obrázek:";
            // 
            // labelSaveImage
            // 
            this.labelSaveImage.AutoSize = true;
            this.labelSaveImage.Location = new System.Drawing.Point(2, 178);
            this.labelSaveImage.Name = "labelSaveImage";
            this.labelSaveImage.Size = new System.Drawing.Size(77, 13);
            this.labelSaveImage.TabIndex = 8;
            this.labelSaveImage.Text = "Uložit obrázek:";
            // 
            // labelOpenImage
            // 
            this.labelOpenImage.AutoSize = true;
            this.labelOpenImage.Location = new System.Drawing.Point(3, 45);
            this.labelOpenImage.Name = "labelOpenImage";
            this.labelOpenImage.Size = new System.Drawing.Size(85, 13);
            this.labelOpenImage.TabIndex = 6;
            this.labelOpenImage.Text = "Otevřít obrázek:";
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveImage.Enabled = false;
            this.btnSaveImage.Location = new System.Drawing.Point(3, 194);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(184, 45);
            this.btnSaveImage.TabIndex = 4;
            this.btnSaveImage.Text = "Uložit obrázek jako";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.SaveImage);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAll.Enabled = false;
            this.btnRemoveAll.Location = new System.Drawing.Point(3, 147);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(184, 28);
            this.btnRemoveAll.TabIndex = 3;
            this.btnRemoveAll.Text = "Odstranit všechny obrázky";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.RemoveAllImages);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(3, 113);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(184, 28);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Odstranit obrázek";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.RemoveImage);
            // 
            // progressOpening
            // 
            this.progressOpening.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressOpening.Location = new System.Drawing.Point(3, 61);
            this.progressOpening.Name = "progressOpening";
            this.progressOpening.Size = new System.Drawing.Size(184, 33);
            this.progressOpening.TabIndex = 11;
            this.progressOpening.Visible = false;
            // 
            // labelLog
            // 
            labelLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            labelLog.AutoSize = true;
            labelLog.Location = new System.Drawing.Point(3, 314);
            labelLog.Name = "labelLog";
            labelLog.Size = new System.Drawing.Size(28, 13);
            labelLog.TabIndex = 9;
            labelLog.Text = "Log:";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxLog.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLog.Location = new System.Drawing.Point(2, 330);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.Size = new System.Drawing.Size(185, 144);
            this.textBoxLog.TabIndex = 10;
            this.textBoxLog.Text = "";
            // 
            // labelOpenedImages
            // 
            this.labelOpenedImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOpenedImages.AutoSize = true;
            this.labelOpenedImages.Location = new System.Drawing.Point(2, 4);
            this.labelOpenedImages.Name = "labelOpenedImages";
            this.labelOpenedImages.Size = new System.Drawing.Size(95, 13);
            this.labelOpenedImages.TabIndex = 5;
            this.labelOpenedImages.Text = "Otevřené obrázky:";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddImage.Location = new System.Drawing.Point(3, 61);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(184, 33);
            this.btnAddImage.TabIndex = 1;
            this.btnAddImage.Text = "Přidat obrázek";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.LoadImages);
            // 
            // dropMenuOpened
            // 
            this.dropMenuOpened.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dropMenuOpened.DropDownHeight = 300;
            this.dropMenuOpened.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropMenuOpened.Enabled = false;
            this.dropMenuOpened.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dropMenuOpened.FormattingEnabled = true;
            this.dropMenuOpened.IntegralHeight = false;
            this.dropMenuOpened.Location = new System.Drawing.Point(3, 21);
            this.dropMenuOpened.Name = "dropMenuOpened";
            this.dropMenuOpened.Size = new System.Drawing.Size(184, 21);
            this.dropMenuOpened.TabIndex = 0;
            this.dropMenuOpened.SelectedIndexChanged += new System.EventHandler(this.ChangedImage);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(201, 30);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(582, 477);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.ImageClick);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.labelResolutionHeader);
            this.panelRight.Controls.Add(this.labelResolution);
            this.panelRight.Controls.Add(this.labelPictureInfoHeader);
            this.panelRight.Controls.Add(this.btnOpenOriginal);
            this.panelRight.Controls.Add(this.btnOpenFolder);
            this.panelRight.Controls.Add(this.labelPictureInfo);
            this.panelRight.Controls.Add(this.layoutRight5);
            this.panelRight.Controls.Add(this.labelColor);
            this.panelRight.Controls.Add(this.layoutRight4);
            this.panelRight.Controls.Add(this.labelBrightness);
            this.panelRight.Controls.Add(this.layoutRight3);
            this.panelRight.Controls.Add(this.labelFilter);
            this.panelRight.Controls.Add(this.layoutRight2);
            this.panelRight.Controls.Add(this.labelFlip);
            this.panelRight.Controls.Add(this.layoutRight1);
            this.panelRight.Controls.Add(this.labelRotate);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(790, 30);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(190, 477);
            this.panelRight.TabIndex = 2;
            // 
            // labelResolutionHeader
            // 
            this.labelResolutionHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResolutionHeader.AutoSize = true;
            this.labelResolutionHeader.Location = new System.Drawing.Point(4, 326);
            this.labelResolutionHeader.Name = "labelResolutionHeader";
            this.labelResolutionHeader.Size = new System.Drawing.Size(54, 13);
            this.labelResolutionHeader.TabIndex = 17;
            this.labelResolutionHeader.Text = "Rozlišení:";
            // 
            // labelResolution
            // 
            this.labelResolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResolution.Location = new System.Drawing.Point(7, 339);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(180, 23);
            this.labelResolution.TabIndex = 16;
            this.labelResolution.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPictureInfoHeader
            // 
            this.labelPictureInfoHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPictureInfoHeader.AutoSize = true;
            this.labelPictureInfoHeader.Location = new System.Drawing.Point(4, 362);
            this.labelPictureInfoHeader.Name = "labelPictureInfoHeader";
            this.labelPictureInfoHeader.Size = new System.Drawing.Size(108, 13);
            this.labelPictureInfoHeader.TabIndex = 15;
            this.labelPictureInfoHeader.Text = "Informace o originálu:";
            // 
            // btnOpenOriginal
            // 
            this.btnOpenOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenOriginal.Enabled = false;
            this.btnOpenOriginal.Location = new System.Drawing.Point(3, 451);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(184, 23);
            this.btnOpenOriginal.TabIndex = 14;
            this.btnOpenOriginal.Text = "Otevřít složku originálu";
            this.btnOpenOriginal.UseVisualStyleBackColor = true;
            this.btnOpenOriginal.Click += new System.EventHandler(this.OpenSourceFolder);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolder.Enabled = false;
            this.btnOpenFolder.Location = new System.Drawing.Point(3, 422);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(184, 23);
            this.btnOpenFolder.TabIndex = 13;
            this.btnOpenFolder.Text = "Otevřít originál";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.OpenSource);
            // 
            // labelPictureInfo
            // 
            this.labelPictureInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPictureInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPictureInfo.Location = new System.Drawing.Point(7, 375);
            this.labelPictureInfo.Name = "labelPictureInfo";
            this.labelPictureInfo.Size = new System.Drawing.Size(181, 44);
            this.labelPictureInfo.TabIndex = 12;
            this.labelPictureInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // layoutRight5
            // 
            this.layoutRight5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutRight5.ColumnCount = 2;
            this.layoutRight5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutRight5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutRight5.Controls.Add(this.btnFilterLessColor, 0, 0);
            this.layoutRight5.Controls.Add(this.btnFilterMoreColor, 1, 0);
            this.layoutRight5.Location = new System.Drawing.Point(0, 248);
            this.layoutRight5.Name = "layoutRight5";
            this.layoutRight5.RowCount = 1;
            this.layoutRight5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutRight5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutRight5.Size = new System.Drawing.Size(190, 28);
            this.layoutRight5.TabIndex = 11;
            // 
            // btnFilterLessColor
            // 
            this.btnFilterLessColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterLessColor.Enabled = false;
            this.btnFilterLessColor.Location = new System.Drawing.Point(3, 3);
            this.btnFilterLessColor.Name = "btnFilterLessColor";
            this.btnFilterLessColor.Size = new System.Drawing.Size(89, 22);
            this.btnFilterLessColor.TabIndex = 0;
            this.btnFilterLessColor.Text = "Snížit";
            this.btnFilterLessColor.UseVisualStyleBackColor = true;
            this.btnFilterLessColor.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnFilterMoreColor
            // 
            this.btnFilterMoreColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterMoreColor.Enabled = false;
            this.btnFilterMoreColor.Location = new System.Drawing.Point(98, 3);
            this.btnFilterMoreColor.Name = "btnFilterMoreColor";
            this.btnFilterMoreColor.Size = new System.Drawing.Size(89, 22);
            this.btnFilterMoreColor.TabIndex = 1;
            this.btnFilterMoreColor.Text = "Zvýšit";
            this.btnFilterMoreColor.UseVisualStyleBackColor = true;
            this.btnFilterMoreColor.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(4, 232);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(58, 13);
            this.labelColor.TabIndex = 4;
            this.labelColor.Text = "Barevnost:";
            // 
            // layoutRight4
            // 
            this.layoutRight4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutRight4.ColumnCount = 2;
            this.layoutRight4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutRight4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutRight4.Controls.Add(this.btnFilterDarker, 0, 0);
            this.layoutRight4.Controls.Add(this.btnFilterBrighter, 1, 0);
            this.layoutRight4.Location = new System.Drawing.Point(0, 200);
            this.layoutRight4.Name = "layoutRight4";
            this.layoutRight4.RowCount = 1;
            this.layoutRight4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutRight4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutRight4.Size = new System.Drawing.Size(190, 28);
            this.layoutRight4.TabIndex = 9;
            // 
            // btnFilterDarker
            // 
            this.btnFilterDarker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterDarker.Enabled = false;
            this.btnFilterDarker.Location = new System.Drawing.Point(3, 3);
            this.btnFilterDarker.Name = "btnFilterDarker";
            this.btnFilterDarker.Size = new System.Drawing.Size(89, 22);
            this.btnFilterDarker.TabIndex = 0;
            this.btnFilterDarker.Text = "Snížit";
            this.btnFilterDarker.UseVisualStyleBackColor = true;
            this.btnFilterDarker.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnFilterBrighter
            // 
            this.btnFilterBrighter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterBrighter.Enabled = false;
            this.btnFilterBrighter.Location = new System.Drawing.Point(98, 3);
            this.btnFilterBrighter.Name = "btnFilterBrighter";
            this.btnFilterBrighter.Size = new System.Drawing.Size(89, 22);
            this.btnFilterBrighter.TabIndex = 1;
            this.btnFilterBrighter.Text = "Zvýšit";
            this.btnFilterBrighter.UseVisualStyleBackColor = true;
            this.btnFilterBrighter.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // labelBrightness
            // 
            this.labelBrightness.AutoSize = true;
            this.labelBrightness.Location = new System.Drawing.Point(4, 184);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.Size = new System.Drawing.Size(26, 13);
            this.labelBrightness.TabIndex = 3;
            this.labelBrightness.Text = "Jas:";
            // 
            // layoutRight3
            // 
            this.layoutRight3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutRight3.ColumnCount = 2;
            this.layoutRight3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutRight3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutRight3.Controls.Add(this.btnFilterNegative, 0, 1);
            this.layoutRight3.Controls.Add(this.btnFilterMono, 1, 0);
            this.layoutRight3.Controls.Add(this.btnFilterGreyscale, 0, 0);
            this.layoutRight3.Controls.Add(this.btnFilterSepia, 1, 1);
            this.layoutRight3.Location = new System.Drawing.Point(0, 118);
            this.layoutRight3.Name = "layoutRight3";
            this.layoutRight3.RowCount = 2;
            this.layoutRight3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutRight3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutRight3.Size = new System.Drawing.Size(190, 62);
            this.layoutRight3.TabIndex = 7;
            // 
            // btnFilterNegative
            // 
            this.btnFilterNegative.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterNegative.Enabled = false;
            this.btnFilterNegative.Location = new System.Drawing.Point(3, 34);
            this.btnFilterNegative.Name = "btnFilterNegative";
            this.btnFilterNegative.Size = new System.Drawing.Size(89, 25);
            this.btnFilterNegative.TabIndex = 2;
            this.btnFilterNegative.Text = "Negativ";
            this.btnFilterNegative.UseVisualStyleBackColor = true;
            this.btnFilterNegative.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnFilterMono
            // 
            this.btnFilterMono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterMono.Enabled = false;
            this.btnFilterMono.Location = new System.Drawing.Point(98, 3);
            this.btnFilterMono.Name = "btnFilterMono";
            this.btnFilterMono.Size = new System.Drawing.Size(89, 25);
            this.btnFilterMono.TabIndex = 1;
            this.btnFilterMono.Text = "Monochrom";
            this.btnFilterMono.UseVisualStyleBackColor = true;
            this.btnFilterMono.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnFilterGreyscale
            // 
            this.btnFilterGreyscale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterGreyscale.Enabled = false;
            this.btnFilterGreyscale.Location = new System.Drawing.Point(3, 3);
            this.btnFilterGreyscale.Name = "btnFilterGreyscale";
            this.btnFilterGreyscale.Size = new System.Drawing.Size(89, 25);
            this.btnFilterGreyscale.TabIndex = 0;
            this.btnFilterGreyscale.Text = "Stupně šedi";
            this.btnFilterGreyscale.UseVisualStyleBackColor = true;
            this.btnFilterGreyscale.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnFilterSepia
            // 
            this.btnFilterSepia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterSepia.Enabled = false;
            this.btnFilterSepia.Location = new System.Drawing.Point(98, 34);
            this.btnFilterSepia.Name = "btnFilterSepia";
            this.btnFilterSepia.Size = new System.Drawing.Size(89, 25);
            this.btnFilterSepia.TabIndex = 3;
            this.btnFilterSepia.Text = "Sepia";
            this.btnFilterSepia.UseVisualStyleBackColor = true;
            this.btnFilterSepia.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(4, 102);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(31, 13);
            this.labelFilter.TabIndex = 2;
            this.labelFilter.Text = "Filtry:";
            // 
            // layoutRight2
            // 
            this.layoutRight2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutRight2.ColumnCount = 2;
            this.layoutRight2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutRight2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutRight2.Controls.Add(this.btnTransFlipY, 1, 0);
            this.layoutRight2.Controls.Add(this.btnTransFlipX, 0, 0);
            this.layoutRight2.Location = new System.Drawing.Point(0, 69);
            this.layoutRight2.Name = "layoutRight2";
            this.layoutRight2.RowCount = 1;
            this.layoutRight2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutRight2.Size = new System.Drawing.Size(190, 30);
            this.layoutRight2.TabIndex = 5;
            // 
            // btnTransFlipY
            // 
            this.btnTransFlipY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransFlipY.Enabled = false;
            this.btnTransFlipY.Location = new System.Drawing.Point(98, 3);
            this.btnTransFlipY.Name = "btnTransFlipY";
            this.btnTransFlipY.Size = new System.Drawing.Size(89, 24);
            this.btnTransFlipY.TabIndex = 1;
            this.btnTransFlipY.Text = "Osa Y";
            this.btnTransFlipY.UseVisualStyleBackColor = true;
            this.btnTransFlipY.Click += new System.EventHandler(this.RotateFlipImage);
            // 
            // btnTransFlipX
            // 
            this.btnTransFlipX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransFlipX.Enabled = false;
            this.btnTransFlipX.Location = new System.Drawing.Point(3, 3);
            this.btnTransFlipX.Name = "btnTransFlipX";
            this.btnTransFlipX.Size = new System.Drawing.Size(89, 24);
            this.btnTransFlipX.TabIndex = 0;
            this.btnTransFlipX.Text = "Osa X";
            this.btnTransFlipX.UseVisualStyleBackColor = true;
            this.btnTransFlipX.Click += new System.EventHandler(this.RotateFlipImage);
            // 
            // labelFlip
            // 
            this.labelFlip.AutoSize = true;
            this.labelFlip.Location = new System.Drawing.Point(4, 53);
            this.labelFlip.Name = "labelFlip";
            this.labelFlip.Size = new System.Drawing.Size(105, 13);
            this.labelFlip.TabIndex = 1;
            this.labelFlip.Text = "Převrácení obrázku:";
            // 
            // layoutRight1
            // 
            this.layoutRight1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutRight1.ColumnCount = 2;
            this.layoutRight1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutRight1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutRight1.Controls.Add(this.btnTransRotateLeft, 0, 0);
            this.layoutRight1.Controls.Add(this.btnTransRotateRight, 1, 0);
            this.layoutRight1.Location = new System.Drawing.Point(0, 21);
            this.layoutRight1.Name = "layoutRight1";
            this.layoutRight1.RowCount = 1;
            this.layoutRight1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutRight1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutRight1.Size = new System.Drawing.Size(190, 28);
            this.layoutRight1.TabIndex = 3;
            // 
            // btnTransRotateLeft
            // 
            this.btnTransRotateLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransRotateLeft.Enabled = false;
            this.btnTransRotateLeft.Location = new System.Drawing.Point(3, 3);
            this.btnTransRotateLeft.Name = "btnTransRotateLeft";
            this.btnTransRotateLeft.Size = new System.Drawing.Size(89, 22);
            this.btnTransRotateLeft.TabIndex = 0;
            this.btnTransRotateLeft.Text = "Vlevo";
            this.btnTransRotateLeft.UseVisualStyleBackColor = true;
            this.btnTransRotateLeft.Click += new System.EventHandler(this.RotateFlipImage);
            // 
            // btnTransRotateRight
            // 
            this.btnTransRotateRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransRotateRight.Enabled = false;
            this.btnTransRotateRight.Location = new System.Drawing.Point(98, 3);
            this.btnTransRotateRight.Name = "btnTransRotateRight";
            this.btnTransRotateRight.Size = new System.Drawing.Size(89, 22);
            this.btnTransRotateRight.TabIndex = 1;
            this.btnTransRotateRight.Text = "Vpravo";
            this.btnTransRotateRight.UseVisualStyleBackColor = true;
            this.btnTransRotateRight.Click += new System.EventHandler(this.RotateFlipImage);
            // 
            // labelRotate
            // 
            this.labelRotate.AutoSize = true;
            this.labelRotate.Location = new System.Drawing.Point(4, 4);
            this.labelRotate.Name = "labelRotate";
            this.labelRotate.Size = new System.Drawing.Size(86, 13);
            this.labelRotate.TabIndex = 0;
            this.labelRotate.Text = "Rotace obrázku:";
            // 
            // openPicturesDialog
            // 
            this.openPicturesDialog.FileName = "openFileDialog1";
            this.openPicturesDialog.Filter = resources.GetString("openPicturesDialog.Filter");
            this.openPicturesDialog.Multiselect = true;
            // 
            // ImageEditForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(layoutMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "ImageEditForm";
            this.Text = "ImageEdit";
            this.Click += new System.EventHandler(this.ImageClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImageEditForm_KeyDown);
            layoutMain.ResumeLayout(false);
            layoutMain.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.layoutRight5.ResumeLayout(false);
            this.layoutRight4.ResumeLayout(false);
            this.layoutRight3.ResumeLayout(false);
            this.layoutRight2.ResumeLayout(false);
            this.layoutRight1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.OpenFileDialog openPicturesDialog;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.ComboBox dropMenuOpened;
        private System.Windows.Forms.Label labelOpenedImages;
        private System.Windows.Forms.RichTextBox textBoxLog;
        private System.Windows.Forms.ProgressBar progressOpening;
        private System.Windows.Forms.Button btnTransRotateLeft;
        private System.Windows.Forms.TableLayoutPanel layoutRight1;
        private System.Windows.Forms.Button btnTransRotateRight;
        private System.Windows.Forms.Label labelRotate;
        private System.Windows.Forms.TableLayoutPanel layoutRight2;
        private System.Windows.Forms.Button btnTransFlipY;
        private System.Windows.Forms.Button btnTransFlipX;
        private System.Windows.Forms.Label labelFlip;
        private System.Windows.Forms.TableLayoutPanel layoutRight3;
        private System.Windows.Forms.Button btnFilterNegative;
        private System.Windows.Forms.Button btnFilterMono;
        private System.Windows.Forms.Button btnFilterGreyscale;
        private System.Windows.Forms.Button btnFilterSepia;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.TableLayoutPanel layoutRight4;
        private System.Windows.Forms.Button btnFilterDarker;
        private System.Windows.Forms.Button btnFilterBrighter;
        private System.Windows.Forms.Label labelBrightness;
        private System.Windows.Forms.SaveFileDialog savePictureDialog;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.TableLayoutPanel layoutRight5;
        private System.Windows.Forms.Button btnFilterLessColor;
        private System.Windows.Forms.Button btnFilterMoreColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Label labelRemoveImage;
        private System.Windows.Forms.Label labelSaveImage;
        private System.Windows.Forms.Label labelOpenImage;
        private System.Windows.Forms.Label labelPictureInfo;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Label labelPictureInfoHeader;
        private System.Windows.Forms.Label labelResolutionHeader;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Button btnShowHelp;
    }
}

