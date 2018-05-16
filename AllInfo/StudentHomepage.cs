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
    public partial class StudentHomepage : Form
    {
        private string name;
        private string path;
        public StudentHomepage(string name,string path)
        {
            InitializeComponent();
            this.name = name;
            this.path = path;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GifForm gf = new GifForm();
            gf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VL v = new VL();
            v.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Video vd = new Video();
            vd.Show();
        }

        private void StudentHomepage_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome "+name;
            pictureBox1.Image = Image.FromFile(path);
            
        }

        private void StudentHomepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Exam cs = new Exam();
            cs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            logform cs = new logform();
            cs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            courses c = new courses(name);
            c.Show();
        }
    }
}
