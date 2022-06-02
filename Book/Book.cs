using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Book
    {
        readonly Title _title;
        readonly Author _author;
        readonly Content _content;

        public Book(Title title, Author author, Content content)
        {
            this._title = title;
            _author = author;
            _content = content;
        }

        public void Show()
        {
            _title.Show();
            _author.Show();
            _content.Show();
        }
    }
}
