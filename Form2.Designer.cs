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
            this.buttonMenuPlay = new System.Windows.Forms.Button();
            this.checkBoxGrusa = new System.Windows.Forms.CheckBox();
            this.checkBoxVisna = new System.Windows.Forms.CheckBox();
            this.checkBoxStar = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBoxKlub = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.buttonQuestion = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureboxRules = new System.Windows.Forms.PictureBox();
            this.buttonRulesOff = new System.Windows.Forms.Button();
            this.timerSystemTime = new System.Windows.Forms.Timer(this.components);
            this.Balance = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.labelPlus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiddleSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxRules)).BeginInit();
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
            this.imageListMiddleSlot.Images.SetKeyName(0, "Star.jpg");
            this.imageListMiddleSlot.Images.SetKeyName(1, "Grus.jpg");
            this.imageListMiddleSlot.Images.SetKeyName(2, "Straw.jpg");
            this.imageListMiddleSlot.Images.SetKeyName(3, "Vis.jpg");
            this.imageListMiddleSlot.Images.SetKeyName(4, "7.jpg");
            // 
            // imageListRightSlot
            // 
            this.imageListRightSlot.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListRightSlot.ImageStream")));
            this.imageListRightSlot.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListRightSlot.Images.SetKeyName(0, "Star.jpg");
            this.imageListRightSlot.Images.SetKeyName(1, "Grus.jpg");
            this.imageListRightSlot.Images.SetKeyName(2, "Straw.jpg");
            this.imageListRightSlot.Images.SetKeyName(3, "Vis.jpg");
            this.imageListRightSlot.Images.SetKeyName(4, "7.jpg");
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
            this.PictureBoxMenu.BackgroundImage = global::SlotsNew.Properties.Resources.Menu2;
            this.PictureBoxMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxMenu.Location = new System.Drawing.Point(301, 106);
            this.PictureBoxMenu.Name = "PictureBoxMenu";
            this.PictureBoxMenu.Size = new System.Drawing.Size(762, 576);
            this.PictureBoxMenu.TabIndex = 3;
            this.PictureBoxMenu.TabStop = false;
            // 
            // buttonMenuPlay
            // 
            this.buttonMenuPlay.BackgroundImage = global::SlotsNew.Properties.Resources.ButtonPlay22;
            this.buttonMenuPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMenuPlay.Location = new System.Drawing.Point(933, 566);
            this.buttonMenuPlay.Name = "buttonMenuPlay";
            this.buttonMenuPlay.Size = new System.Drawing.Size(100, 100);
            this.buttonMenuPlay.TabIndex = 4;
            this.buttonMenuPlay.Text = "Play ";
            this.buttonMenuPlay.UseVisualStyleBackColor = true;
            this.buttonMenuPlay.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // checkBoxGrusa
            // 
            this.checkBoxGrusa.AutoSize = true;
            this.checkBoxGrusa.Location = new System.Drawing.Point(484, 387);
            this.checkBoxGrusa.Name = "checkBoxGrusa";
            this.checkBoxGrusa.Size = new System.Drawing.Size(15, 14);
            this.checkBoxGrusa.TabIndex = 5;
            this.checkBoxGrusa.UseVisualStyleBackColor = true;
            this.checkBoxGrusa.CheckedChanged += new System.EventHandler(this.checkBoxGrusa_CheckedChanged);
            // 
            // checkBoxVisna
            // 
            this.checkBoxVisna.AutoSize = true;
            this.checkBoxVisna.Location = new System.Drawing.Point(580, 387);
            this.checkBoxVisna.Name = "checkBoxVisna";
            this.checkBoxVisna.Size = new System.Drawing.Size(15, 14);
            this.checkBoxVisna.TabIndex = 6;
            this.checkBoxVisna.UseVisualStyleBackColor = true;
            this.checkBoxVisna.CheckedChanged += new System.EventHandler(this.checkBoxVisna_CheckedChanged);
            // 
            // checkBoxStar
            // 
            this.checkBoxStar.AutoSize = true;
            this.checkBoxStar.Location = new System.Drawing.Point(686, 387);
            this.checkBoxStar.Name = "checkBoxStar";
            this.checkBoxStar.Size = new System.Drawing.Size(15, 14);
            this.checkBoxStar.TabIndex = 7;
            this.checkBoxStar.UseVisualStyleBackColor = true;
            this.checkBoxStar.CheckedChanged += new System.EventHandler(this.checkBoxStar_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(773, 387);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(15, 14);
            this.checkBox7.TabIndex = 8;
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBoxKlub
            // 
            this.checkBoxKlub.AutoSize = true;
            this.checkBoxKlub.Location = new System.Drawing.Point(862, 387);
            this.checkBoxKlub.Name = "checkBoxKlub";
            this.checkBoxKlub.Size = new System.Drawing.Size(15, 14);
            this.checkBoxKlub.TabIndex = 9;
            this.checkBoxKlub.UseVisualStyleBackColor = true;
            this.checkBoxKlub.CheckedChanged += new System.EventHandler(this.checkBoxKlub_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(887, 566);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(686, 566);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(495, 566);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // buttonQuestion
            // 
            this.buttonQuestion.BackgroundImage = global::SlotsNew.Properties.Resources.Button_question;
            this.buttonQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonQuestion.Location = new System.Drawing.Point(1092, 26);
            this.buttonQuestion.Name = "buttonQuestion";
            this.buttonQuestion.Size = new System.Drawing.Size(80, 80);
            this.buttonQuestion.TabIndex = 13;
            this.buttonQuestion.UseVisualStyleBackColor = true;
            this.buttonQuestion.Click += new System.EventHandler(this.buttonQuestion_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = global::SlotsNew.Properties.Resources.Exit;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Location = new System.Drawing.Point(1187, 26);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(80, 80);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureboxRules
            // 
            this.pictureboxRules.BackgroundImage = global::SlotsNew.Properties.Resources.Rules_for_casino_online;
            this.pictureboxRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureboxRules.Location = new System.Drawing.Point(-66, 316);
            this.pictureboxRules.Name = "pictureboxRules";
            this.pictureboxRules.Size = new System.Drawing.Size(450, 450);
            this.pictureboxRules.TabIndex = 15;
            this.pictureboxRules.TabStop = false;
            this.pictureboxRules.Visible = false;
            // 
            // buttonRulesOff
            // 
            this.buttonRulesOff.AutoSize = true;
            this.buttonRulesOff.Location = new System.Drawing.Point(810, 547);
            this.buttonRulesOff.Name = "buttonRulesOff";
            this.buttonRulesOff.Size = new System.Drawing.Size(75, 23);
            this.buttonRulesOff.TabIndex = 16;
            this.buttonRulesOff.Text = "OK";
            this.buttonRulesOff.UseVisualStyleBackColor = true;
            this.buttonRulesOff.Visible = false;
            this.buttonRulesOff.Click += new System.EventHandler(this.buttonRulesOff_Click);
            // 
            // timerSystemTime
            // 
            this.timerSystemTime.Enabled = true;
            this.timerSystemTime.Interval = 124;
            this.timerSystemTime.Tick += new System.EventHandler(this.timerSystemTime_Tick);
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Balance.ForeColor = System.Drawing.Color.Black;
            this.Balance.Location = new System.Drawing.Point(572, 59);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(171, 41);
            this.Balance.TabIndex = 17;
            this.Balance.Text = "Balance:";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.ForeColor = System.Drawing.Color.Black;
            this.labelText.Location = new System.Drawing.Point(791, 59);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(64, 41);
            this.labelText.TabIndex = 18;
            this.labelText.Text = "00";
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.BackgroundImage = global::SlotsNew.Properties.Resources.PlayAgain2;
            this.buttonPlayAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlayAgain.Location = new System.Drawing.Point(977, 557);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(100, 100);
            this.buttonPlayAgain.TabIndex = 19;
            this.buttonPlayAgain.UseVisualStyleBackColor = true;
            this.buttonPlayAgain.Visible = false;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // labelPlus
            // 
            this.labelPlus.AutoSize = true;
            this.labelPlus.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlus.ForeColor = System.Drawing.Color.Black;
            this.labelPlus.Location = new System.Drawing.Point(744, 59);
            this.labelPlus.Name = "labelPlus";
            this.labelPlus.Size = new System.Drawing.Size(41, 41);
            this.labelPlus.TabIndex = 20;
            this.labelPlus.Text = "0";
            this.labelPlus.Visible = false;
            // 
            // SlotsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SlotsNew.Properties.Resources.Slots;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1274, 778);
            this.Controls.Add(this.labelPlus);
            this.Controls.Add(this.buttonPlayAgain);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.buttonRulesOff);
            this.Controls.Add(this.pictureboxRules);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonQuestion);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBoxKlub);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBoxStar);
            this.Controls.Add(this.checkBoxVisna);
            this.Controls.Add(this.checkBoxGrusa);
            this.Controls.Add(this.buttonMenuPlay);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxRules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button buttonMenuPlay;
        private System.Windows.Forms.CheckBox checkBoxGrusa;
        private System.Windows.Forms.CheckBox checkBoxVisna;
        private System.Windows.Forms.CheckBox checkBoxStar;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBoxKlub;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button buttonQuestion;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureboxRules;
        private System.Windows.Forms.Button buttonRulesOff;
        private System.Windows.Forms.Timer timerSystemTime;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonPlayAgain;
        private System.Windows.Forms.Label labelPlus;
    }
}