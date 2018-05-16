using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AllInfo
{
    public partial class UploadGIF : Form
    {
        private string temp1;
        public UploadGIF()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Gif Files|*.gif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox3.Text = openFileDialog1.FileName;
                temp1 = openFileDialog1.FileName;
                // bookName=openFileDialog1.SafeFileName;
                // MessageBox.Show(openFileDialog1.SafeFileName);

               // File.Copy(temp1, @"C:\Users\Tomal\Documents\Visual Studio 2013\Projects\Info\AllInfo\gif\" + textBox1.Text + ".gif");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Copy(temp1, @"C:\Users\Tomal\Documents\Visual Studio 2013\Projects\Info\AllInfo\gif\" + textBox1.Text + ".gif");
            
            vdoDataContext d1 = new vdoDataContext();
            gif gf = new gif();
            gf.Name = textBox1.Text;
            gf.Type = textBox2.Text;
            d1.gifs.InsertOnSubmit(gf);
            d1.SubmitChanges();
            MessageBox.Show("gif is added successfully. Thank you");
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }

        private void UploadGIF_FormClosed(object sender, FormClosedEventArgs e)
        {
           // FacultyHomepage fac = new FacultyHomepage();
           // fac.Show();
            this.Hide();
        }
    }
}
