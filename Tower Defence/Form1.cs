﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Tower_Defence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Make animation

            //Show Menu Screen

            //Check to see if easy button has been pressed

            //Check to see if medium button has been pressed

            //Check to see if hard button has been pressed

            //Check to see if insane button has been pressed

            //Check to see if exit button has been pressed

        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //Check to see if user has grabbed tower

            //Check to see if any towers have been upgraded

            //Check to see if any towers have been sold

            //Check to see if it is time to shoot

            //Check to see if there is a bullet on the screen

            //Check to see if there are any bullets off the screen

            //Check to see if the robots have been shot

            //Check to see if the robots have been killed

            //Check to see if any robots made it to the end of the path

            //Are there any lives left

            //Check to see if the wave is completed

            //Check to see if all the waves have been completed

            Refresh();
        }
        public void towerGrabbed()
        {

        }
        public void towerUpgraded()
        {

        }
        public void towerSold()
        {

        }
        public void shootBullet()
        {

        }
        public void moveBullet()
        {

        }
        public void removeBullet()
        {

        }
        public void bulletHitRobot()
        {

        }
        public void robotKill()
        {

        }
        public void loseLives()
        {

        }
        public void outOfLives()
        {

        }
        public void waveCompleted()
        {

        }
        public void gameCompleted()
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
