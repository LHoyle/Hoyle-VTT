using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;



using System.IO;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;

namespace Hoyle_VTT
{
    public partial class VTT : Form
    {
        public VTT()
        {
            InitializeComponent();
            Console.WriteLine("grid: "+grid_picture_Box.Location+" VTT: "+VTT_table_box.Location);
            grid_picture_Box.Parent = VTT_table_box;
            grid_picture_Box.Size = VTT_table_box.Size;
            grid_picture_Box.Location = new Point(0, 0); 
            Console.WriteLine("grid: " + grid_picture_Box.Location + " VTT" + VTT_table_box.Location);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //statusStrip1.Visible = false;
            

        }
        private void VTT_key_press(object sender, KeyPressEventArgs e)
        {

        }

        //Controls for VTT tokens.
        //Arrow keys for up down left right. Shift for down, Spacebar for up.

        //buttons
        private void Load_click(object sender, EventArgs e)
        {
            Image image1;
            //double modified_height;
            //double radtio_height;
            //int outheight;
            //double modified_width;
            //double radtio_width;
            //int outwidth;
            var filePath = string.Empty;
            //statusStrip1.Visible = true;
            toolStripStatusLabel1.Text = ("time to load!");
            Console.WriteLine("load button clicked!");
            
            picture_grabbing.InitialDirectory = "c:/Users/FireS/Pictures/Dnd";
            //picture_grabbing.Filter = "Image files (*.png)|*.png|All Files (*.*)|*.*";
            picture_grabbing.Filter = "All Files (*.*)|*.*";

            if (picture_grabbing.ShowDialog() == DialogResult.OK)
            {
                filePath = picture_grabbing.FileName;
                if (File.Exists(filePath))
                {
                    //string fileContents = File.ReadAllText(file);
                    //toolStripStatusLabel1.Text = fileContents;
                }
                else
                {
                    toolStripStatusLabel1.Text = "File Not Found";
                    //picture_grabbing.OpenFile();
                    return;
                }
            }
            //System.IO.Stream file = filePath;

            //picture_grabbing.InitialDirectory

            //.OpenFile();
            //picture_grabbing.
            //VTT_table_box.Image= picture_grabbing.OpenFile();

            // https://learn.microsoft.com/en-us/dotnet/api/system.drawing.image.fromfile?view=windowsdesktop-9.0

            //file.
            //Image image1=Image.FromFile(file_name_in);
            try {
                image1 = Image.FromFile(filePath);
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine("Out of memory error" + ex);
                toolStripStatusLabel1.Text = ("Out of memory error Check console for more information");

                return;
            }
            catch (ArgumentException AE)
            {
                Console.WriteLine("Argument error" + AE);
                toolStripStatusLabel1.Text = ("Argument error. Check console for more information");

                return;
            }
            int origin_img_height = image1.Height;
            int height = origin_img_height;
            int origin_img_width = image1.Width;
            int width = origin_img_width;
            double ratio=(double)origin_img_height / (double)origin_img_width;
            int vtt_width = VTT_table_box.MaximumSize.Width;
            int vtt_height = VTT_table_box.MaximumSize.Height;
            double vtt_ratio = (double)vtt_width / (double)vtt_height;
            

            string outratio = ratio.ToString();
            Console.WriteLine("image height:" + height + "Image width:" + width + "for a ratio of:" + ratio);
            Console.WriteLine("The VTT window, image height: " +vtt_height+"Image width: "+vtt_width+"for a ratio of:"+ vtt_ratio);
            //Console.WriteLine((double)width);

            double width_Ratio = (float)vtt_width / origin_img_width;
            double height_Ratio= (float)vtt_height / origin_img_height;
            ratio=Math.Min(width_Ratio, height_Ratio);
            VTT_table_box.Height =(int)(origin_img_height*ratio);
            VTT_table_box.Width =(int)(origin_img_width*ratio);

            VTT_table_box.Image = new Bitmap (image1);
            toolStripStatusLabel1.Text = ("Image Loaded!");
            suboptions_Menu.DataSource = map_data_Set;
            return;



            //Image image1 = Image.FromStream(filePath);

            //Image image2 = Image.FromFile(file);

            //PropertyItem propItem = image1.GetPropertyItem(20624);
            //propItem.Id = 20625;

            //image2.SetPropertyItem(propItem);

            //if (File.Exists(file))
            //{
            //    string fileContents = File.ReadAllText(file);
            //    toolStripStatusLabel1.Text = fileContents;
            //}
            //else
            //{
            //    toolStripStatusLabel1.Text = "File Not Found";
            //picture_grabbing.OpenFile();
        }

