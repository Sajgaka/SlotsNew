using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotsNew
{
    public partial class SlotsForm : Form
    {
        public SlotsForm()
        {
            InitializeComponent();
        }
        private Random rnd = new Random();
        int intLeftImgNum = 0;
        private void TimerLeftSlot_Tick(object sender, EventArgs e)
        {
            intLeftImgNum = rnd.Next(0, 4);
            pictureBoxLeftSlot.Image = imageListLeftSlot.Images[intLeftImgNum];
            if (intLeftImgNum == imageListLeftSlot.Images.Count - 1)
            {
                intLeftImgNum = 0;
            }
            else
            {
                intLeftImgNum++;
            }

        }

        int intMiddleImgNum = 0;
        private void TimerMiddleSlot_Tick(object sender, EventArgs e)
        {
            intMiddleImgNum = rnd.Next(0, 3);

            pictureBoxMiddleSlot.Image = imageListMiddleSlot.Images[intMiddleImgNum];
            if (intMiddleImgNum == imageListMiddleSlot.Images.Count - 1)
            {
                intMiddleImgNum = 0;
            }
            else
            {
                intMiddleImgNum++;
            }
        }

        int intRightImgNum = 0;
        private void TimerRightSlot_Tick(object sender, EventArgs e)
        {
            intRightImgNum = rnd.Next(0, 3);

            pictureBoxRightSlot.Image = imageListRightSlot.Images[intRightImgNum];
            if (intRightImgNum == imageListRightSlot.Images.Count - 1)
            {
                intRightImgNum = 0;
            }
            else
            {
                intRightImgNum++;
            }
        }



        private void buttonMenu_Click(object sender, EventArgs e)
        {
            buttonMenu.Visible = false;
            PictureBoxMenu.Visible = false;
            TimerLeftSlot.Start();
            TimerMiddleSlot.Start();
            TimerRightSlot.Start();
 
        }

        private void SlotsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                TimerLeftSlot.Stop();
                TimerMiddleSlot.Stop();
                TimerRightSlot.Stop
            }
        }
    }
}
