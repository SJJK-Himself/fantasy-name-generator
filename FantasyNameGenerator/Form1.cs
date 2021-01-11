using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantasyNameGenerator
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Variables chk1 and chk2 save the status of the checkboxes
        /// </summary>
        public bool chk1 = true;
        public bool chk2 = true;


        public Form1()
        {
            InitializeComponent();
        }


        public void Form1_Load(object sender, EventArgs e)
        {
            FNGController.InitPath();
            usedNamesList.DataSource = FNGController.ReadNameFile();
        }


        public void checkBoxFirstN_CheckedChanged(object sender, EventArgs e)
        {
            chk1 = checkBoxFirstN.Checked;
        }


        public void checkBoxLastN_CheckedChanged(object sender, EventArgs e)
        {
            chk2 = checkBoxLastN.Checked;
        }


        public void buttonRandomize_Click(object sender, EventArgs e)
        {
            if (chk1 == true & chk2 == false)
            {
                textBoxFirstN.Text = FNGController.FirstNameGenerator();
                textBoxLastN.Text = "";
            }

            if (chk1 == false & chk2 == true)
            {
                textBoxFirstN.Text = "";
                textBoxLastN.Text = FNGController.LastNameGenerator();
            }

            if (chk1 == true & chk2 == true)
            {
                textBoxFirstN.Text = FNGController.FirstNameGenerator();
                textBoxLastN.Text = FNGController.LastNameGenerator();
            }

            if (chk1 == false && chk2 == false)
            {
                textBoxFirstN.Text = "";
                textBoxLastN.Text = "";
            }
        }


        private void textBoxFirstN_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBoxLastN_TextChanged(object sender, EventArgs e)
        {

        }


        private void usedNamesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void buttonAccept_Click(object sender, EventArgs e)
        {
            FNGController.SaveFinalName(textBoxFirstN.Text, textBoxLastN.Text);
            usedNamesList.DataSource = FNGController.ReadNameFile();
        }

        //TODO
        private void buttonDeleteN_Click(object sender, EventArgs e)
        {
            FNGController.DeleteName();
            usedNamesList.DataSource = FNGController.ReadNameFile();
        }
    }
}
