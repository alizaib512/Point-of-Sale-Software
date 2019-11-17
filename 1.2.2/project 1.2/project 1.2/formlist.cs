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
    public partial class formlist : Form 
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-4DB2DSO;Initial Catalog=Connection;Integrated Security=True");

        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        public formlist()
        {
            sqlcon = new SqlConnection(dbcon.MyConnection());
            // sqlcon.Open();
            InitializeComponent();

            loadRecord();


        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            formAdd frm = new formAdd(this);
            frm.btnUpdate.Enabled = false;

            frm.ShowDialog();
            
            
            

        }


        public void loadRecord()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            sqlcon.Open();

            cm = new SqlCommand("Select * from tblbrand order by brand", sqlcon);
            dr = cm.ExecuteReader();


            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["brand"].ToString());
            }
            sqlcon.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colname == "Edit")
            {


                formAdd frm = new formAdd(this);

                frm.lblId.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                frm.txtAdd.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                frm.ShowDialog();
            } else if (colname == "Delete")
            {

               if( MessageBox.Show("Are you sure want too delete this item?","Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    sqlcon.Open();
                    cm = new SqlCommand  (  "delete  from tblbrand where id  like '"  + dataGridView1[1, e.RowIndex ].Value.ToString() +"'"  , sqlcon);

                    cm.ExecuteNonQuery();
                    sqlcon.Close();
                    MessageBox.Show("Item Deleted Successfully"," ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    loadRecord();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
