namespace MyAlbumExplorer
{
    partial class ExplorerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplorerForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.atvAlbumTree = new MyAlbumExplorer.AlbumTreeView();
            this.spbxPhoto = new Manning.MyPhotoControls.ScrollablePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spbxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.atvAlbumTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.spbxPhoto);
            this.splitContainer1.Size = new System.Drawing.Size(434, 261);
            this.splitContainer1.SplitterDistance = 144;
            this.splitContainer1.TabIndex = 0;
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "Photo");
            this.imageListSmall.Images.SetKeyName(1, "Album");
            this.imageListSmall.Images.SetKeyName(2, "AlbumSelect");
            this.imageListSmall.Images.SetKeyName(3, "AlbumLock");
            this.imageListSmall.Images.SetKeyName(4, "AlbumDir");
            this.imageListSmall.Images.SetKeyName(5, "AlbumError");
            // 
            // imageListLarge
            // 
            this.imageListLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // atvAlbumTree
            // 
            this.atvAlbumTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.atvAlbumTree.HideSelection = false;
            this.atvAlbumTree.ImageIndex = 0;
            this.atvAlbumTree.ImageList = this.imageListSmall;
            this.atvAlbumTree.LabelEdit = true;
            this.atvAlbumTree.Location = new System.Drawing.Point(0, 0);
            this.atvAlbumTree.Name = "atvAlbumTree";
            this.atvAlbumTree.SelectedImageIndex = 0;
            this.atvAlbumTree.Size = new System.Drawing.Size(144, 261);
            this.atvAlbumTree.TabIndex = 0;
            this.atvAlbumTree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.atvAlbumTree_BeforeSelect);
            this.atvAlbumTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.atvAlbumTree_AfterSelect);
            // 
            // spbxPhoto
            // 
            this.spbxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spbxPhoto.Image = null;
            this.spbxPhoto.Location = new System.Drawing.Point(0, 0);
            this.spbxPhoto.Name = "spbxPhoto";
            this.spbxPhoto.Size = new System.Drawing.Size(286, 261);
            this.spbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spbxPhoto.TabIndex = 0;
            this.spbxPhoto.TabStop = false;
            // 
            // ExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExplorerForm";
            this.Text = "Album Explorer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spbxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ImageList imageListLarge;
        private AlbumTreeView atvAlbumTree;
        private Manning.MyPhotoControls.ScrollablePictureBox spbxPhoto;
    }
}

