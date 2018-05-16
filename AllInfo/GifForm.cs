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
    public partial class GifForm : Form
    {
        string name;
        string url;
        string nurl;
        public GifForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                using (vdoDataContext data = new vdoDataContext())
                {
                    gif giffiles = data.gifs.Single(gif => gif.Name == textBox1.Text);

                    name = giffiles.Name;

                    MessageBox.Show("gif is available");


                }
            }
            catch
            {
                MessageBox.Show("gif is notavailable");
                textBox1.Text = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                url = @"C:\Users\Tomal\Documents\Visual Studio 2013\Projects\Info\AllInfo\gif\" + textBox1.Text + ".gif";
                //ing nurl = string.Concat(url, name);
                pictureBox1.Image = Image.FromFile(url);
                //essageBox.Show(nurl);
            }
            catch
            {
                MessageBox.Show("First search a Gif");
            }
        }
    }
}
