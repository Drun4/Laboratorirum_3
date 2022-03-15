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
        static public int num_of_persons = 0;
        static Person[] persons = new Person[num_of_persons];
        static Person[] AuxPersons = new Person[num_of_persons];

        public Form1()
        {
            InitializeComponent();
        }

        private void addPersonB_Click(object sender, EventArgs e)
        {
            Dialog dialog = new Dialog();
            var result = dialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                num_of_persons++;

                AuxPersons = new Person[num_of_persons];
                for (int i = 0; i < persons.Length; i++)
                {
                    AuxPersons[i] = persons[i];
                }

                AuxPersons[num_of_persons - 1] = new Person(dialog.Name, dialog.Surname, dialog.Age, dialog.Location); 
                personsInfoBox.Text += AuxPersons[num_of_persons - 1].ToStringInformation() + "\n";

                persons = new Person[num_of_persons];
                for(int i = 0; i < AuxPersons.Length; i++)
                {
                    persons[i] = AuxPersons[i];
                }
            }
            else if(result == DialogResult.Cancel)
            {
                personsInfoBox.Text += "";
            }
            for(int i = 0; i < persons.Length; i++)
            {
                personsInfoBox.Text += persons[i].ToStringInformation() + "\n";
            }
        }
    }
}
