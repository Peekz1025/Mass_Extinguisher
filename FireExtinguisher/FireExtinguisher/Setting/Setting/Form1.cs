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
        string small;
        string medium;
        string large;

        public Form1()
        {
            InitializeComponent();
        }

        private void smallButton_CheckedChanged(object sender, EventArgs e)
        {
            small = "small";
            Save(small);
        }

        private void mediumButton_CheckedChanged(object sender, EventArgs e)
        {
            medium = "medium";
            Save(medium);
        }

        private void fullBox_CheckedChanged(object sender, EventArgs e)
        {
            large = "large";
            Save(large);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Save(string name)
        {
            string file = "Screen Size.txt";

            using (StreamWriter output = new StreamWriter(file))
            {
                output.WriteLine(name);
             }
            
        }
    }
}
