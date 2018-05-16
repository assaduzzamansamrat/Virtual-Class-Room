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
    public partial class courses : Form
    {
        string studentname;
        public courses(String studentname)
        {
            InitializeComponent();
            this.studentname = studentname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                StudentLinqDataContext db = new StudentLinqDataContext();
                
                Co fac = new Co();
                fac.CourseAdded=comboBox1.Text;
                fac.StudentName = studentname;

               db.Cos.InsertOnSubmit(fac);
               db.SubmitChanges(); 
                
                MessageBox.Show("Course Added");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Not Inserted");
            }
        }

        private void courses_Load(object sender, EventArgs e)
        {
            StudentLinqDataContext dc = new StudentLinqDataContext();
            comboBox1.DisplayMember = "CourseName";
            comboBox1.DataSource = dc.Courses.ToList<Course>();
        }
        }
    }

