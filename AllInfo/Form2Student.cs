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
    // StudentLinqDataContext db = new StudentLinqDataContext();
    public partial class Form2Student : Form
    {
        private string temp1;
        public Form2Student()
        {
            InitializeComponent();
        }
        

        
        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
              
                StudentLinqDataContext dbc = new StudentLinqDataContext();
                studentinfo st = new studentinfo();
                st.StudentName = textBox1.Text;
                st.FatherName = textBox2.Text;
                st.Email = textBox3.Text;
                st.Mobile = textBox4.Text;
                st.Age = textBox5.Text;
                st.Sex = textBox6.Text;
                st.Religion = textBox7.Text;
                st.AdmissionYear = textBox8.Text;
                st.CreatePassword = textBox10.Text;
                st.Department = textBox11.Text;
                dbc.studentinfos.InsertOnSubmit(st);
                dbc.SubmitChanges();
                File.Copy(temp1, @"C:\Users\Tomal\Documents\Visual Studio 2013\Projects\Info\AllInfo\studentpropic\" + textBox1.Text + ".jpg");

                MessageBox.Show("Data Inserted");
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;
                textBox6.Text = null;
                textBox7.Text = null;
                textBox8.Text = null;
                textBox9.Text = null;
                textBox10.Text = null;
              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }



        }

        private void Form2Student_Load(object sender, EventArgs e)
        {

        }

 
        private void button3_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Jpg files|*.jpg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox9.Text = openFileDialog1.FileName;
                temp1 = openFileDialog1.FileName;
                // textBox11.Text = temp1;
                // bookName=openFileDialog1.SafeFileName;
                // MessageBox.Show(openFileDialog1.SafeFileName);




            }
        }

        private void Form2Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
