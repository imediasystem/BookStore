using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL
{
    internal class Book
    {
        string title;
        string authorname;
        string authorsurname;
        int pagesNumber;

        string GetLabel()
        {
            return title + " " + authorname + " " + authorsurname;
        }
    }
}
