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
    public partial class AdminHomepage : Form
    {
        string name;
        string propic;
        public AdminHomepage(String Name,String propic)
        {
            InitializeComponent();
            this.name = Name;
            this.propic = propic;
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (FacultyLinqDataContext fsearch=new FacultyLinqDataContext())
                {
                    Faculty_Info finfo = fsearch.Faculty_Infos.Single(Faculty_Info => Faculty_Info.Name == textBox1.Text);


                    
                    textBox1.Text =finfo.Name;
                    textBox2.Text = finfo.Email;
                    textBox3.Text = finfo.Contact;
                    textBox4.Text = finfo.Address;
                    textBox5.Text = finfo.Depatment;
                    label6.Text = finfo.Id.ToString();
                    MessageBox.Show("Data Found");
                }
            }
            catch
            {
                MessageBox.Show("Data Not Found");
                textBox1.Text = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (StudentLinqDataContext Ssearch= new StudentLinqDataContext())
                {
                    studentinfo sinfo = Ssearch.studentinfos.Single(Student_Info => Student_Info.StudentName == textBox1.Text);



                    textBox1.Text = sinfo.StudentName;
                    textBox2.Text = sinfo.Email;
                    textBox3.Text = sinfo.Mobile;
                    textBox4.Text = sinfo.AdmissionYear;
                    textBox5.Text = sinfo.Department;
                    MessageBox.Show("Data Found");  
                 


                }
            }
            catch
            {
                MessageBox.Show("Data Not Found ");
                textBox1.Text = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (FacultyLinqDataContext fup = new FacultyLinqDataContext())
                {
                    
                    FacultyLinqDataContext fupdate = new FacultyLinqDataContext();
                    int id = int.Parse(label6.Text);
                    Faculty_Info fobj = fupdate.Faculty_Infos.SingleOrDefault(Faculty_Info => Faculty_Info.Id == id);
                    MessageBox.Show(textBox1.Text);
                    fobj.Name = textBox1.Text;
                    fobj.Email = textBox2.Text;
                    fobj.Contact = textBox3.Text;
                    fobj.Address = textBox4.Text;
                    fobj.Depatment = textBox5.Text;

                    fupdate.SubmitChanges();
                   
                     MessageBox.Show("Data Updated");
                }
            }
            catch (Exception ex)
            {
                //FacultyLinqDataContext fupdate = new FacultyLinqDataContext();
                
                //fupdate.SubmitChanges();
                MessageBox.Show(ex.Message);
                ///  textBox1.Text = null;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (StudentLinqDataContext supdate=new StudentLinqDataContext())
                {

                    StudentLinqDataContext sup = new StudentLinqDataContext();
                    int id = int.Parse(label6.Text);

                    studentinfo sobj = supdate.studentinfos.Single(Student_Info => Student_Info.id ==id);
                    
                    sobj.StudentName = textBox1.Text;
                    sobj.Email = textBox2.Text;
                    sobj.Mobile = textBox3.Text;
                    sobj.AdmissionYear = textBox4.Text;
                    sobj.Department = textBox5.Text;

                    supdate.SubmitChanges();

                    MessageBox.Show("Data Updated");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                ///  textBox1.Text = null;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FacultyLinqDataContext fdelete = new FacultyLinqDataContext();

            Faculty_Info finfo = fdelete.Faculty_Infos.Single(Faculty_Info => Faculty_Info.Name == textBox1.Text);

            fdelete.Faculty_Infos.DeleteOnSubmit(finfo);
            
            fdelete.SubmitChanges();
            MessageBox.Show("Data ddeleted");
        }

        private void AdminHomepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StudentSearch dp = new StudentSearch();
            dp.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                StudentLinqDataContext sdelete = new StudentLinqDataContext();

                studentinfo sinfo = sdelete.studentinfos.Single(Student_Info => Student_Info.StudentName == textBox1.Text);

                sdelete.studentinfos.DeleteOnSubmit(sinfo);

                sdelete.SubmitChanges();
                MessageBox.Show("Data ddeleted");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminHomepage_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(propic);
            label7.Text = "Welcome " + name;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AdminAddCourse add = new AdminAddCourse();
            add.Show();
        }
    }
}
