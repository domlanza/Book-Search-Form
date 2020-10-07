using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    class Book
    {
        private string hiddenTitle;
        private string hiddenAuthor;
        private string hiddenKeywords;
        public string[] keywords;

        public Book() {

        }

        public Book(string author, string title, string keywords)
        {
            hiddenAuthor = author;
            hiddenTitle = title;
            hiddenKeywords = keywords;
        }

        public string getString()
        {
            return hiddenAuthor + "*" + hiddenTitle + "*" + hiddenKeywords;
        }

        public void displayBook()
        {
            MessageBox.Show(getString());
        }

        public Boolean isMatch(string word)
        {

            keywords = hiddenKeywords.Split(',');
            Boolean retval = false;
            for (int i = 0; i < keywords.Length - 1; i++)
            {
                //Trim spaces from the keywords in the book list  
                keywords[i] = keywords[i].Trim(' ');

                if (word == keywords[i])
                {
                    retval = true;
                }
            }
            
            return retval;
        }

    }
}

