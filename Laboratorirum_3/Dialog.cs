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
        private string name1;

        public string name { get => nameBox.Text; set => nameBox.Text = value; }
        public string surname { get => surnameBox.Text; set => surnameBox.Text = value; }
        public string age { get => ageBox.Text; set => ageBox.Text = value; }
        public string location { get => locationBox.Text; set => locationBox.Text = value; }

        public string buttonText
        {
            get => btn_Ok.Text;
            set => btn_Ok.Text = value;
        }

        public DialogAddPerson()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(1200, 80);
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

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            surnameBox.Text = "";
            ageBox.Text = "";
            locationBox.Text = "";
        }
    }
}
