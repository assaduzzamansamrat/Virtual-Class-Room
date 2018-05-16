using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualLibrary
{
   partial class VirtualBook
    {
        private string bookLoaction;
        private string bookName;
        private string author;
        private string edition;
        private string booktype;

        public string bLocation{
            set { this.bookLoaction = value; }
            get { return this.bookLoaction; }
        }
        public string bName
        {
            set { this.bookName = value; }
            get { return this.bookName; }
        }
        public string bAuthor
        {
            set { this.author = value; }
            get { return this.author; }
        }
        public string bEdition
        {
            set { this.edition = value; }
            get { return this.edition; }
        }

        public string bType
        {
            set { this.booktype = value; }
            get { return this.booktype; }
        }
    }
}
