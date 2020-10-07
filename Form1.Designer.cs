namespace BookStore
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnName = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblKeywords = new System.Windows.Forms.Label();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.btnDoAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSearchForBook = new System.Windows.Forms.Button();
            this.btnDoSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(357, 53);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(85, 35);
            this.btnName.TabIndex = 0;
            this.btnName.Text = "OK";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(173, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(136, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Enter Your Name:";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Enabled = false;
            this.btnAddBook.Location = new System.Drawing.Point(194, 105);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(121, 29);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Visible = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Book Search";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Enabled = false;
            this.lblAuthor.Location = new System.Drawing.Point(113, 169);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(57, 20);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author";
            this.lblAuthor.Visible = false;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(205, 166);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(142, 26);
            this.txtAuthor.TabIndex = 5;
            this.txtAuthor.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Enabled = false;
            this.lblTitle.Location = new System.Drawing.Point(113, 220);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 20);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title";
            this.lblTitle.Visible = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(205, 214);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(142, 26);
            this.txtTitle.TabIndex = 7;
            this.txtTitle.Visible = false;
            // 
            // lblKeywords
            // 
            this.lblKeywords.AutoSize = true;
            this.lblKeywords.Enabled = false;
            this.lblKeywords.Location = new System.Drawing.Point(113, 272);
            this.lblKeywords.Name = "lblKeywords";
            this.lblKeywords.Size = new System.Drawing.Size(77, 20);
            this.lblKeywords.TabIndex = 10;
            this.lblKeywords.Text = "Keywords";
            this.lblKeywords.Visible = false;
            // 
            // txtKeywords
            // 
            this.txtKeywords.Enabled = false;
            this.txtKeywords.Location = new System.Drawing.Point(205, 266);
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.Size = new System.Drawing.Size(142, 26);
            this.txtKeywords.TabIndex = 9;
            this.txtKeywords.Visible = false;
            // 
            // btnDoAdd
            // 
            this.btnDoAdd.Enabled = false;
            this.btnDoAdd.Location = new System.Drawing.Point(194, 328);
            this.btnDoAdd.Name = "btnDoAdd";
            this.btnDoAdd.Size = new System.Drawing.Size(121, 29);
            this.btnDoAdd.TabIndex = 11;
            this.btnDoAdd.Text = "Do Add";
            this.btnDoAdd.UseVisualStyleBackColor = true;
            this.btnDoAdd.Visible = false;
            this.btnDoAdd.Click += new System.EventHandler(this.btnDoAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Enabled = false;
            this.btnExit.Location = new System.Drawing.Point(333, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 29);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Enabled = false;
            this.lblKeyword.Location = new System.Drawing.Point(481, 169);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(69, 20);
            this.lblKeyword.TabIndex = 14;
            this.lblKeyword.Text = "Keyword";
            this.lblKeyword.Visible = false;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Enabled = false;
            this.txtKeyword.Location = new System.Drawing.Point(573, 163);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(142, 26);
            this.txtKeyword.TabIndex = 13;
            this.txtKeyword.Visible = false;
            // 
            // btnSearchForBook
            // 
            this.btnSearchForBook.Enabled = false;
            this.btnSearchForBook.Location = new System.Drawing.Point(556, 105);
            this.btnSearchForBook.Name = "btnSearchForBook";
            this.btnSearchForBook.Size = new System.Drawing.Size(185, 29);
            this.btnSearchForBook.TabIndex = 15;
            this.btnSearchForBook.Text = "Search for Book";
            this.btnSearchForBook.UseVisualStyleBackColor = true;
            this.btnSearchForBook.Visible = false;
            this.btnSearchForBook.Click += new System.EventHandler(this.btnSearchForBook_Click);
            // 
            // btnDoSearch
            // 
            this.btnDoSearch.Enabled = false;
            this.btnDoSearch.Location = new System.Drawing.Point(594, 328);
            this.btnDoSearch.Name = "btnDoSearch";
            this.btnDoSearch.Size = new System.Drawing.Size(121, 29);
            this.btnDoSearch.TabIndex = 16;
            this.btnDoSearch.Text = "Do Search";
            this.btnDoSearch.UseVisualStyleBackColor = true;
            this.btnDoSearch.Visible = false;
            this.btnDoSearch.Click += new System.EventHandler(this.btnDoSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoSearch);
            this.Controls.Add(this.btnSearchForBook);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDoAdd);
            this.Controls.Add(this.lblKeywords);
            this.Controls.Add(this.txtKeywords);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblKeywords;
        private System.Windows.Forms.TextBox txtKeywords;
        private System.Windows.Forms.Button btnDoAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearchForBook;
        private System.Windows.Forms.Button btnDoSearch;
    }
}

