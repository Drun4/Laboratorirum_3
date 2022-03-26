using System;
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
                personListBox.Items.Add(dialog.person);
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
            personListBox.Items.Add(e);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if(personListBox.SelectedItem != null)
            {
                DialogAddPerson dialog = new DialogAddPerson();
                
                dialog.Text = "Edit Person";
                dialog.buttonText = "Edit";

                int personIndex = personListBox.SelectedIndex;

                /* Version 1
                string[] personCharacteristics = personListBox.Items[personIndex].ToString().Split(' ');
                dialog.name = personCharacteristics[0];
                dialog.surname = personCharacteristics[1];
                dialog.age = personCharacteristics[2];
                dialog.location = personCharacteristics[3];
                */

                /* Version 2
                Person person1 = (Person)personListBox.Items[personIndex];
                dialog.name = person1.name;
                dialog.surname = person1.surname;
                dialog.age = person1.age.ToString();
                dialog.location = person1.location;
                */

                // Final version
                dialog.person = (Person) personListBox.Items[personIndex];
                dialog.personInter = dialog.person;

                var result = dialog.ShowDialog();
                if(result == DialogResult.OK)
                {
                    personListBox.Items[personIndex] = dialog.person;
                }
            }
            else
            {
                MessageBox.Show("No person selected!");
            }
        }
    }
}
