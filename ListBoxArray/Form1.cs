using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAdd.Text != "")
                lstNames.Items.Add(txtAdd.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtRemove.Text != "" && lstNames.Items.Contains(txtRemove.Text))
                lstNames.Items.Remove(txtRemove.Text);
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            lstNames.Items.RemoveAt(int.Parse(txtRemoveAt.Text));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (lstNames.Items.Contains(txtSearch.Text))
                MessageBox.Show("Found");
            else
                MessageBox.Show("Not Found");
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            string[] names = new string[10] {"Jack", "Rick", "Tom", "Tim", "George", "Rudy", "Selena", "Ariana", "Athena", "James"};
            Random rnd = new Random();
            string randomName = names[rnd.Next(10)];
            lstNames.Items.Add(randomName);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstNames.Items.Clear();
        }
    }
}
