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
    public partial class formProduct : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-4DB2DSO;Initial Catalog=Connection;Integrated Security=True");
        fromProductLsit flist;

        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();

       

        public formProduct(fromProductLsit frm)
        {
            
            sqlcon = new SqlConnection(dbcon.MyConnection());
            InitializeComponent();
            flist = frm;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        public void LaodCategory()
        {
            cboCategory.Items.Clear();
            sqlcon.Open();
            cm = new SqlCommand("select category from tblcategory ", sqlcon);

            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cboCategory.Items.Add(dr[0].ToString());

            }

            dr.Close();
            sqlcon.Close();



        }


        private void formProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure! you want to update this Product?", "Save Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string cid = "";

                    sqlcon.Open();
                    cm = new SqlCommand("Select id from  tblCategory where category like '" + cboCategory.Text + "'", sqlcon);
                    dr = cm.ExecuteReader();
                    dr.Read();

                    if (dr.HasRows) { cid = dr[0].ToString(); }
                    dr.Close();

                    sqlcon.Close();




                    sqlcon.Open();
                    cm = new SqlCommand("INSERT INTO tblProduct (code, detail, cid, price,quantity) VALUES(@pcode, @detail, @cid, @price,@quantity) ", sqlcon);
                    cm.Parameters.AddWithValue("@pcode ", txtCode.Text);
                    cm.Parameters.AddWithValue("@detail ", txtDetail.Text);
                    cm.Parameters.AddWithValue("@cid ", cid);
                    cm.Parameters.AddWithValue("@price", txtPrice.Text);
                    cm.Parameters.AddWithValue("@code ", txtCode.Text);
                    cm.Parameters.AddWithValue("@quantity ", txtQuantity.Text);
                    cm.ExecuteNonQuery();

                    sqlcon.Close();
                    MessageBox.Show("Product has been successfully Saved!");
                    Clear();
                    flist.LoadRecord();
                    this.Dispose();

                }

            }
            catch (Exception ex)
            {
                sqlcon.Close();

                MessageBox.Show(ex.Message);
            }



        }

        private void Clear()
        {
            //btnSave.Enabled = true;
           // btnUpdate.Enabled = false;

            txtPrice.Clear();
            txtCode.Clear();
            txtDetail.Clear();
            txtQuantity.Clear();
            cboCategory.Text = "";
            txtCode.Focus();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure! you want to update this Product?", "Save Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string cid = "";

                    sqlcon.Open();
                    cm = new SqlCommand("Select id from  tblCategory where category like '" + cboCategory.Text + "'", sqlcon);
                    dr = cm.ExecuteReader();
                    dr.Read();

                    if (dr.HasRows) { cid = dr[0].ToString(); }
                    dr.Close();

                    sqlcon.Close();




                    sqlcon.Open();
                    cm = new SqlCommand("UPDATE tblProduct SET detail=@detail,cid=@cid,price=@price,quantity=@quantity where code like @pcode ", sqlcon);
                    cm.Parameters.AddWithValue("@pcode ", txtCode.Text);
                    cm.Parameters.AddWithValue("@detail ", txtDetail.Text);
                    cm.Parameters.AddWithValue("@cid ", cid);
                    cm.Parameters.AddWithValue("@price", txtPrice.Text);
                    cm.Parameters.AddWithValue("@code ", txtCode.Text);
                    cm.Parameters.AddWithValue("@quantity ", txtQuantity.Text);
                    cm.ExecuteNonQuery();

                    sqlcon.Close();
                    MessageBox.Show("Product has been successfully Updated!");
                    Clear();
                    flist.LoadRecord();
                    this.Dispose();

                }

            }
            catch (Exception ex)
            {
                sqlcon.Close();

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            Clear();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsWhiteSpace(e.KeyChar)) && !char.IsControl(e.KeyChar) && !(e.KeyChar == 46))
            {
                e.Handled = true;
            }
        }

        private void txtDetail_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && (!char.IsWhiteSpace(e.KeyChar)) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && (!char.IsWhiteSpace(e.KeyChar)) &&  !char.IsControl(e.KeyChar) && !(e.KeyChar == 46))
            {
                e.Handled = true;
            }
        }
    }
}