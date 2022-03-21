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
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if(personListBox.SelectedItem != null)
            {
                DialogAddPerson dialog = new DialogAddPerson();
                
                dialog.Text = "Edit Person";
                dialog.buttonText = "Edit";

                int personIndex = personListBox.SelectedIndex;
                string[] personCharacteristics = personListBox.Items[personIndex].ToString().Split(' ');
                dialog.name = personCharacteristics[0];
                dialog.surname = personCharacteristics[1];
                dialog.age = personCharacteristics[2];
                dialog.location = personCharacteristics[3];

                var result = dialog.ShowDialog();
                if(result == DialogResult.OK)
                {
                    personListBox.Items[personIndex] = dialog.person.ToStringInformation();
                }
            }
            else
            {
                MessageBox.Show("No person selected!");
            }
        }
    }
}
