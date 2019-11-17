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
    public partial class fromProductLsit : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-4DB2DSO;Initial Catalog=Connection;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public fromProductLsit()
        {
            InitializeComponent();
            sqlcon = new SqlConnection(dbcon.MyConnection());

        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            string colname = dataGridView1.Columns[e.ColumnIndex].Name;



            if (colname == "Edit")
            {


                formProduct frm = new formProduct(this);


                frm.btnSave.Enabled = false;
                frm.btnUpdate.Enabled = true;

                frm.txtCode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.txtDetail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm.cboCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm.txtQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                frm.txtCode.Focus();
                frm.ShowDialog();

            }
        
    
            else
            {
                if (MessageBox.Show("Are you sure want too delete this Category?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sqlcon.Open();
                    cm = new SqlCommand("delete from tblProduct where code like '"+ dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'",sqlcon);
                    cm.ExecuteNonQuery();
                    sqlcon.Close();
                    LoadRecord();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            formProduct frm = new formProduct(this);
            frm.btnSave.Enabled = true;
            frm.btnUpdate.Enabled = false;

            frm.LaodCategory();
            frm.ShowDialog();
        }


        public void LoadRecord()
        {


            
                int i = 0;
            dataGridView1.Rows.Clear();

                sqlcon.Open();

                cm = new SqlCommand("Select p.code,p.detail,c.category ,p.price,p.quantity from tblProduct as p inner join  tblCategory as c on c.id=p.cid where p.detail like '" + txtSearch.Text + "%' ", sqlcon);



                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                }
                sqlcon.Close();
                dr.Close();

          }

      


        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRecord();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
    
