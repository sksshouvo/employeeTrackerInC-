using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;
namespace employee_tracker
{
    public partial class settings_form : Form
    {
        public settings_form()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            var form2 = new Form2();

            form1.Close();
            form2.Show();
        }
    }
}
