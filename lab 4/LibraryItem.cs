using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    class LibraryItem
    {
        protected string title;
        protected string author;

        public LibraryItem(string t, string a)
        {
            title = t;
            author = a;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {title}, Author: {author}");
        }
    }

    class Book : LibraryItem
    {
        int pages;

        public Book(string t, string a, int p) : base(t, a)
        {
            pages = p;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Book → Title: {title}, Author: {author}, Pages: {pages}");
        }
    }

    class Magazine : LibraryItem
    {
        int issueNo;

        public Magazine(string t, string a, int i) : base(t, a)
        {
            issueNo = i;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Magazine → Title: {title}, Author: {author}, Issue No: {issueNo}");
        }
    }
}