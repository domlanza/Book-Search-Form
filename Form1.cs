using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new Global();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
            System.Windows.Forms.MessageBox.Show("Name Cannot Be Blank. Reenter");
            }

            else
            {

                btnAddBook.Enabled = true;
                btnSearchForBook.Enabled = true;
                btnExit.Enabled = true;


               

                btnAddBook.Visible = true;
                btnSearchForBook.Visible = true;

               
            
                lblKeyword.Visible = true;
                btnExit.Visible = true;


            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string answer = Convert.ToString(Global.BookList.count());
            MessageBox.Show("Number of books:" + answer + "\n" +
                "Success count:" + Global.BookList.success + "\n" +
                "Failure count:" + Global.BookList.failures
                
                );


            this.Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            txtAuthor.Enabled = true;
            txtTitle.Enabled = true;
            txtKeywords.Enabled = true;
            btnDoAdd.Enabled = true;
            lblAuthor.Enabled = true;
            lblTitle.Enabled = true;
            lblKeywords.Enabled = true;
            txtAuthor.Visible = true;
            txtTitle.Visible = true;
            txtKeywords.Visible = true;
            btnAddBook.Visible = true;
            btnDoAdd.Visible = true;
            btnDoSearch.Visible = true;
            lblAuthor.Visible = true;
            lblTitle.Visible = true;
            lblKeywords.Visible = true;

           
        }

        private void btnDoAdd_Click(object sender, EventArgs e)
        {

            //Check that all information is filled
            string author = txtAuthor.Text;
            string title = txtTitle.Text;
            string keywords = txtKeywords.Text;

            if (author.Length < 0 && title.Length < 0 && keywords.Length < 0)
            {

                MessageBox.Show("Please enter all required information to our system.", "Error");
                txtAuthor.Text = "";
                txtTitle.Text = "";
                txtKeywords.Text = "";
                
            }

            else
            {
                Book bookie = new Book(author, title, keywords);
                Global.BookList.addNewBook(bookie);
                Global.BookList.displayList();

                txtAuthor.Text = "";
                txtTitle.Text = "";
                txtKeywords.Text = "";

            }



        }

        private void btnSearchForBook_Click(object sender, EventArgs e)
        {
            txtKeyword.Visible = true;
            txtKeyword.Enabled = true;
            btnDoSearch.Enabled = true;
            lblKeyword.Enabled = true;

        }

        private void btnDoSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text;
            Global.BookList.searchList(keyword);

        }
    }
}

