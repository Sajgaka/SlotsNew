namespace SlotsNew
{
    partial class SlotsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlotsForm));
            this.pictureBoxLeftSlot = new System.Windows.Forms.PictureBox();
            this.pictureBoxMiddleSlot = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightSlot = new System.Windows.Forms.PictureBox();
            this.imageListLeftSlot = new System.Windows.Forms.ImageList(this.components);
            this.imageListMiddleSlot = new System.Windows.Forms.ImageList(this.components);
            this.imageListRightSlot = new System.Windows.Forms.ImageList(this.components);
            this.TimerLeftSlot = new System.Windows.Forms.Timer(this.components);
            this.TimerMiddleSlot = new System.Windows.Forms.Timer(this.components);
            this.TimerRightSlot = new System.Windows.Forms.Timer(this.components);
            this.PictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiddleSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLeftSlot
            // 
            this.pictureBoxLeftSlot.BackgroundImage = global::SlotsNew.Properties.Resources.Straw;
            this.pictureBoxLeftSlot.Location = new System.Drawing.Point(390, 374);
            this.pictureBoxLeftSlot.Name = "pictureBoxLeftSlot";
            this.pictureBoxLeftSlot.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxLeftSlot.TabIndex = 0;
            this.pictureBoxLeftSlot.TabStop = false;
            // 
            // pictureBoxMiddleSlot
            // 
            this.pictureBoxMiddleSlot.Location = new System.Drawing.Point(571, 374);
            this.pictureBoxMiddleSlot.Name = "pictureBoxMiddleSlot";
            this.pictureBoxMiddleSlot.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxMiddleSlot.TabIndex = 1;
            this.pictureBoxMiddleSlot.TabStop = false;
            // 
            // pictureBoxRightSlot
            // 
            this.pictureBoxRightSlot.Location = new System.Drawing.Point(752, 374);
            this.pictureBoxRightSlot.Name = "pictureBoxRightSlot";
            this.pictureBoxRightSlot.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxRightSlot.TabIndex = 2;
            this.pictureBoxRightSlot.TabStop = false;
            // 
            // imageListLeftSlot
            // 
            this.imageListLeftSlot.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLeftSlot.ImageStream")));
            this.imageListLeftSlot.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLeftSlot.Images.SetKeyName(0, "Star.jpg");
            this.imageListLeftSlot.Images.SetKeyName(1, "Grus.jpg");
            this.imageListLeftSlot.Images.SetKeyName(2, "Straw.jpg");
            this.imageListLeftSlot.Images.SetKeyName(3, "Vis.jpg");
            this.imageListLeftSlot.Images.SetKeyName(4, "7.jpg");
            // 
            // imageListMiddleSlot
            // 
            this.imageListMiddleSlot.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMiddleSlot.ImageStream")));
            this.imageListMiddleSlot.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMiddleSlot.Images.SetKeyName(0, "7.jpg");
            this.imageListMiddleSlot.Images.SetKeyName(1, "Grus.jpg");
            this.imageListMiddleSlot.Images.SetKeyName(2, "Star.jpg");
            this.imageListMiddleSlot.Images.SetKeyName(3, "Straw.jpg");
            this.imageListMiddleSlot.Images.SetKeyName(4, "Vis.jpg");
            // 
            // imageListRightSlot
            // 
            this.imageListRightSlot.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListRightSlot.ImageStream")));
            this.imageListRightSlot.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListRightSlot.Images.SetKeyName(0, "Vis.jpg");
            this.imageListRightSlot.Images.SetKeyName(1, "7.jpg");
            this.imageListRightSlot.Images.SetKeyName(2, "Grus.jpg");
            this.imageListRightSlot.Images.SetKeyName(3, "Straw.jpg");
            this.imageListRightSlot.Images.SetKeyName(4, "Star.jpg");
            // 
            // TimerLeftSlot
            // 
            this.TimerLeftSlot.Enabled = true;
            this.TimerLeftSlot.Tick += new System.EventHandler(this.TimerLeftSlot_Tick);
            // 
            // TimerMiddleSlot
            // 
            this.TimerMiddleSlot.Enabled = true;
            this.TimerMiddleSlot.Tick += new System.EventHandler(this.TimerMiddleSlot_Tick);
            // 
            // TimerRightSlot
            // 
            this.TimerRightSlot.Enabled = true;
            this.TimerRightSlot.Tick += new System.EventHandler(this.TimerRightSlot_Tick);
            // 
            // PictureBoxMenu
            // 
            this.PictureBoxMenu.BackgroundImage = global::SlotsNew.Properties.Resources.Menu;
            this.PictureBoxMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxMenu.Location = new System.Drawing.Point(301, 106);
            this.PictureBoxMenu.Name = "PictureBoxMenu";
            this.PictureBoxMenu.Size = new System.Drawing.Size(762, 576);
            this.PictureBoxMenu.TabIndex = 3;
            this.PictureBoxMenu.TabStop = false;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(489, 417);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonMenu.TabIndex = 4;
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // SlotsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SlotsNew.Properties.Resources.Slots;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1274, 778);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.PictureBoxMenu);
            this.Controls.Add(this.pictureBoxRightSlot);
            this.Controls.Add(this.pictureBoxMiddleSlot);
            this.Controls.Add(this.pictureBoxLeftSlot);
            this.Name = "SlotsForm";
            this.Text = "Slots";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiddleSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLeftSlot;
        private System.Windows.Forms.PictureBox pictureBoxMiddleSlot;
        private System.Windows.Forms.PictureBox pictureBoxRightSlot;
        private System.Windows.Forms.ImageList imageListLeftSlot;
        private System.Windows.Forms.ImageList imageListMiddleSlot;
        private System.Windows.Forms.ImageList imageListRightSlot;
        private System.Windows.Forms.Timer TimerLeftSlot;
        private System.Windows.Forms.Timer TimerMiddleSlot;
        private System.Windows.Forms.Timer TimerRightSlot;
        private System.Windows.Forms.PictureBox PictureBoxMenu;
        private System.Windows.Forms.Button buttonMenu;
    }
}