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
    public partial class AdminAddCourse : Form
    {
        public AdminAddCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                StudentLinqDataContext db = new StudentLinqDataContext();
                Course fac = new Course();
                fac.CourseName = textBox1.Text;
                fac.Seat = textBox2.Text;
                db.Courses.InsertOnSubmit(fac);
                db.SubmitChanges();
                
                MessageBox.Show("Data Inserted");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Not Inserted");
            }
        }
    }
}
