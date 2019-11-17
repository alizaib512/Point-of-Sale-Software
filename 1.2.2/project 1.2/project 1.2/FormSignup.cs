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
using project_1._2.Properties;

namespace project_1._2
{
    public partial class FormSignup : Form
    {



        Image back=Resources.back;
        public FormSignup()
        {
            InitializeComponent();

            pictureBox1.Image = back;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "" && textBox2.Text == "")
            {





                // txtEmptyString_Validated("",e);

                textBox1.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;

                MessageBox.Show(this,
                                    "Invalid Data",
                                   "Exit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);





                textBox1.Focus();
                textBox1.BackColor = Color.White;




                textBox2.Focus();
                textBox2.BackColor = Color.White;






            }
            else if (textBox1.Text != "" && textBox2.Text == "")
            {





                // txtEmptyString_Validated("",e);


                textBox2.BackColor = Color.Red;

                MessageBox.Show(this,
                                    "Invalid Data",
                                   "Exit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);





                textBox1.Focus();
                textBox1.BackColor = Color.White;




                textBox2.Focus();
                textBox2.BackColor = Color.White;

            }
           else if (textBox1.Text == "" && textBox2.Text != "")
            {





                // txtEmptyString_Validated("",e);


                textBox1.BackColor = Color.Red;

                MessageBox.Show(this,
                                    "Invalid Data",
                                   "Exit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);





                textBox1.Focus();
                textBox1.BackColor = Color.White;




                textBox2.Focus();
                textBox2.BackColor = Color.White;

            }
           else if (textBox1.Text != "" && textBox2.Text != ""){





                MessageBox.Show("OK! ");

                


                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-4DB2DSO;Initial Catalog=Connection;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[tbl_Login]

                           (
                           [username]
                           ,[password])
                     VALUES
                           ('" + textBox1.Text + "'  , ' " + textBox2.Text + "')", sqlcon);

                sqlcon.Open();
                cmd.ExecuteNonQuery();
                sqlcon.Close();


                

                MessageBox.Show("Register Successfully");

                DialogResult dialogResult = MessageBox.Show("Do you want to Sign up", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                    Form1Login obj = new Form1Login();
                    this.Hide();
                    obj.Show();
                }


            }



        


        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this.button2.BackgroundImage = NameSpace1.Properties.Resources.UntitledImage2;

            pictureBox1.BackColor = Color.Red;

            

            CheckBox bold = new CheckBox();
            bold.Appearance = Appearance.Button;
            bold.Size = new Size(16, 16);
            bold.Image = Properties.Resources.back;

            Form1Login obj1 = new Form1Login();
            this.Hide();
            obj1.ShowDialog();
            this.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            
            ToolTip1.SetToolTip(button1, "Back to Login Screen");

            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();

            ToolTip1.SetToolTip(pictureBox1, "Back to Login Screen");


        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox1.BackColor = Color.White;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 12, pictureBox1.Height - 9);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
          pictureBox1.BackColor = Color.WhiteSmoke;

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 12, pictureBox1.Height - 9);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;

        }
    }


}
