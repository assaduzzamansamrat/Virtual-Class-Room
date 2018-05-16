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
    public partial class Video : Form
    {
        private string name;
        private string url;
        public Video()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            url = @"C:\Users\Tomal\Documents\Visual Studio 2013\Projects\Info\AllInfo\tutorial\";
            string  nurl=string.Concat(url,name);
  
            axWindowsMediaPlayer1.URL = (nurl);
            axWindowsMediaPlayer1.Ctlcontrols.play();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using(vdoDataContext data = new vdoDataContext())
                {
                   videotutorial vdt = data.videotutorials.Single(videotutorial => videotutorial.Name == textBox1.Text+".mp4");
                    name = vdt.Name;

                    MessageBox.Show("Tutorial is available");
                   

                }
            }
            catch
            {
                MessageBox.Show("Tutorial is not available ");
                textBox1.Text = null;
            }
        }

        private void Video_Load(object sender, EventArgs e)
        {

        }
    }
}
