using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneCookieApp
{
    public partial class Form1 : Form
    {
        // Array of fortune phrases
        private string[] fortunes = new string[]
        {
            "Birthdays are like friends. The more you have the better.",
            "Your smile is a treasure to all who know you.",
            "You never hesitate to tackle the most difficult problems.",
            "The most obvious solution is not always the best.",
            "If you want the rainbow, you will have to tolerate the rain.",
            "The early bird gets the worm, but the second mouse gets the cheese.",
            "From listening comes wisdom and from speaking repentance.",
            "A smile is your personal welcome mat."
        };

        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            GenerateFortune();
        }

        // Method to randomly pick 2 different fortunes
        private void GenerateFortune()
        {
            int index1 = rand.Next(fortunes.Length);
            int index2;

            do
            {
                index2 = rand.Next(fortunes.Length);
            } while (index2 == index1);

            lblFortune1.Text = fortunes[index1];
            lblFortune2.Text = fortunes[index2];
        }
    }
}
