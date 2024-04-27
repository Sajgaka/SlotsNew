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
        int randIntervalLeft = 0;
        int counterLeft = 0;
        private void TimerLeftSlot_Tick(object sender, EventArgs e)
        {
            intLeftImgNum = rnd.Next(0, 4);
            randIntervalLeft = rnd.Next(33, 133);

            counterLeft++;
            if (counterLeft > randIntervalLeft)
            {
                TimerLeftSlot.Stop();
            }
            else
            {
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

        }

        int intMiddleImgNum = 0;
        int randIntervalMiddle = 0;
        int counterMiddle = 0;
        private void TimerMiddleSlot_Tick(object sender, EventArgs e)
        {
            intMiddleImgNum = rnd.Next(0, 3);
            randIntervalMiddle = rnd.Next(33, 133);

            counterMiddle++;
            if (counterMiddle > randIntervalMiddle)
            {
                TimerMiddleSlot.Stop();
            }
            else
            {
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
        }

        int intRightImgNum = 0;
        int randIntervalRight = 0;
        int counterRight = 0;
        private void TimerRightSlot_Tick(object sender, EventArgs e)
        {
            intRightImgNum = rnd.Next(0, 3);
            randIntervalRight = rnd.Next(33, 133);

            counterRight++;
            if (counterRight > randIntervalRight)
            {
                TimerRightSlot.Stop();
            }
            else
            {

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
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            buttonMenu.Visible = false;
            PictureBoxMenu.Visible = false;
        }

        private void SlotsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                TimerLeftSlot.Stop();
                TimerMiddleSlot.Stop();
                TimerRightSlot.Stop();
            }
        }
    }
}
