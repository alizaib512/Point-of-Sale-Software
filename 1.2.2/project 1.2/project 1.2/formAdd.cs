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
    public partial class formAdd : Form
    {

        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-4DB2DSO;Initial Catalog=Connection;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        formlist frmlsit;
        public formAdd(formlist flist)
        {


            InitializeComponent();
            sqlcon = new SqlConnection(dbcon.MyConnection());
            frmlsit = flist;

            txtIsValid();
            btnCancel.Enabled = false;
           btnSave.Enabled = false;
           




        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            btnSave.Enabled = true;
           // btnUpdate.Enabled = true;

            txtAdd.Clear();
            txtAdd.Focus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (txtAdd.Text == "")
            {

                txtAdd.BackColor = Color.Red;
                MessageBox.Show(this,
                                    "Invalid Data ",
                                   "Exit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);


               txtAdd.Focus();
                txtAdd.BackColor = Color.White;
                return;
            }

            try
            {
                if (MessageBox.Show("Are you sure you want to Save this item?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    sqlcon.Open();
                    cm = new SqlCommand("INSERT  INTo tblBrand(Brand)VALUEs(@brand)", sqlcon);
                    cm.Parameters.AddWithValue("@brand", txtAdd.Text);
                    cm.ExecuteNonQuery();
                    sqlcon.Close();
                    MessageBox.Show("Record has benn Saved!");
                    Clear();
                    frmlsit.loadRecord();

                    

                }

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure! you want to update this item?", "Record Updated", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    sqlcon.Open();
                    cm = new SqlCommand("update tblbrand set brand =@brand where id like '" + lblId.Text + "' ", sqlcon);
                    cm.Parameters.AddWithValue("@brand", txtAdd.Text);
                    cm.ExecuteNonQuery();

                    sqlcon.Close();
                    MessageBox.Show("Item has successfully Updated!");
                    Clear();
                    frmlsit.loadRecord();
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtAdd.Text == "")
            {

                btnCancel.Enabled = false;
                btnSave.Enabled = false;

            }
            txtAdd.Clear();
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            


        }

        private void btnCancel_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtAdd_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {

        }



      
        private void txtIsValid()

        {

            if (txtAdd.Text != string.Empty)

            {

                btnCancel.Enabled = true;
                btnSave.Enabled = true;


            }
            else
            {

                btnCancel.Enabled = false;

                btnSave.Enabled = false;


            }
        }

        private void txtAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
        }

       
    }
}

