using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace ArcadeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //change visibility of start button when clicked
            startButton.Hide();
            Refresh();
            Thread.Sleep(1000);

            //change to label1
            label1.Hide();
            Refresh();
            Thread.Sleep(1000);

            //change to label2
            label2.Hide();
            Refresh();
            Thread.Sleep(1000);

            //change to label3
            label3.Hide();
            Refresh();
            Thread.Sleep(50);

            //Change backcolour
            this.BackColor = Color.GreenYellow;
            Refresh();
            Thread.Sleep(500);

            //create a sound player and load the alert.wav sound, then play it 
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.gameBegin);
            alertPlayer.Play();
            Refresh();
            Thread.Sleep(1000);

            //Change colour of form1 and to Go
            goLabel.Hide();
            
           

            

            


            

            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

