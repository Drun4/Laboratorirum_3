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
    public partial class Dialog : Form
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Age { get; set; }
        public string Location { get; set; }

        public Dialog()
        {
            InitializeComponent();
        }

        private void OkB_Click(object sender, EventArgs e)
        {
            Name = nameBox.Text;
            Surname = surnameBox.Text;
            Age = double.Parse(ageBox.Text);
            Location = locationBox.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
