using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorirum_3
{
    public partial class Form1 : Form
    {
        List<string> persons = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_addPerson_Click(object sender, EventArgs e)
        {
            DialogAddPerson dialog = new DialogAddPerson();
            dialog.Text = "Add Person";
            dialog.buttonText = "Add";

            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                personListBox.Items.Add(dialog.person.ToStringInformation());
                persons.Add(dialog.person.ToStringInformation());
            }
            else if (result == DialogResult.Cancel)
            {
                personsInfoBox.Text += "";
            }
        }

        private void btn_addMore_Click(object sender, EventArgs e)
        {
            DialogAddMore dialog = new DialogAddMore();
            dialog.PersonEntered += Dialog_PersonEntered;
            dialog.Show();
        }

        private void Dialog_PersonEntered(object sender, Person e)
        {
            personListBox.Items.Add(e.ToStringInformation());
            persons.Add(e.ToStringInformation());
        }

        private void btn_showList_CLick(object sender, EventArgs e)
        {
            foreach(var p in persons)
            {
                personsInfoBox.Text += p + "\n";
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            DialogAddPerson dialog = new DialogAddPerson();
            dialog.Text = "Edit Person";
            dialog.buttonText = "Edit";

            var result = dialog.ShowDialog();
        }
    }
}
