namespace Hoyle_VTT
{
    partial class VTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VTT));
            this.Load_map_button = new System.Windows.Forms.Button();
            this.grid_toggle_button = new System.Windows.Forms.Button();
            this.Change_grid_button = new System.Windows.Forms.Button();
            this.Drawing_menu_button = new System.Windows.Forms.Button();
            this.Token_menu_button = new System.Windows.Forms.Button();
            this.Button_Box = new System.Windows.Forms.GroupBox();
            this.user_info_display = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Options_menu = new System.Windows.Forms.GroupBox();
            this.Menu_interact_button = new System.Windows.Forms.Button();
            this.suboptions_Menu = new System.Windows.Forms.ListBox();
            this.map_data_Set = new System.Data.DataSet();
            this.picture_grabbing = new System.Windows.Forms.OpenFileDialog();
            this.Info_bot = new System.Windows.Forms.ToolTip(this.components);
            this.grid_picture_Box = new System.Windows.Forms.PictureBox();
            this.Token_Data_Set = new System.Data.DataSet();
            this.Drawing_Data_set = new System.Data.DataSet();
            this.VTT_table_box = new System.Windows.Forms.PictureBox();
            this.Button_Box.SuspendLayout();
            this.user_info_display.SuspendLayout();
            this.Options_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.map_data_Set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_picture_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Token_Data_Set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drawing_Data_set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VTT_table_box)).BeginInit();
            this.SuspendLayout();
            // 
            // Load_map_button
            // 
            this.Load_map_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Load_map_button.Location = new System.Drawing.Point(6, 21);
            this.Load_map_button.Name = "Load_map_button";
            this.Load_map_button.Size = new System.Drawing.Size(310, 55);
            this.Load_map_button.TabIndex = 0;
            this.Load_map_button.Text = "Load image";
            this.Load_map_button.UseVisualStyleBackColor = true;
            this.Load_map_button.Click += new System.EventHandler(this.Load_click);
            // 
            // grid_toggle_button
            // 
            this.grid_toggle_button.Location = new System.Drawing.Point(322, 20);
            this.grid_toggle_button.Name = "grid_toggle_button";
            this.grid_toggle_button.Size = new System.Drawing.Size(310, 55);
            this.grid_toggle_button.TabIndex = 1;
            this.grid_toggle_button.Text = "Toggle Grid";
            this.grid_toggle_button.UseVisualStyleBackColor = true;
            this.grid_toggle_button.Click += new System.EventHandler(this.grid_toggle_Click);
            // 
            // Change_grid_button
            // 
            this.Change_grid_button.Location = new System.Drawing.Point(638, 21);
            this.Change_grid_button.Name = "Change_grid_button";
            this.Change_grid_button.Size = new System.Drawing.Size(310, 55);
            this.Change_grid_button.TabIndex = 2;
            this.Change_grid_button.Text = "Change Grid Type";
            this.Change_grid_button.UseVisualStyleBackColor = true;
            this.Change_grid_button.Click += new System.EventHandler(this.Change_grid_Click);
            // 
            // Drawing_menu_button
            // 
            this.Drawing_menu_button.Location = new System.Drawing.Point(951, 20);
            this.Drawing_menu_button.Name = "Drawing_menu_button";
            this.Drawing_menu_button.Size = new System.Drawing.Size(310, 55);
            this.Drawing_menu_button.TabIndex = 3;
            this.Drawing_menu_button.Text = "Drawing";
            this.Drawing_menu_button.UseVisualStyleBackColor = true;
            this.Drawing_menu_button.Click += new System.EventHandler(this.Drawing_click);
            // 
            // Token_menu_button
            // 
            this.Token_menu_button.Location = new System.Drawing.Point(1267, 20);
            this.Token_menu_button.Name = "Token_menu_button";
            this.Token_menu_button.Size = new System.Drawing.Size(310, 55);
            this.Token_menu_button.TabIndex = 4;
            this.Token_menu_button.Text = "Tokens";
            this.Token_menu_button.UseVisualStyleBackColor = true;
            this.Token_menu_button.Click += new System.EventHandler(this.Token_menu_Click);
            // 
            // Button_Box
            // 
            this.Button_Box.Controls.Add(this.Load_map_button);
            this.Button_Box.Controls.Add(this.Token_menu_button);
            this.Button_Box.Controls.Add(this.grid_toggle_button);
            this.Button_Box.Controls.Add(this.Drawing_menu_button);
            this.Button_Box.Controls.Add(this.Change_grid_button);
            this.Button_Box.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button_Box.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Box.Location = new System.Drawing.Point(5, 878);
            this.Button_Box.Name = "Button_Box";
            this.Button_Box.Size = new System.Drawing.Size(1985, 75);
            this.Button_Box.TabIndex = 6;
            this.Button_Box.TabStop = false;
            this.Button_Box.Resize += new System.EventHandler(this.Button_Box_Resize);
            // 
            // user_info_display
            // 
            this.user_info_display.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_info_display.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.user_info_display.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.user_info_display.Location = new System.Drawing.Point(5, 5);
            this.user_info_display.Name = "user_info_display";
            this.user_info_display.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.user_info_display.Size = new System.Drawing.Size(1985, 54);
            this.user_info_display.TabIndex = 7;
            this.user_info_display.Text = "feedback display";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(166, 41);
            this.toolStripStatusLabel1.Text = "strip_status";
            this.toolStripStatusLabel1.MouseEnter += new System.EventHandler(this.toolStripStatusLabel1_MouseEnter);
            this.toolStripStatusLabel1.MouseLeave += new System.EventHandler(this.toolStripStatusLabel1_MouseLeave);
            // 
            // Options_menu
            // 
            this.Options_menu.Controls.Add(this.Menu_interact_button);
            this.Options_menu.Controls.Add(this.suboptions_Menu);
            this.Options_menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.Options_menu.Location = new System.Drawing.Point(1680, 59);
            this.Options_menu.Name = "Options_menu";
            this.Options_menu.Size = new System.Drawing.Size(310, 819);
            this.Options_menu.TabIndex = 8;
            this.Options_menu.TabStop = false;
            this.Options_menu.Text = "options_menu";
            // 
            // Menu_interact_button
            // 
            this.Menu_interact_button.Location = new System.Drawing.Point(17, 602);
            this.Menu_interact_button.Name = "Menu_interact_button";
            this.Menu_interact_button.Size = new System.Drawing.Size(271, 47);
            this.Menu_interact_button.TabIndex = 6;
            this.Menu_interact_button.Text = "Menu Interact";
            this.Menu_interact_button.UseVisualStyleBackColor = true;
            // 
            // suboptions_Menu
            // 
            this.suboptions_Menu.DataSource = this.map_data_Set;
            this.suboptions_Menu.FormattingEnabled = true;
            this.suboptions_Menu.ItemHeight = 31;
            this.suboptions_Menu.Location = new System.Drawing.Point(17, 37);
            this.suboptions_Menu.Name = "suboptions_Menu";
            this.suboptions_Menu.Size = new System.Drawing.Size(271, 562);
            this.suboptions_Menu.TabIndex = 0;
            this.suboptions_Menu.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // map_data_Set
            // 
            this.map_data_Set.DataSetName = "Map_data_Set";
            // 
            // picture_grabbing
            // 
            this.picture_grabbing.Title = "Load Map";
            this.picture_grabbing.FileOk += new System.ComponentModel.CancelEventHandler(this.picture_grabbing_FileOk);
            // 
            // grid_picture_Box
            // 
            this.grid_picture_Box.BackColor = System.Drawing.Color.Transparent;
            this.grid_picture_Box.BackgroundImage = global::Hoyle_VTT.Properties.Resources.graph_paper_grid_png_4;
            this.grid_picture_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grid_picture_Box.Cursor = System.Windows.Forms.Cursors.Default;
            this.grid_picture_Box.Location = new System.Drawing.Point(12, 57);
            this.grid_picture_Box.MinimumSize = new System.Drawing.Size(150, 150);
            this.grid_picture_Box.Name = "grid_picture_Box";
            this.grid_picture_Box.Size = new System.Drawing.Size(1099, 654);
            this.grid_picture_Box.TabIndex = 9;
            this.grid_picture_Box.TabStop = false;
            this.grid_picture_Box.Click += new System.EventHandler(this.grid_picture_Box_Click);
            // 
            // Token_Data_Set
            // 
            this.Token_Data_Set.DataSetName = "Token Menu data";
            // 
            // Drawing_Data_set
            // 
            this.Drawing_Data_set.DataSetName = "Drawing Data Menu";
            // 
            // VTT_table_box
            // 
            this.VTT_table_box.Cursor = System.Windows.Forms.Cursors.Default;
            this.VTT_table_box.Image = ((System.Drawing.Image)(resources.GetObject("VTT_table_box.Image")));
            this.VTT_table_box.Location = new System.Drawing.Point(12, 57);
            this.VTT_table_box.MinimumSize = new System.Drawing.Size(150, 150);
            this.VTT_table_box.Name = "VTT_table_box";
            this.VTT_table_box.Size = new System.Drawing.Size(1250, 654);
            this.VTT_table_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VTT_table_box.TabIndex = 1;
            this.VTT_table_box.TabStop = false;
            this.VTT_table_box.SizeChanged += new System.EventHandler(this.VTT_table_box_SizeChanged);
            this.VTT_table_box.Click += new System.EventHandler(this.VTT_table_box_Click);
            // 
            // VTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1995, 958);
            this.Controls.Add(this.Options_menu);
            this.Controls.Add(this.user_info_display);
            this.Controls.Add(this.Button_Box);
            this.Controls.Add(this.grid_picture_Box);
            this.Controls.Add(this.VTT_table_box);
            this.Name = "VTT";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DpiChanged += new System.Windows.Forms.DpiChangedEventHandler(this.VTT_DpiChanged);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VTT_key_press);
            this.Resize += new System.EventHandler(this.VTT_Resize);
            this.Button_Box.ResumeLayout(false);
            this.user_info_display.ResumeLayout(false);
            this.user_info_display.PerformLayout();
            this.Options_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.map_data_Set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_picture_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Token_Data_Set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drawing_Data_set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VTT_table_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load_map_button;
        private System.Windows.Forms.Button grid_toggle_button;
        private System.Windows.Forms.Button Change_grid_button;
        private System.Windows.Forms.Button Drawing_menu_button;
        private System.Windows.Forms.Button Token_menu_button;
        private System.Windows.Forms.GroupBox Button_Box;
        private System.Windows.Forms.StatusStrip user_info_display;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox Options_menu;
        private System.Windows.Forms.OpenFileDialog picture_grabbing;
        private System.Windows.Forms.ToolTip Info_bot;
        private System.Windows.Forms.ListBox suboptions_Menu;
        private System.Windows.Forms.PictureBox grid_picture_Box;
        private System.Windows.Forms.Button Menu_interact_button;
        private System.Data.DataSet map_data_Set;
        private System.Data.DataSet Token_Data_Set;
        private System.Data.DataSet Drawing_Data_set;
        private System.Windows.Forms.PictureBox VTT_table_box;
    }
}

