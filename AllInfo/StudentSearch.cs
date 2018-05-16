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
    public partial class StudentSearch : Form
    {
        public StudentSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {





        }

        private void StudentSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void StudentSearch_Load(object sender, EventArgs e)
        {
            {

                using (StudentLinqDataContext Ssearch = new StudentLinqDataContext())
                {
                    // Student_Info sinfo = Ssearch.Student_Infos.Single(Student_Info => Student_Info.Id.ToString() == textBox1.Text);


                    /// DCDataContext db = new DCDataContext();
                    // dataGridView1.DataSource = Ssearch.Student_Infos.Select(Student_Info => Student_Info.StudentName  <= DateTime.);

                    // textBox1.Text = sinfo.Student;
                    // dataGridView1.DataSource = sinfo;
                    // dataGridView1.DataBindings()
                    dataGridView1.DataSource = Ssearch.studentinfos;

                }
            }


        }
    }
}
