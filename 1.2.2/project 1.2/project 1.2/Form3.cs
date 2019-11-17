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
    public partial class Form3 : Form
    {


        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-4DB2DSO;Initial Catalog=Connection;Integrated Security=True");
   
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();



        public Form3()
        {
           
           sqlcon= new SqlConnection(dbcon.MyConnection());
            sqlcon.Open();
            MessageBox.Show("Connected");
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            formlist obj = new formlist();

            obj.TopLevel = false;
            panel3.Controls.Add(obj);
            obj.BringToFront();
            obj.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            formCategoryList frm = new formCategoryList();
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
                frm.BringToFront();

            frm.loadCategory();
            frm.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            fromProductLsit frm= new fromProductLsit();

            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();

            frm.LoadRecord();
            frm.Show();
        }
    }
}
