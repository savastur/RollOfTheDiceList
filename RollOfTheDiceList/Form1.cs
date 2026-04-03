using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollOfTheDiceList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Display(int[] numberSum)
        {
            string numberIndex = "";
            string sumIndex = "";
            string[] numberList = {"2", "3", "4", "5", "6", "8", "9", "10", "11", "12" };
            foreach(string number in numberList)
            {
                numberIndex += number.PadLeft(2) + " |";
            }
            RollDisplay.Items.Add(numberIndex);
            foreach(int sum  in numberSum)
            {
                sumIndex += sum.ToString().PadLeft(2) + " |";
            }
            RollDisplay.Items.Add(sumIndex);
        }

        private void RollDice_Click(object sender, EventArgs e)
        {
            int[] rolls = new int[11];
            //Random Number Generator
            Random sixSidedDie = new Random();
            for (int rollDice = 0; rollDice < 1000; rollDice++)
            {
                //Rolls two dice and adds together
                int sixSidedNumber = sixSidedDie.Next(1, 7) + sixSidedDie.Next(1, 7); //(min , max "not inclusive")
                //incremnts every time an number is rolled and removes the zero's displayed for 0 and 1
                rolls[sixSidedNumber - 2]++;
            }
            Display(rolls);
        }
        
    }
}
