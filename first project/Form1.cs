using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_project
{
    public partial class Form1 : Form
    {
        public GameCode myGameCode = new GameCode();

        public UnmanagedMemoryStream SoundPlayer { get; private set; }

        public Form1()
        {
            InitializeComponent();
            //sets the visability of each button
            btnSpin.Visible = false;
            btnFire.Visible = false;
            btnCheckBush.Visible = false;
            btnTryAgain.Visible = false;
            this.Text = "Wins " + myGameCode.winCount + " losses " + myGameCode.lossCount;

        }

        public void btnLoad_Click(object sender, EventArgs e)
        {


            lbxOutput.Items.Add(myGameCode.count);
            SoundPlayer simpleSound = new SoundPlayer(Resource1.m1_garand_clip);
            simpleSound.Play();
            //Shows the Spin Chamber button. And hides load gun button
            btnSpin.Visible = true;
            btnLoad.Visible = false;
            

        }

        //this btn creates a random number which the bullet is located
        public void btnSpin_Click(object sender, EventArgs e)
        {
            myGameCode.rnd = myGameCode.RNDGenerator();
            //shows the random number for the time being
            lbxOutput.Items.Add(myGameCode.rnd);
            //Hides the spin button
            btnSpin.Visible = false;
            //shows the fire button
            btnFire.Visible = true;
            bush1.Visible = true;
            
            //
            btnCheckBush.Visible = true;
        }

        //this button shots making the counter go up by 1 each time 

        public void btnFire_Click(object sender, EventArgs e)
        {
            myGameCode.count += 1;

            //shows the current number in the list box
            lbxOutput.Items.Add(myGameCode.count);

            SoundPlayer simpleSound = new SoundPlayer(Resource1.m1_garand);
            simpleSound.Play();

            //when fire button is same number as rnd number you lose
            if (myGameCode.count == myGameCode.rnd)
            {
                //picks dead_person image when count number is the same as rnd number
                picBackground.Image = Resource1.dead_person;
                //changes if things are visable or not
                btnTryAgain.Visible = true;
                btnFire.Visible = false;
                btnCheckBush.Visible = false;
                bush1.Visible = false;
                bush2.Visible = false;
                bush3.Visible = false;
                bush4.Visible = false;
                bush5.Visible = false;
                bush6.Visible = false;
                //Shows how many lsses you have
                myGameCode.lossCount += 1;
                this.Text = "Wins " + myGameCode.winCount + " losses " + myGameCode.lossCount;
            }


            switch (myGameCode.count)
            {
                //each case reprasents a different number/ or bush
                case 1:
                    
                    bush1.Image = Resource1.deer_test_1;
                    
                    break;
                case 2:
                    
                    bush2.Image = Resource1.bear_test_1;
                    break;
                case 3:
                    
                    bush3.Image = Resource1.deer_test_1;
                    break;
                case 4:
                   
                    bush4.Image = Resource1.bear_test_1;
                    break;
                case 5:
                    
                    bush5.Image = Resource1.rabbit_test_1;
                    break;
                case 6:
                    bush6.Image = Resource1.rabbit_test_1;
                    break;
                    myGameCode.count = 0;
                    break;
            }
        }



        //this button shots making the counter go up by 1 each time
        public void btnCheckBush_Click(object sender, EventArgs e)
        {
            myGameCode.checkCount += 1;
            myGameCode.count += 1;

            //shows the current number in the list box 
            lbxOutput.Items.Add(myGameCode.count);

            //when check button is same number as rnd number you win
            if (myGameCode.count == myGameCode.rnd)
            {
                picBackground.Image = Resource1.you_win;
                btnTryAgain.Visible = true;
                btnFire.Visible = false;
                btnCheckBush.Visible = false;
                bush1.Visible = false;
                bush2.Visible = false;
                bush3.Visible = false;
                bush4.Visible = false;
                bush5.Visible = false;
                bush6.Visible = false;
                //Shows how many wins you have
                myGameCode.winCount += 1;
                this.Text = "Wins " + myGameCode.winCount + " losses " + myGameCode.lossCount;

            }

            //after hitting the buton twice the button will disappear
            if (myGameCode.checkCount == 2)
            {
                btnCheckBush.Visible = false;
            }


            switch (myGameCode.count)
            {

                //each case reprasents a different number/ or bush 
                case 1:
                    
                    bush1.Image = Resource1.alive_deer;

                    break;
                case 2:
                    
                    bush2.Image = Resource1.alive_deer;
                    break;
                case 3:
                    
                    bush3.Image = Resource1.alive_deer;
                    break;
                case 4:
                    
                    bush4.Image = Resource1.alive_deer;
                    break;
                case 5:
                    
                    bush5.Image = Resource1.alive_deer;
                    break;
                case 6:
                    bush6.Image = Resource1.rabbit_test_1;
                    break;
                    myGameCode.count = 0;
                    break;
            }
        }

        //this utton resets all bushs tothe right bush and makes them vivible again asweel as btn load visible
        //and resets count to 0

        public void btnTryAgain_Click(object sender, EventArgs e)
        {
            myGameCode.count = 0;
            picBackground.Image = Resource1.background;
            btnLoad.Visible = true;
            bush1.Visible = true;
            bush2.Visible = true;
            bush3.Visible = true;
            bush4.Visible = true;
            bush5.Visible = true;
            bush6.Visible = true;
            bush1.Image = Resource1.bush1;
            bush2.Image = Resource1.bush3;
            bush3.Image = Resource1.bush2;
            bush4.Image = Resource1.bush1;
            bush5.Image = Resource1.bush2;
            bush6.Image = Resource1.bush3;
            btnTryAgain.Visible = false;
        }
    }
}
