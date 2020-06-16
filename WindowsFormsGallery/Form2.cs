using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon.ViewInfo;
namespace WindowsFormsGallery
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GalleryControl gc = new GalleryControl {Dock = DockStyle.Fill};
            this.Controls.Add(gc);

            Image im1 = Image.FromFile("c:\\Images\\BMW.jpg");
            Image im2 = Image.FromFile("c:\\Images\\Ford.jpg");
            Image im3 = Image.FromFile("c:\\Images\\MercedecBenz.jpg");
           

            gc.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
            gc.Gallery.ImageSize = new Size(120, 90);
            gc.Gallery.ShowItemText = true;

            GalleryItemGroup group1 = new GalleryItemGroup {Caption = "Cars"};
            gc.Gallery.Groups.Add(group1);
 

            group1.Items.Add(new GalleryItem(im1, "BMW", ""));
            group1.Items.Add(new GalleryItem(im2, "Ford", ""));
            group1.Items.Add(new GalleryItem(im3, "Mercedec-Benz", ""));

          
            var options = gc.Gallery.ContextButtonOptions;
            options.DisplayArea = ContextItemDisplayArea.Item;

            var cb = new ContextButton
            {
                Name = "Move", Alignment = ContextItemAlignment.Center, Visibility = ContextItemVisibility.Visible, Caption = "Moooov"
            };
            gc.Gallery.ContextButtons.Add(cb);
            gc.Gallery.RefreshGallery();
        }
    }
}
