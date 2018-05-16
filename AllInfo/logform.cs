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
    public partial class logform : Form
    {
        private string Password;
        private string name;
        private string path;
      
        public logform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (FacultyLinqDataContext data = new FacultyLinqDataContext())
                {
                    login lg = data.logins.Single(login => login.Name == textBox1.Text);
                    Password = lg.Password;
                    name = lg.Name;


                }
                if (Password == textBox2.Text)
                {
                    MessageBox.Show("login successfull ");
                    textBox1.Text = null;
                    textBox2.Text = null;
                }
                path = @"C:\Users\Tomal\Documents\Visual Studio 2013\Projects\Info\AllInfo\adminpropic\" + name+".jpg";
                AdminHomepage adminhome = new AdminHomepage(name,path);
                adminhome.Show();
                this.Hide();
                
            }
            catch
            {
                MessageBox.Show("Invalid username or password");
                textBox1.Text = null;
                textBox2.Text = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup signuppage = new Signup();
            signuppage.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (FacultyLinqDataContext data = new FacultyLinqDataContext())
                {
                    Faculty_Info lg = data.Faculty_Infos.Single(Faculty_Info => Faculty_Info.Name == textBox1.Text);
                    Password = lg.CreatePassword;
                    name = lg.Name;
                }
                if (Password == textBox2.Text)
                {
                    MessageBox.Show("login successfull ");
                    textBox1.Text = null;
                    textBox2.Text = null;
                }
                path = @"C:\Users\Tomal\Documents\Visual Studio 2013\Projects\Info\AllInfo\facultypropic\"+name+".jpg";
                FacultyHomepage fhome = new FacultyHomepage(name,path);
                fhome.Show();
                this.Hide();

            }
            catch
            {
                MessageBox.Show("Invalid username or password");
                textBox1.Text = null;
                textBox2.Text = null;
            }
            
        }

        private void logform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (StudentLinqDataContext data = new StudentLinqDataContext())
                {
                    studentinfo lg = data.studentinfos.Single(Student_Info => Student_Info.StudentName == textBox1.Text);
                    Password = lg.CreatePassword;
                    name=lg.StudentName;
                    path = @"C:\Users\Tomal\Documents\Visual Studio 2013\Projects\Info\AllInfo\studentpropic\" + name + ".jpg";

                }
                if (Password == textBox2.Text)
                {
                    MessageBox.Show("login successfull ");
                    textBox1.Text = null;
                    textBox2.Text = null;
                }
                StudentHomepage st = new StudentHomepage(name,path);
                st.Show();
                this.Hide();

            }
            catch
            {
                MessageBox.Show("Invalid username or password");
                textBox1.Text = null;
                textBox2.Text = null;
            }
            
        }

        private void logform_Load(object sender, EventArgs e)
        {

        }
    }
}
