﻿namespace ScrollablePictureBoxTest
{
    partial class TestForm
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.cmbSizeMode = new System.Windows.Forms.ComboBox();
            this.flybyTextProvider1 = new Manning.MyPhotoControls.FlybyTextProvider(this.components);
            this.spbxImage = new Manning.MyPhotoControls.ScrollablePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(13, 13);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cmbSizeMode
            // 
            this.cmbSizeMode.FormattingEnabled = true;
            this.cmbSizeMode.Items.AddRange(new object[] {
            "AutoSize",
            "CenterImage",
            "Normal",
            "Stretchimage",
            "Zoom"});
            this.cmbSizeMode.Location = new System.Drawing.Point(105, 14);
            this.cmbSizeMode.Name = "cmbSizeMode";
            this.cmbSizeMode.Size = new System.Drawing.Size(167, 21);
            this.cmbSizeMode.TabIndex = 1;
            this.cmbSizeMode.Text = "Normal";
            this.cmbSizeMode.SelectedIndexChanged += new System.EventHandler(this.cmbSizeMode_SelectedIndexChanged);
            // 
            // flybyTextProvider1
            // 
            this.flybyTextProvider1.StatusLabel = null;
            // 
            // spbxImage
            // 
            this.spbxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spbxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spbxImage.Location = new System.Drawing.Point(13, 43);
            this.spbxImage.Name = "spbxImage";
            this.spbxImage.Size = new System.Drawing.Size(259, 215);
            this.spbxImage.TabIndex = 2;
            this.spbxImage.TabStop = false;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.spbxImage);
            this.Controls.Add(this.cmbSizeMode);
            this.Controls.Add(this.btnLoad);
            this.Name = "TestForm";
            this.Text = "ScrollablePictureBox Test";
            ((System.ComponentModel.ISupportInitialize)(this.spbxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cmbSizeMode;
        private Manning.MyPhotoControls.FlybyTextProvider flybyTextProvider1;
        private Manning.MyPhotoControls.ScrollablePictureBox spbxImage;
    }
}

