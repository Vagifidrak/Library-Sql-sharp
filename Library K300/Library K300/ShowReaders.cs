using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_K300.Model;

namespace Library_K300
{
    public partial class ShowReaders : Form
    {
        public ShowReaders()
        {
            InitializeComponent();
        }

        public object LibDB { get; private set; }

        private void ShowReaders_Load(object sender, EventArgs e)
        {
            //using (SqlConnection Cont = new SqlConnection(Properties.Settings.Default.LibraryCon))
            //{
            //    string comstring = "Select bk.BookName, bk.CreateDate, ath.AuthorName" +
            //        " from Books bk"+
            //        " join Authors ath"+
            //        " on ath.Id=bk.AuthorId";
            //    SqlDataAdapter da = new SqlDataAdapter(comstring, Cont);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds, "Books");
            //    dtgReaders.DataSource = ds.Tables["Books"];
            //}

            LibraryEntities db = new LibraryEntities();
            dtgReaders.DataSource = db.Book_To_Reader.Select(btr=>new 
        {btr.Book.BookName,btr.Reader.Firstname,btr.TakeDate,btr.ReturnDate
            }).ToList();
           
        }
    }
}
