using Library_K300.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_K300
{
    public partial class BooksForm : Form
    {
        LibraryEntities db = new LibraryEntities();
        Book selectedBook;

        public BooksForm()
        {
            InitializeComponent();
        }
        public void EditBtn(string text)
        {
            if (Text == "add")
            {
                btAddBooks.Visible = true;
                btEdit.Visible = false;
                btDelete.Visible = false;
            }
            else
            {
                btAddBooks.Visible = false;
                btEdit.Visible = true;
                btDelete.Visible = true;
            }
       
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            BookLoad();
            cmbAuthors.Items.AddRange(db.Authors.Select(ath => ath.AuthorName).ToArray());
        }
        public void BookLoad()
        {
            dtGridView.DataSource = db.Books.Select(bk => new {
                bk.Id,
                bk.BookName,
                bk.Counts,
                bk.Author.AuthorName,
                bk.CreateDate
            }).ToList();

            dtGridView.Columns[0].Visible = false;
            
        }

        private void btAddBooks_Click(object sender, EventArgs e)
        {
            string bkName = txtBookName.Text;
            string count = txtCounts.Text;
            string authorname = cmbAuthors.Text;
            DateTime publDate = dtPicker.Value;
            if(bkName!=string.Empty && count!=string.Empty && authorname !=string.Empty && 
                publDate<=DateTime.Now) 
            {
                int autId = db.Authors.First(ath => ath.AuthorName == authorname).Id;
                int countNum = Convert.ToInt32(count);
                Book bk = new Book();
                bk.BookName = bkName;
                bk.Counts = countNum;
                bk.AuthorId = autId;
                bk.CreateDate = publDate;
                db.Books.Add(bk);
                db.SaveChanges();
                MessageBox.Show("Book Create succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BookLoad();
            }
            else
            {
                lblError.Text = "Pleace all the Fill";
                lblError.Visible = true;
            }
        }

        private void txtCounts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 47 || e.KeyChar > 58) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dtGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditBtn("a");
            int bookId = (int)dtGridView.Rows[e.RowIndex].Cells[0].Value;

            selectedBook = db.Books.First(bk => bk.Id == bookId);
            txtBookName.Text = selectedBook.BookName;
            txtCounts.Text = selectedBook.Counts.ToString();
            cmbAuthors.Text = selectedBook.Author.AuthorName;
            
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string bkname = txtBookName.Text;
            int count = Convert.ToInt32(txtCounts.Text);
            string autname = cmbAuthors.Text;
            DateTime pbDate=dtPicker.Value;
            selectedBook.BookName = bkname;
            selectedBook.Counts = count;
            selectedBook.CreateDate = pbDate;
            db.SaveChanges();
            MessageBox.Show("Book succesfully Edit", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EditBtn("m");
            BookLoad();
        }
    } 
}
