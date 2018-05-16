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
    public partial class Exam : Form
    {
        int totalmark=0;
        int achivedmark = 0;
        int val;
        int answer;
        public Exam()
        {
            InitializeComponent();
            button1.Hide();
            groupBox1.Hide();
        }

        private void getradiobuttonvalue(RadioButton rad)
        {
               if(rad.Checked){
               string a = "true";

                if(a.Equals(rad.Text)){
                   answer = 1;
                
               }
               else{
                   answer = 0;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            //Random rnd = new Random();
            //int val = rnd.Next(1, 10);
            val++;
           // MessageBox.Show(val.ToString());
            try
            {
                totalmark = totalmark + 1;
                    {
                    using (StudentLinqDataContext ques = new StudentLinqDataContext())
                    {
                        exam xm = ques.exams.Single(quiz => quiz.id == val);
                        label1.Text = (xm.ques);
                        if (xm.ans == answer)
                        {
                            achivedmark = achivedmark + 1;
                        }
                        else
                        {
                            achivedmark = achivedmark + 0;
                        }
                    //  MessageBox.Show(val.ToString());
                      //label1.Show();
                    //  MessageBox.Show("ques "+xm.question);

                    }

                 }
            }
            catch
            {
                MessageBox.Show("Exam is over your mark is"+achivedmark.ToString()+"out of"+totalmark.ToString());
                this.Dispose();
                //this.Show();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Show();

           
            Random rnd = new Random();
            //val = rnd.Next(1, 10);
            val = rnd.Next(1003, 1013);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            getradiobuttonvalue(radioButton1);
         
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            getradiobuttonvalue(radioButton2);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Exam_Load(object sender, EventArgs e)
        {

        }
      
    }
}
