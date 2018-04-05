using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Setting
{
    public partial class Form1 : Form
    {
        string green;
        string pink;
        string blue;
        string red;
        string purple;
        string gray;

        public Form1()
        {
            InitializeComponent();
        }

        private void smallButton_CheckedChanged(object sender, EventArgs e)
        {
            green = "green";
            Save(green);
        }

        private void mediumButton_CheckedChanged(object sender, EventArgs e)
        {
            pink = "pink";
            Save(pink);
        }

        //private void fullBox_CheckedChanged(object sender, EventArgs e)
        //{
        //}

        private void saveButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Save(string color)
        {
                string file = "Color.txt";

                using (StreamWriter output = new StreamWriter(file))
                {
                    output.WriteLine(color);
                }
            
        }

        private void blueButton_CheckedChanged(object sender, EventArgs e)
        {
            blue = "blue";
            Save(blue);
        }

        private void grayButton_CheckedChanged(object sender, EventArgs e)
        {
            gray = "gray";
            Save(gray);
        }

        private void redButton_CheckedChanged(object sender, EventArgs e)
        {
            red = "red";
            Save(red);
        }

        private void purpleButton_CheckedChanged(object sender, EventArgs e)
        {
            purple = "purple";
            Save(purple);
        }
    }
}
