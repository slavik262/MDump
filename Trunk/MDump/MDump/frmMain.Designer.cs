﻿namespace MDump
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lvImages = new System.Windows.Forms.ListView();
            this.clmImages = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.ttpMain = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.dlgOpenImg = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lvImages
            // 
            this.lvImages.AllowDrop = true;
            this.lvImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvImages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmImages});
            this.lvImages.Location = new System.Drawing.Point(12, 12);
            this.lvImages.Name = "lvImages";
            this.lvImages.Size = new System.Drawing.Size(460, 266);
            this.lvImages.TabIndex = 0;
            this.lvImages.UseCompatibleStateImageBehavior = false;
            this.lvImages.View = System.Windows.Forms.View.Details;
            this.lvImages.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvImages_ItemSelectionChanged);
            this.lvImages.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvImages_DragDrop);
            this.lvImages.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvImages_DragEnter);
            this.lvImages.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvImages_KeyUp);
            this.lvImages.Resize += new System.EventHandler(this.lvImages_Resize);
            // 
            // clmImages
            // 
            this.clmImages.Text = "SetAtRuntime";
            this.clmImages.Width = 250;
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.Location = new System.Drawing.Point(361, 284);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 30);
            this.btnOptions.TabIndex = 5;
            this.btnOptions.Text = "Options...";
            this.ttpMain.SetToolTip(this.btnOptions, "Edit options and settings for MDump");
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnAction
            // 
            this.btnAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAction.Location = new System.Drawing.Point(12, 320);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(460, 30);
            this.btnAction.TabIndex = 6;
            this.btnAction.Text = "Set at runtime";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(12, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Image";
            this.ttpMain.SetToolTip(this.btnAdd, "Add an Image to the list");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfo.Image = global::MDump.Properties.Resources.InfoIcon;
            this.btnInfo.Location = new System.Drawing.Point(442, 284);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(30, 30);
            this.btnInfo.TabIndex = 7;
            this.ttpMain.SetToolTip(this.btnInfo, "Info about MDump");
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = global::MDump.Properties.Resources.XIcon;
            this.btnDelete.Location = new System.Drawing.Point(165, 284);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 4;
            this.ttpMain.SetToolTip(this.btnDelete, "Remove the selected image from the list");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDown.Enabled = false;
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(129, 284);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(30, 30);
            this.btnDown.TabIndex = 3;
            this.ttpMain.SetToolTip(this.btnDown, "Move the selected image down on the list");
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUp.Enabled = false;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.Location = new System.Drawing.Point(93, 284);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(30, 30);
            this.btnUp.TabIndex = 2;
            this.btnUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttpMain.SetToolTip(this.btnUp, "Move the selected image up on the list");
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // dlgOpenImg
            // 
            this.dlgOpenImg.Filter = "Images|*gif;*jpg;*jpeg;*wmf;*bmp;*png";
            this.dlgOpenImg.Multiselect = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lvImages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(340, 200);
            this.Name = "frmMain";
            this.Text = "MDump";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvImages;
        private System.Windows.Forms.ColumnHeader clmImages;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.ToolTip ttpMain;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.OpenFileDialog dlgOpenImg;

    }
}

