using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllInfo
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fachome = new Form1();
            fachome.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2Student formstudent = new Form2Student();
            formstudent.Show();
           

        }

        private void Signup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
