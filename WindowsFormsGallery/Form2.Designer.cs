namespace WindowsFormsGallery
{
    partial class Form2
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
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup3 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem4 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup4 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem5 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem6 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem7 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup5 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem8 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem9 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.galleryControl2 = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient2 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.galleryControl1 = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl2)).BeginInit();
            this.galleryControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).BeginInit();
            this.galleryControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Manager = null;
            this.galleryDropDown1.Name = "galleryDropDown1";
            // 
            // galleryControl2
            // 
            this.galleryControl2.AllowDrop = true;
            this.galleryControl2.Controls.Add(this.galleryControlClient2);
            // 
            // 
            // 
            this.galleryControl2.Gallery.AllowItemDrag = true;
            this.galleryControl2.Gallery.CheckSelectedItemViaKeyboard = true;
            galleryItemGroup1.Caption = "Group3";
            galleryItem1.Caption = "Item6";
            galleryItem2.Caption = "Item7";
            galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2});
            galleryItemGroup2.Caption = "Group4";
            galleryItemGroup3.Caption = "Group5";
            galleryItem3.Caption = "Item8";
            galleryItem4.Caption = "Item9";
            galleryItemGroup3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem3,
            galleryItem4});
            this.galleryControl2.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1,
            galleryItemGroup2,
            galleryItemGroup3});
            this.galleryControl2.Location = new System.Drawing.Point(406, 34);
            this.galleryControl2.Name = "galleryControl2";
            this.galleryControl2.Size = new System.Drawing.Size(371, 389);
            this.galleryControl2.TabIndex = 1;
            this.galleryControl2.Text = "galleryControl2";
            this.galleryControl2.DragDrop += new System.Windows.Forms.DragEventHandler(this.galleryControl_DragDrop);
            this.galleryControl2.DragOver += new System.Windows.Forms.DragEventHandler(this.galleryControl_DragOver);
            this.galleryControl2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.galleryControl_MouseDown);
            this.galleryControl2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.galleryControl_MouseMove);
            // 
            // galleryControlClient2
            // 
            this.galleryControlClient2.GalleryControl = this.galleryControl2;
            this.galleryControlClient2.Location = new System.Drawing.Point(2, 31);
            this.galleryControlClient2.Size = new System.Drawing.Size(350, 356);
            // 
            // galleryControl1
            // 
            this.galleryControl1.AllowDrop = true;
            this.galleryControl1.Controls.Add(this.galleryControlClient1);
            // 
            // 
            // 
            this.galleryControl1.Gallery.AllowItemDrag = true;
            this.galleryControl1.Gallery.CheckSelectedItemViaKeyboard = true;
            galleryItemGroup4.Caption = "Group1";
            galleryItem5.Caption = "Item1";
            galleryItem5.Checked = true;
            galleryItem5.Description = "1";
            galleryItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            galleryItem5.Value = 0;
            galleryItem6.Caption = "Item2";
            galleryItem6.Value = 1;
            galleryItem7.Caption = "Item3";
            galleryItem7.Value = 2;
            galleryItemGroup4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem5,
            galleryItem6,
            galleryItem7});
            galleryItemGroup5.Caption = "Group2";
            galleryItem8.Caption = "Item4";
            galleryItem8.Value = 3;
            galleryItem9.Caption = "Item5";
            galleryItem9.Value = 4;
            galleryItemGroup5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem8,
            galleryItem9});
            this.galleryControl1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup4,
            galleryItemGroup5});
            this.galleryControl1.Location = new System.Drawing.Point(22, 34);
            this.galleryControl1.Name = "galleryControl1";
            this.galleryControl1.Size = new System.Drawing.Size(368, 389);
            this.galleryControl1.TabIndex = 0;
            this.galleryControl1.Text = "galleryControl1";
            this.galleryControl1.DragDrop += new System.Windows.Forms.DragEventHandler(this.galleryControl_DragDrop);
            this.galleryControl1.DragOver += new System.Windows.Forms.DragEventHandler(this.galleryControl_DragOver);
            this.galleryControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.galleryControl_MouseDown);
            this.galleryControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.galleryControl_MouseMove);
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControl1;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 31);
            this.galleryControlClient1.Size = new System.Drawing.Size(347, 356);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.galleryControl2);
            this.Controls.Add(this.galleryControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl2)).EndInit();
            this.galleryControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).EndInit();
            this.galleryControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl2;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient2;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl1;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
    }
}