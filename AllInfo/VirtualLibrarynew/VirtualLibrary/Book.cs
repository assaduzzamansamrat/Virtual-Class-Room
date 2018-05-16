using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VirtualLibrary
{
    
   
    public partial class Book : Form
    {
        string temp;

       
        public Book()
        {
            InitializeComponent();
        }

        private void Book_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Pdf Files|*.pdf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox5.Text = openFileDialog1.FileName;
                temp= openFileDialog1.FileName;
                // bookName=openFileDialog1.SafeFileName;
                MessageBox.Show(openFileDialog1.SafeFileName);

            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

                {
                    if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
                    {
                        MessageBox.Show("TextBoxes are Empty Please Check Again");
                    }
                    else
                    {
                    dbDataContext vdb = new dbDataContext();


                    Bookinfo vb = new Bookinfo();
                    dbDataContext vdv = new dbDataContext();
                        vb.Name = textBox1.Text;
                        vb.Author = textBox2.Text;
                        vb.Edition = textBox3.Text;
                        vb.Type = textBox4.Text;
                        vdb.Bookinfos.InsertOnSubmit(vb);
                        vdb.SubmitChanges();
                        File.Copy(temp, @"C:\Users\Assaduzzaman\Documents\Visual Studio 2015\Projects\VirtualLibrary\VirtualLibrary\PDFBOOK\" + textBox1.Text + ".pdf");
                        MessageBox.Show("Book is added successfully in the library. Thank you");
                        // this.Visible = false;
                        // this.Visible = true;
                        textBox1.Text = null;
                        textBox2.Text = null;
                        textBox3.Text = null;
                        textBox4.Text = null;

                    }
                   
                }
            
          
            
           
            }
    }
    }


