using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraBars.Ribbon;
namespace WindowsFormsGallery
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
            hitPoint = pointInvalid;
        }

        private Point hitPoint { get; set; }
        private Point pointInvalid => new Point(-10000, -10000);
        private GalleryControl sourceControl { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void galleryControl_MouseDown(object sender, MouseEventArgs e)
        {
            var galControl = sender as GalleryControl;
            var hitInfo = galControl.CalcHitInfo(e.Location);
            if (hitInfo.InGalleryItem && galControl.Gallery.GetCheckedItems().Count > 0)
            {
                galControl.Gallery.AllowMarqueeSelection = false;
                hitPoint = e.Location;
                sourceControl = galControl;
                return;
            }
            galControl.Gallery.AllowMarqueeSelection = true;
            hitPoint = pointInvalid;
            sourceControl = null;
        }

      
 

        private void galleryControl_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(List<GalleryItem>)))
            {
                return;
            }
            var draggedItems = (List<GalleryItem>) e.Data.GetData(typeof(List<GalleryItem>)) ;
            var galControl = sender as GalleryControl;
            var hitInfo = galControl.CalcHitInfo(galControl.PointToClient(new Point(e.X, e.Y)));
            if (hitInfo.InGalleryGroup)
            {
                foreach (var draggedItem in draggedItems)
                {
                    var item = draggedItem.Clone() as GalleryItem;
                    hitInfo.GalleryItemGroup.Items.Add(item);
                }
            }
            else
            {
                var groupIndex = galControl.Gallery.Groups.Add(new GalleryItemGroup());
                var group = galControl.Gallery.Groups.Last();
                group.Caption = "Dragged Items";
                foreach (var draggedItem in draggedItems)
                {
                    var item = draggedItem.Clone() as GalleryItem;
                    group.Items.Add(item);
                }
            }
            //Dim draggedItems As List(Of GalleryItem) = TryCast(e.Data.GetData(GetType(List(Of GalleryItem))), List(Of GalleryItem))


            //Dim galControl As GalleryControl = CType(sender, GalleryControl)

            //Dim hitInfo As RibbonHitInfo = galControl.CalcHitInfo(galControl.PointToClient(New Point(e.X, e.Y)))

            //If hitInfo.InGalleryGroup Then

            //For Each draggedItem As GalleryItem In draggedItems

            //hitInfo.GalleryItemGroup.Items.Add(CType(draggedItem.Clone(), GalleryItem))

            //Next draggedItem

            //Else
            //    Dim groupIndex As Integer = galControl.Gallery.Groups.Add(New GalleryItemGroup())

            //galControl.Gallery.Groups(groupIndex).Caption = "Dragged Items"

            //For Each draggedItem As GalleryItem In draggedItems

            //galControl.Gallery.Groups(groupIndex).Items.Add(CType(draggedItem.Clone(), GalleryItem))

            //Next draggedItem

            //End If
        }

        private void galleryControl_DragOver(object sender, DragEventArgs e)
        {
            var galControl = sender as GalleryControl;
            if (galControl ==sourceControl)
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            if (e.Data.GetDataPresent(typeof(List<GalleryItem>)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            //Dim galControl As GalleryControl = CType(sender, GalleryControl)

            //If galControl Is sourceControl Then

            //e.Effect = DragDropEffects.None

            //Return
            //    End If

            //    If e.Data.GetDataPresent(GetType(List(Of GalleryItem))) Then

            //e.Effect = DragDropEffects.Copy

            //End If
        }

        private void galleryControl_MouseMove(object sender, MouseEventArgs e)
        {

            if ( e.Button != MouseButtons.Left )
            {
                return;
            }
            else
            {
                if (Control.ModifierKeys != Keys.None)
                {
                    return;
                }
            }

            var galControl = sender as GalleryControl;
            var checkedItems = galControl.Gallery.GetCheckedItems();
            if (checkedItems.Count == 0)
            {
                return;
            }
            else
            {
                if (hitPoint == pointInvalid)
                {
                    return;
                }
            }
            //If e.Button<> MouseButtons.Left OrElse Control.ModifierKeys<> Keys.None Then

            //Return
            //    End If

            //    Dim galControl As GalleryControl = CType(sender, GalleryControl)

            //Dim checkedItems As List(Of GalleryItem) = galControl.Gallery.GetCheckedItems()

            //If checkedItems.Count = 0 OrElse hitPoint = pointInvalid Then
            //    Return

            //End If

            var dragSize = SystemInformation.DragSize;
            var dragRect = new Rectangle(hitPoint.X - dragSize.Width / 2, hitPoint.Y - dragSize.Height / 2, dragSize.Width, dragSize.Height);

            if (dragRect.Contains(e.Location))
            {
                galleryControl1.DoDragDrop(checkedItems, DragDropEffects.Copy);
            }
            //Dim dragSize As Size = SystemInformation.DragSize

            //Dim dragRect As New Rectangle(hitPoint.X - dragSize.Width \ 2, hitPoint.Y - dragSize.Height \ 2, dragSize.Width, dragSize.Height)

            //If Not(dragRect.Contains(e.Location)) Then

            //galleryControl1.DoDragDrop(checkedItems, DragDropEffects.Copy)

            //End If
        }
    }
}