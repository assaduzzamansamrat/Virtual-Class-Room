using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualLibrary;



namespace AllInfo                                                                                             
{
    public partial class FacultyHomepage : Form
    {
        private string name;
        private string path;
        public FacultyHomepage(string name,string path)
        {
            InitializeComponent();
            this.name = name;
            this.path = path;
            label2.Hide();
            button9.Hide();
            textBox1.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
               
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VL vl = new VL();
            vl.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (FacultyLinqDataContext Ssearch = new FacultyLinqDataContext())
                {
                    Faculty_Info sinfo = Ssearch.Faculty_Infos.Single(Faculty_Info => Faculty_Info.Name == name);



                    label3.Text = sinfo.Name;
                    label4.Text = sinfo.Email;
                    label12.Text = sinfo.Contact;
                    label6.Hide();
                    label8.Text = sinfo.Depatment;
                    MessageBox.Show("Data Found");
                    label3.Show();
                    label4.Show();
                    label5.Show();
                    label6.Show();
                    label7.Show();
                    label8.Show();
                    label9.Show();
                    label10.Show();
                    label11.Show();
                    label12.Show();
                    label13.Show();
                    textBox1.Text = null;


                }
            }
            catch
            {
                MessageBox.Show("Data Not Found ");
                textBox1.Text = null;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uploadvideo upv = new uploadvideo();
            upv.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            quesadd qa = new quesadd();
            qa.Show();
        
        }

        private void FacultyHomepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FacultyHomepage_FontChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UploadGIF gif = new UploadGIF();
            gif.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            logform l = new logform();
            l.Show();
        }

        private void FacultyHomepage_Load(object sender, EventArgs e)
        {
            //logform lg = new logform();
            label1.Text = "welcome "+name;
            pictureBox1.Image = Image.FromFile(path);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //FacultyLinqDataContext fa = new FacultyLinqDataContext();
            //label1.Text = Name;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Show();
            button9.Show();
            textBox1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                using (StudentLinqDataContext Ssearch = new StudentLinqDataContext())
                {
                    studentinfo sinfo = Ssearch.studentinfos.Single(Student_Info => Student_Info.StudentName == textBox1.Text);



                    label3.Text = sinfo.StudentName;
                    label4.Text = sinfo.Email;
                    label12.Text = sinfo.Mobile;
                    label6.Text = sinfo.AdmissionYear;
                    label8.Text = sinfo.Department;
                    MessageBox.Show("Data Found");
                    label3.Show();
                    label4.Show();
                    label5.Show();
                    label6.Show();
                    label7.Show();
                    label8.Show();
                    label9.Show();
                    label10.Show();
                    label11.Show();
                    label12.Show();
                    label13.Show();
                    textBox1.Text = null;


                }
            }
            catch
            {
                MessageBox.Show("Data Not Found ");
                textBox1.Text = null;
            }
        }
    }
}
