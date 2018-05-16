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
    public partial class uploadvideo : Form
    {
        private string temp1;
        public uploadvideo()
        {
            InitializeComponent();
        }

        private void uploadvideo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Copy(temp1, @"C:\Users\Tomal\Documents\Visual Studio 2013\Projects\Info\AllInfo\tutorial\" + textBox1.Text+".mp4");
            vdoDataContext d1 = new vdoDataContext();
            
            videotutorial v = new videotutorial();
            v.Name = textBox1.Text+".mp4";
            v.Type = textBox2.Text;
            d1.videotutorials.InsertOnSubmit(v);
            d1.SubmitChanges();
            MessageBox.Show("tutorial is added successfully. Thank you");
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Mp4 files|*.mp4";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox3.Text = openFileDialog1.FileName;
                temp1 = openFileDialog1.FileName;
                // bookName=openFileDialog1.SafeFileName;
                // MessageBox.Show(openFileDialog1.SafeFileName);

              
 
            }
        }

        private void uploadvideo_FormClosed(object sender, FormClosedEventArgs e)
        {
            //FacultyHomepage fac = new FacultyHomepage();
           // fac.Show();
            this.Hide();
        }
    }
}
