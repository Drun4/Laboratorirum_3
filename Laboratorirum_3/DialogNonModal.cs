using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laboratorirum_3
{
    public partial class DialogAddMore : Form
    {
        public event EventHandler<Person> PersonEntered;
        public Person person;

        public DialogAddMore()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(1200, 605);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try 
            { 
                person = new Person(nameBox.Text, surnameBox.Text, double.Parse(ageBox.Text), locationBox.Text);
                PersonEntered?.Invoke(this, person);
            }
            catch (FormatException)
            {
                MessageBox.Show("There are errors in entered information!");
                return;
            }
            //1 parametr - obiekt dla ktorego zdarzenia zaszlo, czyli nasze okno dialogowe
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            surnameBox.Text = "";
            ageBox.Text = "";
            locationBox.Text = "";
        }


        //Суть метода Invoke довольно проста - он принимает делегат
        //и выполняет его в том потоке, в котором был создан элемент
        //управления, у которого вызывается Invoke.
    }
}
