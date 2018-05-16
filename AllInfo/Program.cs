using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualLibrary;

namespace AllInfo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
           //Application.Run(new Form2Student());
           //Application.Run(new FacultyHomepage());
          // Application.Run(new AdminHomepage());   
              //Application.Run(new Exam());
            Application.Run(new logform());
           //pplication.Run(new UploadGIF());
            //Application.Run(new uploadvideo());
            //Application.Run(new Book());
            //plication.Run(new GifForm());
            //Application.Run(new StudentSearch());
            //Application.Run(new AdminAddCourse());

            //Application.Run(new StudentHomepage());
          //  Application.Run(new quesadd());
            //Application.Run(new StudentHomepage());
          //  Application.Run(new courses());
        }
    }
}
