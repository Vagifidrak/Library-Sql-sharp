using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Library_K300.Model;

namespace Library_K300
{
    public partial class LibraryForm : Form
    {
        LibraryEntities db = new LibraryEntities();

        public LibraryForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection Cont = new SqlConnection(Properties.Settings.Default.LibraryCon))
            {
                string comQuery = "Select FacultyName from Faculties";
                SqlCommand com = new SqlCommand(comQuery, Cont);
                Cont.Open();
                var rd = com.ExecuteReader();
                while (rd.Read())
                {
                    //MessageBox.Show(rd.GetValue(0).ToString());
                    cmbFaculity.Items.Add(rd.GetValue(0).ToString());
                }
            }
            cmbFaculity.Items.Add("Iqtisadiyyat");
            cmbFaculity.Items.Add("Tarix");
            cmbFaculity.Items.Add("Komp.ELmleri");
            cmbFaculity.Items.Add("Tebiet ELmleri");
            cmbFaculity.Items.Add("Psixologiya");
        }

        private void BtnReader_Click(object sender, EventArgs e)
        {
            string firstName = txtFrstName.Text;
            string lastName = txtLastName.Text;
            string phone = txtPhone.Text;
            string faculity = cmbFaculity.Text;
            long newPhone;
            if(firstName!="" && lastName!="" && phone!="" && faculity != "")
            {
                if(long.TryParse(phone,out newPhone))
                {
                    Reader rd = new Reader();
                    rd.Firstname = firstName;
                    rd.Lastname = lastName;
                    rd.Phone = phone;
                    db.Readers.Add(rd);
                    db.SaveChanges();

                    using (SqlConnection Cont = new SqlConnection(Properties.Settings.Default.LibraryCon))
                    {
                        string comdQuery = $"Insert into Readers Values" +
                            $"('{firstName}','{lastName}','{phone}',{2})";
                        SqlCommand Comd = new SqlCommand(comdQuery, Cont);
                        Cont.Open();
                        int result = Comd.ExecuteNonQuery();
                        if (result >= 1)
                        {
                            MessageBox.Show($"{firstName} was created successfully!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Phone should be numeric charachter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Butun xanalari doldurun sora basdiyaq", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
