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
    public partial class formCategoryList : Form
    {


        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-4DB2DSO;Initial Catalog=Connection;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public formCategoryList()
        {
            InitializeComponent();
            sqlcon = new SqlConnection(dbcon.MyConnection());
        }

        public void loadCategory()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            sqlcon.Open();

            cm = new SqlCommand("Select * from tblCategory order by category", sqlcon);
            dr = cm.ExecuteReader();


            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add( i, dr["id"].ToString(), dr["category"].ToString());
            }
            sqlcon.Close();
            dr.Close();

        }






        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            formCategory frm = new formCategory(this);
            frm.btnUpdate.Enabled = false;
            frm.btnSave.Enabled = true;
            frm.ShowDialog();
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            string colname = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colname == "Edit")
            {


                formCategory frm = new formCategory(this);

                frm.txtCategory.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                frm.lblId.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                frm.btnSave.Enabled = false;
                frm.btnUpdate.Enabled = true;
                frm.ShowDialog();
            }
            else if (colname == "Delete")
            {

                if (MessageBox.Show("Are you sure want too delete this Category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    sqlcon.Open();
                    cm = new SqlCommand("delete  from tblCategory where id  like '" + dataGridView1[1, e.RowIndex].Value.ToString() + "'", sqlcon);

                    cm.ExecuteNonQuery();
                    sqlcon.Close();
                    MessageBox.Show("Category Deleted Successfully", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadCategory();
                }
            }

        }
        }
    }

