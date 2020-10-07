using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    class BookList
    {
        //Global attributes
        public int success = 0;
        public int failures = 0;

        List<Book> internalBookList = new List<Book>();

        public BookList()
        {

        }

        // Add book to the list the list
        public void addNewBook(Book newBook) {
            internalBookList.Add(newBook);
        }

        public Boolean searchList(string keyword)
        {
            


            Boolean retval = false;
            foreach (Book x in internalBookList)
            {

                Boolean nono = x.isMatch(keyword);
                
                if (nono == true)
                {
                    success++;
                    x.displayBook();
                    retval = true;
                }  
                
            }

            if (retval == true)
            {
                success++;
            }

            if (retval == false)
            {
                failures++;
                MessageBox.Show("Nope: " + failures);

            }


            return retval;
        }

        public void displayList()
        {
            string contents = " ";
            foreach (Book x in internalBookList)
            {
                contents += x.getString() + "\n";
            }

            MessageBox.Show(contents);
        }

        public int count()
        {

            int bookcount = internalBookList.Count();
            return bookcount;
        }

    }
}
