using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoyle_VTT
{

    public class Grid
    {
        protected int height_number;
        protected int width_number;
        protected PictureBox stored_map;

        public Grid()
        {
            height_number = 0;
            width_number = 0;
        }
        public Grid(int height_number_in, int width_number_in, PictureBox stored_map_in)
        {
            height_number = height_number_in;
            width_number = width_number_in;
            stored_map = stored_map_in;
        }

        public void set_grid_box_size(PictureBox pictureBox_in)
        {

        }
        public void set_grid_size(int number_width, int number_height) {
            set_grid_width(number_width);
            set_grid_height(number_height);
        }
        public void set_grid_width(int number_width)
        {
            width_number = number_width;
        }
        public void set_grid_height(int number_height)
        {
            height_number = number_height;
        }

    }
}
