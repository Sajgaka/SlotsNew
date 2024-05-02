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
        int finalLeftPicIndex = 0;
        private void TimerLeftSlot_Tick(object sender, EventArgs e)
        {
            intLeftImgNum = rnd.Next(0, 4);
            randIntervalLeft = rnd.Next(60, 133);

            counterLeft++;
            if (counterLeft > randIntervalLeft)
            {
                TimerLeftSlot.Stop();
                finalLeftPicIndex = intLeftImgNum;
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
        int finalMiddlePicIndex = 0;
        private void TimerMiddleSlot_Tick(object sender, EventArgs e)
        {
            intMiddleImgNum = rnd.Next(0, 3);
            randIntervalMiddle = rnd.Next(60, 133);

            counterMiddle++;
            if (counterMiddle > randIntervalMiddle)
            {
                TimerMiddleSlot.Stop();
                finalMiddlePicIndex = intMiddleImgNum;
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
        int finalRightPicIndex = 0;
        private void TimerRightSlot_Tick(object sender, EventArgs e)
        {
            intRightImgNum = rnd.Next(0, 3);
            randIntervalRight = rnd.Next(60, 133);

            counterRight++;
            if (counterRight > randIntervalRight)
            {
                TimerRightSlot.Stop();
                finalRightPicIndex = intRightImgNum;
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
            buttonMenuPlay.Visible = false;
            PictureBoxMenu.Visible = false;

            checkBoxGrusa.Visible = false; 
            checkBoxVisna.Visible = false;  
            checkBoxStar.Visible = false;   
            checkBox7.Visible = false;
            checkBoxKlub.Visible = false;   
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            pictureboxRules.Visible = false;
            buttonRulesOff.Visible = false;
        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            buttonRulesOff.Visible = true;
            pictureboxRules.Visible = true;
        }

        private void buttonRulesOff_Click(object sender, EventArgs e)
        {
            buttonRulesOff.Visible = false;
            pictureboxRules.Visible = false;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxGrusa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGrusa.Checked == true)
            {
                checkBoxVisna.Visible = false;
                checkBoxStar.Visible = false;
                checkBoxKlub.Visible =false;
                checkBox7.Visible = false;
            }
            else if (checkBoxGrusa.Checked == false)
            {
                checkBoxVisna.Visible = true;
                checkBoxStar.Visible = true;
                checkBoxKlub.Visible = true;
                checkBox7.Visible = true;
            }
            
        }

        private void checkBoxVisna_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVisna.Checked == true)
            {
                checkBoxGrusa.Visible = false;
                checkBoxStar.Visible = false;
                checkBoxKlub.Visible = false;
                checkBox7.Visible = false;
            }
            else if (checkBoxVisna.Checked == false)
            {
                checkBoxGrusa.Visible = true;
                checkBoxStar.Visible = true;
                checkBoxKlub.Visible = true;
                checkBox7.Visible = true;
            }
        }

        private void checkBoxStar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStar.Checked == true)
            {
                checkBoxVisna.Visible = false;
                checkBoxGrusa.Visible = false;
                checkBoxKlub.Visible = false;
                checkBox7.Visible = false;
            }
            else if (checkBoxStar.Checked == false)
            {
                checkBoxVisna.Visible = true;
                checkBoxGrusa.Visible = true;
                checkBoxKlub.Visible = true;
                checkBox7.Visible = true;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                checkBoxVisna.Visible = false;
                checkBoxGrusa.Visible = false;
                checkBoxKlub.Visible = false;
                checkBoxStar.Visible = false;
            }
            else if (checkBox7.Checked == false)
            {
                checkBoxVisna.Visible = true;
                checkBoxGrusa.Visible = true;
                checkBoxKlub.Visible = true;
                checkBoxStar.Visible = true;
            }
        }

        private void checkBoxKlub_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKlub.Checked == true)
            {
                checkBoxVisna.Visible = false;
                checkBoxGrusa.Visible = false;
                checkBox7.Visible = false;
                checkBoxStar.Visible = false;
            }
            else if (checkBoxKlub.Checked == false)
            {
                checkBoxVisna.Visible = true;
                checkBoxGrusa.Visible = true;
                checkBox7.Visible = true;
                checkBoxStar.Visible = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox2.Visible = false;
                checkBox1.Visible = false;
            }
            else if (checkBox3.Checked == false)
            {
                checkBox2.Visible = true;
                checkBox1.Visible = true;
            }
                
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox3.Visible = false;
                checkBox1.Visible = false;
            }
            else if (checkBox2.Checked == false)
            {
                checkBox3.Visible = true;
                checkBox1.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Visible = false;
                checkBox3.Visible = false;
            }
            else if (checkBox1.Checked == false)
            {
                checkBox2.Visible = true;
                checkBox3.Visible = true;
            }
        }
    }
}
