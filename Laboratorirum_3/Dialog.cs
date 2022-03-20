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
    public partial class DialogAddPerson : Form
    {
        public Person person;

        public string buttonText 
        { 
            get => btn_Ok.Text;
            set => btn_Ok.Text = value; 
        }

        public DialogAddPerson()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                person = new Person(nameBox.Text, surnameBox.Text, double.Parse(ageBox.Text), locationBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("There are errors in entered information!");
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
