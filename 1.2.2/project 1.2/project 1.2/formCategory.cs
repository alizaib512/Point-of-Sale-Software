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

namespace project_1._2
{
    public partial class formCategory : Form
    {  SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-4DB2DSO;Initial Catalog=Connection;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        formCategoryList flist;
        public formCategory(formCategoryList frm)
        {
            sqlcon = new SqlConnection(dbcon.MyConnection());
            InitializeComponent();
           flist = frm ;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        private void Clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled =false;

            txtCategory.Clear();
            txtCategory.Focus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtCategory.Text == "")
            {

                txtCategory.BackColor = Color.Red;
                MessageBox.Show(this,
                                    "Invalid Data ",
                                   "Exit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);


                txtCategory.Focus();
                txtCategory.BackColor = Color.White;
                return;
            }
            try
            {
                if(MessageBox.Show("Are you sure you want to Save this category?", "Saving Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){

                    sqlcon.Open();
                    cm = new SqlCommand("INSERT  INTo tblCategory(category)VALUEs(@category)", sqlcon);
                    cm.Parameters.AddWithValue("@category", txtCategory.Text);
                    cm.ExecuteNonQuery();
                    sqlcon.Close();
                    MessageBox.Show("Category has benn Saved!");
                    Clear();
                    flist.loadCategory();
                }


            }
            catch(Exception ex)
            {

                sqlcon.Close();
                MessageBox.Show(ex.Message);
               
            }
        }

        private void formCategory_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure! you want to update this Category?", "Record Updated", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    sqlcon.Open();
                    cm = new SqlCommand("update tblcategory set category=@category where id like '" + lblId.Text + "' ", sqlcon);
                    cm.Parameters.AddWithValue("@category", txtCategory.Text);
                    cm.ExecuteNonQuery();

                    sqlcon.Close();
                    MessageBox.Show("Category has successfully Updated!");
                    Clear();
                    flist.loadCategory();
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {


            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (txtCategory.Text == "")
            {

                btnCancel.Enabled = false;
               

            }
            txtCategory.Clear();
            btnCancel.Enabled = false;
         

        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
        }

        private void btnCancel_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnCancel.Enabled = true;
        }
    }
}
