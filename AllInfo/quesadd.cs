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
    public partial class quesadd : Form
    {
        int ans;
        public quesadd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentLinqDataContext quest = new StudentLinqDataContext();
            exam exm = new exam();
            exm.ques = textBox1.Text;
            exm.ans = ans;
            exm.marks = 1;
            quest.exams.InsertOnSubmit(exm);
            quest.SubmitChanges();
            MessageBox.Show("Question added successfully");
            textBox1.Text = null;
           

        }

        private void quesadd_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ans = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ans = 0;
        }

        private void quesadd_FontChanged(object sender, EventArgs e)
        {
           
        }

        private void quesadd_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
//FacultyHomepage fh = new FacultyHomepage();
        //    fh.Show();
        }                  
    }
}
