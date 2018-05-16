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
    public partial class Form1 : Form
    {
        string temp_a;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
          try
            {
              
                FacultyLinqDataContext db = new FacultyLinqDataContext();
                Faculty_Info fac = new Faculty_Info();
                fac.Name = textBox1.Text;
                fac.Email = textBox2.Text;
                fac.Contact = textBox3.Text;
                fac.Address = textBox4.Text;
                fac.Education = textBox5.Text;
                fac.Age = textBox6.Text;
                fac.Sex = textBox7.Text;
                fac.Religion = textBox8.Text;
                fac.PreferredCourse = textBox9.Text;
                fac.DayOff ="Friday";
                fac.Depatment = textBox13.Text;
                fac.CreatePassword = textBox12.Text;
                db.Faculty_Infos.InsertOnSubmit(fac);
                db.SubmitChanges();
                File.Copy(temp_a, @"C:\Users\Tomal\Documents\Visual Studio 2013\Projects\Info\AllInfo\facultypropic\" + textBox1.Text + ".jpg");
                
                MessageBox.Show("Data Inserted");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JPG files|*.jpg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox11.Text = openFileDialog1.FileName;
                temp_a = openFileDialog1.FileName;
               // textBox11.Text = temp1;
                // bookName=openFileDialog1.SafeFileName;
                // MessageBox.Show(openFileDialog1.SafeFileName);


          
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        }
    }

