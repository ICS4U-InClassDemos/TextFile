using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace TextFile
{
    public partial class Form1 : Form
    {
        List<string> colours;  

        public Form1()
        {
            InitializeComponent();
        }

        private void loadColoursButton_Click(object sender, EventArgs e)
        {
            colours = File.ReadAllLines("colourFile.txt").ToList();            
            DisplayResults();
        }

        private void saveColoursButton_Click(object sender, EventArgs e)
        {
            File.WriteAllLines("colourFile.txt", colours);
            Application.Exit();
        }

        private void sortColoursButton_Click(object sender, EventArgs e)
        {
            colours.Sort();
            DisplayResults();
        }

        private void addColourButton_Click(object sender, EventArgs e)
        {
            colours.Add(colourInput.Text);

            colourInput.Text = "";
            DisplayResults();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string valueToRemove = removeInput.Text;

            if (colours.Contains(valueToRemove))
            {
                colours.Remove(valueToRemove);
                MessageBox.Show(valueToRemove + " has been removed from list");

            }
            else
            {
                MessageBox.Show(valueToRemove + " is not in the list");
            }

            removeInput.Text = "";
            DisplayResults();
        }

        public void DisplayResults()
        {
            outputLabel.Text = "";

            foreach(string colour in colours)
            {
                outputLabel.Text += colour + "\n";
            }
        }
    }
}