        private void Token_menu_Click(object sender, EventArgs e)
        {
            //statusStrip1.Visible = true;
            toolStripStatusLabel1.Text = ("opening Token Menu!");
            suboptions_Menu.DataSource = Token_Data_Set;
        }
        private void Drawing_click(object sender, EventArgs e)
        {
            //statusStrip1.Visible = true;
            toolStripStatusLabel1.Text = ("opening Drawing Menu!");
            suboptions_Menu.DataSource = Drawing_Data_set;

        }





        //Label stuff
        private void toolStripStatusLabel1_MouseEnter(object sender, EventArgs e)
        {
            //toolStripStatusLabel1.Text = ("I'm highlighted!");             
        }

        private void toolStripStatusLabel1_MouseLeave(object sender, EventArgs e)
        {
            //toolStripStatusLabel1.Text = ("No longer highlighted!");
            //statusStrip1.Visible = false;
        }

        private void picture_grabbing_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void VTT_table_box_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VTT_table_box_SizeChanged(object sender, EventArgs e)
        {
            grid_picture_Box.Parent = VTT_table_box;
            grid_picture_Box.Size = VTT_table_box.Size;
            grid_picture_Box.Location = new Point(0, 0);
            //grid_picture_Box.BackColor = Color.Transparent;
        }

        private void grid_toggle_Click(object sender, EventArgs e)
        {
            if (grid_picture_Box.Visible == true)
            {
                toolStripStatusLabel1.Text = ("Grid Turned off");

                grid_picture_Box.Visible= false;
            }
            else
            {
                toolStripStatusLabel1.Text = ("Grid Turned on");

                grid_picture_Box.Visible = true;
            }
        }

        private void Change_grid_Click(object sender, EventArgs e)
        {
            if (grid_picture_Box.Visible == true)
            {
                if (grid_picture_Box.BackgroundImageLayout == System.Windows.Forms.ImageLayout.Tile)
                {
                    toolStripStatusLabel1.Text = ("grid changed to Stretch");
                    grid_picture_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    return;
                }
                else if (grid_picture_Box.BackgroundImageLayout == System.Windows.Forms.ImageLayout.Stretch)
                {
                    toolStripStatusLabel1.Text = ("grid changed to Tile");
                    grid_picture_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
                    return;
                }

                //if (grid_picture_Box.SizeMode == System.Windows.Forms.PictureBoxSizeMode.AutoSize)
                //{
                //    toolStripStatusLabel1.Text = ("grid changed to Stretch");

                    //    grid_picture_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    //    grid_picture_Box.Update();

                    //}
                    //else if(grid_picture_Box.SizeMode == System.Windows.Forms.PictureBoxSizeMode.StretchImage)
                    //{
                    //    toolStripStatusLabel1.Text = ("grid changed to Center");

                    //    grid_picture_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                    //    grid_picture_Box.Update();


                    //}
                    //else if(grid_picture_Box.SizeMode == System.Windows.Forms.PictureBoxSizeMode.CenterImage)
                    //{
                    //    toolStripStatusLabel1.Text = ("grid changed to 'Normal'");

                    //    grid_picture_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
                    //    grid_picture_Box.Update();


                    //}
                    //else if(grid_picture_Box.SizeMode == System.Windows.Forms.PictureBoxSizeMode.Normal)
                    //{
                    //    toolStripStatusLabel1.Text = ("grid changed to Zoom");

                    //    grid_picture_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    //    grid_picture_Box.Update();


                    //}
                    //else if(grid_picture_Box.SizeMode == System.Windows.Forms.PictureBoxSizeMode.Zoom)
                    //{
                    //    toolStripStatusLabel1.Text = ("grid changed to Auto");

                    //    grid_picture_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                    //    grid_picture_Box.Update();

                    //}
            }
            else
            {
                toolStripStatusLabel1.Text = ("Grid is not visible to be toggled.");

            }

        }
    }
}

