using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND_Dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public variables
        bool rolling = false;

        // Dice Guide: 1 = d4, 2 = d6, 3 = d8, 4 = d10, 5 = d12, 6 = d20
        int diceType = 1;
        int diceNum = 0;

        //initializes the sound player and the random number class
        SoundPlayer diceRoll = new SoundPlayer("C:\\Dev\\c# class\\DND Dice\\DND Dice\\Assets\\dice_roll.wav");
        Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //D4 Button
            // 1 = d4, 2 = d6, 3 = d8, 4 = d10, 5 = d12, 6 = d20
            diceType = 1;
            DiceLogic();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //D6 Dice
            // 1 = d4, 2 = d6, 3 = d8, 4 = d10, 5 = d12, 6 = d20
            diceType = 2;
            DiceLogic();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //D10 Dice
            // 1 = d4, 2 = d6, 3 = d8, 4 = d10, 5 = d12, 6 = d20
            diceType = 4;
            DiceLogic();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //D12 Dice
            // 1 = d4, 2 = d6, 3 = d8, 4 = d10, 5 = d12, 6 = d20
            diceType = 5;
            DiceLogic();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //D20 Dice
            // 1 = d4, 2 = d6, 3 = d8, 4 = d10, 5 = d12, 6 = d20
            diceType = 6;
            DiceLogic();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //D8 Button
            // 1 = d4, 2 = d6, 3 = d8, 4 = d10, 5 = d12, 6 = d20
            diceType = 3;
            DiceLogic();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Roll Button
            diceRoll.Play();
            rolling = true;
            DiceLogic();
            
        }
        
        public void DiceLogic()
        {
            //Determines what will happen after the diceType iniger is changed
            if (diceType == 1) 
            { 
                diceNum = random.Next(1, 5);
                BackgroundImage = Properties.Resources.D4BG;
            }
            if (diceType == 2) 
            { 
                diceNum = random.Next(1, 7);
                BackgroundImage = Properties.Resources.D6BG;
            }
            if (diceType == 3) 
            {
                BackgroundImage = Properties.Resources.D8BG;
                diceNum = random.Next(1, 9); 
            }
            if (diceType == 4) {

                BackgroundImage = Properties.Resources.D10BG;
                diceNum = random.Next(1, 11);
            }
            if (diceType == 5) {

                BackgroundImage = Properties.Resources.D12BG;
                diceNum = random.Next(1, 13); 
            }
            if (diceType == 6) {

                BackgroundImage = Properties.Resources.D20BG;
                diceNum = random.Next(1, 21); 
            }

            // Rolling logic This will happen when rolled
            if (rolling == true)
            {
                DiceDisplay.Text = diceNum.ToString();
                rolling = false;
            }

            
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void DiceDisplay_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
