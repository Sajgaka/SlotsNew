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
            intLeftImgNum = rnd.Next(0, 5);
            randIntervalLeft = rnd.Next(60, 123);

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
            intMiddleImgNum = rnd.Next(0, 5);
            randIntervalMiddle = rnd.Next(60, 123);

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
            intRightImgNum = rnd.Next(0, 1);
            randIntervalRight = rnd.Next(60, 123);

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
        int SystemTime = 0;
        private void timerSystemTime_Tick(object sender, EventArgs e)
        {
            SystemTime  ++;
             if (SystemTime > 124)
            {
                buttonPlayAgain.Visible = true;
                CalculateChoice();
                timerSystemTime.Stop();
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
            TimerLeftSlot.Start();
            TimerRightSlot.Start();
            TimerMiddleSlot.Start();
            timerSystemTime.Start();
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

        int checkBoxChoice = -1;
        private void checkBoxGrusa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGrusa.Checked == true)
            {
                checkBoxChoice = 1;
                checkBoxVisna.Visible = false;
                checkBoxStar.Visible = false;
                checkBoxKlub.Visible =false;
                checkBox7.Visible = false;
            }
            else if (checkBoxGrusa.Checked == false)
            {
                checkBoxChoice = -1;
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
                checkBoxChoice = 3;
                checkBoxGrusa.Visible = false;
                checkBoxStar.Visible = false;
                checkBoxKlub.Visible = false;
                checkBox7.Visible = false;
            }
            else if (checkBoxVisna.Checked == false)
            {
                checkBoxChoice = -1;
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
                checkBoxChoice = 0;
                checkBoxVisna.Visible = false;
                checkBoxGrusa.Visible = false;
                checkBoxKlub.Visible = false;
                checkBox7.Visible = false;
            }
            else if (checkBoxStar.Checked == false)
            {
                checkBoxChoice = -1;
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
                checkBoxChoice = 4;
                checkBoxVisna.Visible = false;
                checkBoxGrusa.Visible = false;
                checkBoxKlub.Visible = false;
                checkBoxStar.Visible = false;
            }
            else if (checkBox7.Checked == false)
            {
                checkBoxChoice = -1;
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
                checkBoxChoice = 2;
                checkBoxVisna.Visible = false;
                checkBoxGrusa.Visible = false;
                checkBox7.Visible = false;
                checkBoxStar.Visible = false;
            }
            else if (checkBoxKlub.Checked == false)
            {
                checkBoxChoice = -1;
                checkBoxVisna.Visible = true;
                checkBoxGrusa.Visible = true;
                checkBox7.Visible = true;
                checkBoxStar.Visible = true;
            }
        }

        int checkBoxCountChoice = 0;
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBoxCountChoice = 3;
                checkBox2.Visible = false;
                checkBox1.Visible = false;
            }
            else if (checkBox3.Checked == false)
            {
                checkBoxCountChoice = 0;
                checkBox2.Visible = true;
                checkBox1.Visible = true;
            }
                
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBoxCountChoice = 2;
                checkBox3.Visible = false;
                checkBox1.Visible = false;
            }
            else if (checkBox2.Checked == false)
            {
                checkBoxCountChoice = 0;
                checkBox3.Visible = true;
                checkBox1.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBoxCountChoice = 1;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
            }
            else if (checkBox1.Checked == false)
            {
                checkBoxCountChoice = 0;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
            }
        }

        private void CalculateChoice()
        {
            switch (checkBoxCountChoice)
            {
                case 1:
                    if ((checkBoxChoice == finalLeftPicIndex) && (checkBoxChoice != finalMiddlePicIndex) && (checkBoxChoice != finalRightPicIndex))
                    {
                        labelText.Text = "100";
                        //WIN
                    }
                    else if ((checkBoxChoice != finalLeftPicIndex) && (checkBoxChoice == finalMiddlePicIndex) && (checkBoxChoice != finalRightPicIndex))
                    {
                        labelText.Text = "100";
                        //WIN
                    }
                    else if ((checkBoxChoice != finalLeftPicIndex) && (checkBoxChoice != finalMiddlePicIndex) && (checkBoxChoice == finalRightPicIndex))
                    {
                        labelText.Text = "100";
                        //WIN
                    }
                    else
                    {
                        //LOOSE
                    }
                    break;
                case 2:
                    if ((checkBoxChoice == finalLeftPicIndex) && (checkBoxChoice == finalMiddlePicIndex) && (checkBoxChoice != finalRightPicIndex))
                    {
                        //WIN
                    }
                    else if ((checkBoxChoice != finalLeftPicIndex) && (checkBoxChoice == finalMiddlePicIndex) && (checkBoxChoice == finalRightPicIndex))
                    {
                        //WIN
                    }
                    else if ((checkBoxChoice == finalLeftPicIndex) && (checkBoxChoice != finalMiddlePicIndex) && (checkBoxChoice == finalRightPicIndex))
                    {
                        //WIN
                    }
                    else
                    {
                        //LOOSE
                    }
                    break;
                case 3:
                    if ((checkBoxChoice == finalLeftPicIndex) && (checkBoxChoice == finalMiddlePicIndex) && (checkBoxChoice == finalRightPicIndex))
                    {
                        //WIN
                    }
                    else
                    {
                        //LOOSE
                    }
                    break;

                case 0:
                    break;
            }
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            

            buttonMenuPlay.Visible = true;
            PictureBoxMenu.Visible = true;

            checkBoxGrusa.Visible = true;
            checkBoxVisna.Visible = true;
            checkBoxStar.Visible = true;
            checkBox7.Visible = true;
            checkBoxKlub.Visible = true;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;

            buttonPlayAgain.Visible = false;
        }
    }
}