//unused stuff
/*
 

            if (vtt_ratio == ratio)
            {
                VTT_table_box.Image = image1;
                toolStripStatusLabel1.Text = ("Proper Ratio!");
            }
            if (width > height) {
                Console.WriteLine("width larger than height");
                if (width > VTT_table_box.MaximumSize.Width)
                {

                    int oldwidth = width;
                    Console.WriteLine("width of " + oldwidth + " too big, using window size of " + VTT_table_box.MaximumSize.Width + "for width instead");
                    width = VTT_table_box.MaximumSize.Width;
                    //height = VTT_table_box.MaximumSize.Width;
                    VTT_table_box.Width = height;
                    double scale_Down_ratio = (double)Width / (double)oldwidth;
                    Console.WriteLine("Scaledown ratio: " + scale_Down_ratio);
                    modified_height = (double)height* ratio;
                    modified_height = modified_height * scale_Down_ratio;
                    double height_check = height * scale_Down_ratio;
                    Console.WriteLine("Width of " + height_check + " Should equal the modified width " + modified_height);


                }
                else
                {
                    VTT_table_box.Width = width;
                    modified_width = (double)width * ratio;
                }
                VTT_table_box.Width = width;
                modified_height = (double)height * ratio;
                Console.WriteLine("the modified height based on the ratio:"+modified_height);
                radtio_height =Math.Ceiling(modified_height);
                Console.WriteLine("pushing the former value to its ceiling:"+radtio_height);
                outheight = (int)radtio_height;
                VTT_table_box.Height = outheight;
                Console.WriteLine("the outout width:"+outheight);

                if (outheight > VTT_table_box.MaximumSize.Height)
                {
                    Console.WriteLine("too big! resizing down");
                    modified_height = (double)VTT_table_box.Height * ratio;
                    Console.WriteLine("the modified width based on the ratio:"+modified_height);
                    radtio_height = Math.Ceiling(modified_height);
                    Console.WriteLine("pushing the former value to its ceiling:"+radtio_height);
                    outheight = (int)radtio_height;

                    VTT_table_box.Height = outheight;
                }

                
                toolStripStatusLabel1.Text = ("Width bigger, ratio:"+ outratio);
                //scale = width;
            }
            else
            {
                //
                //
                //height larger than width
                //
                //

                Console.WriteLine("height larger than width");

                if (height > VTT_table_box.MaximumSize.Height)
                {
                    int oldheight = height;
                    Console.WriteLine("height of "+oldheight+" too big, using window size of "+ VTT_table_box.MaximumSize.Height+"for height instead");
                    height = VTT_table_box.MaximumSize.Height;
                    VTT_table_box.Height = height;
                    double scale_Down_ratio=(double)height/ (double)oldheight;
                    Console.WriteLine("Scaledown ratio: "+scale_Down_ratio);
                    double modified_width_before_ratio= width * scale_Down_ratio;
                    modified_width = modified_width_before_ratio * ratio;
                    double width_check = (origin_img_width * scale_Down_ratio)*ratio;
                    double secondary_width_check = ((modified_width / ratio) / scale_Down_ratio);
                    double height_check = (origin_img_height *scale_Down_ratio);
                    Console.WriteLine("Width of: " + width_check + " Should equal the modified width: " + modified_width);
                    Console.WriteLine("the modified Width of: " + secondary_width_check + " Should equal the original  width: " + origin_img_width);
                    Console.WriteLine("height of: " + height_check + " should equal the maximized height of the window: " + VTT_table_box.MaximumSize.Height);


                }
                else {
                    VTT_table_box.Height = height;
                    modified_width = (double)height * ratio;
                }
                
                Console.WriteLine("the modified width based on the ratio:"+modified_width);
                radtio_width = Math.Ceiling(modified_width);
                Console.WriteLine("pushing the former value to its ceiling:"+radtio_width);              
                outwidth = (int)radtio_width;
                Console.WriteLine("the outout width:"+outwidth);
                VTT_table_box.Width = outwidth;
                if (outwidth > VTT_table_box.MaximumSize.Width)
                {
                    Console.WriteLine("too big! resizing down");
                    modified_width = (double)VTT_table_box.Height * ratio;
                    Console.WriteLine("the modified width based on the ratio:"+modified_width);
                    radtio_width = Math.Ceiling(modified_width);
                    Console.WriteLine("pushing the former value to its ceiling:"+radtio_width);
                    outwidth = (int)radtio_width;

                    VTT_table_box.Width = outwidth;
                }
                
                toolStripStatusLabel1.Text = ("Height bigger, ratio:" + outratio);
            }

            
 */
