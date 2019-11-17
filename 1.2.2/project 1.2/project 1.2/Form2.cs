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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validation 







            if (textBox1.Text == "FullName" && textBox2.Text == "0333-XXXXXXX" && textBox3.Text == "" && textBox4.Text == "abc123@gmail.com")
            {





                // txtEmptyString_Validated("",e);

                textBox1.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;
                textBox3.BackColor = Color.Red;
                textBox4.BackColor = Color.Red;
                MessageBox.Show(this,
                                    "Invalid Data",
                                   "Exit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);





                textBox1.Focus();
                textBox1.BackColor = Color.White;




                textBox2.Focus();
                textBox2.BackColor = Color.White;
                textBox3.Focus();
                textBox3.BackColor = Color.White;
                textBox4.Focus();
                textBox4.BackColor = Color.White;


                this.errorProvider1.SetError(textBox1, "This field must contain text");
                this.errorProvider3.SetError(textBox2, "This field must contain text");
                this.errorProvider2.SetError(textBox3, "This field must contain text");
                this.errorProvider4.SetError(textBox4, "This field must contain text");




            }






            else if (textBox1.Text != "FullName" && textBox2.Text == "0333-XXXXXXX" && textBox3.Text == "" && textBox4.Text == "abc123@gmail.com")
            {
                textBox3.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;
                textBox4.BackColor = Color.Red;
                MessageBox.Show(this,
                                    "Invalid Data",
                                   "Exit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                textBox1.BackColor = Color.White;

                textBox2.BackColor = Color.White;
                textBox3.Focus();
                textBox3.BackColor = Color.White;
                textBox4.Focus();
                textBox4.BackColor = Color.White;
                this.errorProvider3.SetError(textBox2, "");

            }

            else if (textBox1.Text != "FullName" && textBox2.Text != "0333-XXXXXXX" && textBox3.Text == "" && textBox4.Text == "abc123@gmail.com")
            {

                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "" && textBox4.Text == "")
                {


                    textBox3.BackColor = Color.Red;
                    textBox4.BackColor = Color.Red;
                    MessageBox.Show(this,
                                        "Invalid Data",
                                       "Exit",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                    textBox1.BackColor = Color.White;
                    textBox2.BackColor = Color.White;


                    textBox3.Focus();
                    textBox3.BackColor = Color.White;
                    textBox4.Focus();
                    textBox4.BackColor = Color.White;
                }
            }


            else if (textBox1.Text != "FullName" && textBox2.Text != "0333-XXXXXXX" && textBox3.Text != "" && textBox4.Text == "abc123@gmail.com")
            {


            
                        textBox4.BackColor = Color.Red;
                        MessageBox.Show(this,
                                            "Invalid Data ",
                                           "Exit",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);


                        textBox1.Focus();
                        textBox1.BackColor = Color.White;
                        textBox2.BackColor = Color.White;
                        textBox3.BackColor = Color.White;


                        textBox4.Focus();
                        textBox4.BackColor = Color.White;
                    

                    // code
                }






            

            else if (textBox1.Text != "FullName" && textBox2.Text != "0333-XXXXXXX" && textBox3.Text != "" && textBox4.Text != "abc123@gmail.com")
            {

                

                        textBox1.Focus();
                        textBox1.BackColor = Color.White;
                        textBox2.BackColor = Color.White;
                        textBox3.BackColor = Color.White;
                        textBox4.BackColor = Color.White;
                        MessageBox.Show("OK! ");


                //Insert data 

                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-4DB2DSO;Initial Catalog=Connection;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[tbl_Login]

                           (
                           [username]
                           ,[password]
                           ,[repassword]
                        ,[email])

                    

                     VALUES
                           ('" + textBox1.Text + "'  , ' " + textBox2.Text + "' ,'" + textBox3.Text + "'  ,  '" + textBox4.Text + "' )", sqlcon);

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

                //end insertion





                // code
            }




            



            else if (textBox1.Text != "FullName" && textBox2.Text == "0333-XXXXXXX" && textBox3.Text != "" && textBox4.Text == "abc123@gmail.com")
            {





                   

                        textBox2.BackColor = Color.Red;
                        textBox4.BackColor = Color.Red;
                        MessageBox.Show(this,
                                            "Invalid Data",
                                           "Exit",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Focus();
                        textBox1.BackColor = Color.White;

                        textBox2.BackColor = Color.White;
                        textBox3.Focus();
                        textBox3.BackColor = Color.White;
                        textBox4.Focus();
                        textBox4.BackColor = Color.White;
                    

                    // code
                




            }
            else if (textBox1.Text == "FullName" && textBox2.Text != "0333-XXXXXXX" && textBox3.Text == "" && textBox4.Text != "abc123@gmail.com")
            {
                textBox1.BackColor = Color.Red;
                textBox3.BackColor = Color.Red;

                MessageBox.Show(this,
                                    "Invalid Data",
                                   "Exit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                textBox1.BackColor = Color.White;

                textBox2.BackColor = Color.White;
                textBox3.Focus();
                textBox3.BackColor = Color.White;
                textBox4.Focus();
                textBox4.BackColor = Color.White;

            }
            else if (textBox1.Text != "FullName" && textBox2.Text == "0333-XXXXXXX" && textBox3.Text == "" && textBox4.Text != "abc123@gmail.com")
            {

                textBox2.BackColor = Color.Red;
                textBox3.BackColor = Color.Red;
                MessageBox.Show(this,
                                    "Invalid Data",
                                   "Exit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                textBox1.BackColor = Color.White;

                textBox2.BackColor = Color.White;
                textBox3.Focus();
                textBox3.BackColor = Color.White;
                textBox4.Focus();
                textBox4.BackColor = Color.White;

            }
            else if (textBox1.Text != "FullName" && textBox2.Text != "0333-XXXXXXX" && textBox3.Text == "" && textBox4.Text != "abc123@gmail.com")
            {



                textBox3.BackColor = Color.Red;
                MessageBox.Show(this,
                                    "Invalid Data",
                                   "Exit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;


                textBox4.Focus();
                textBox4.BackColor = Color.White;

            }
            else if (textBox1.Text != "FullName" && textBox2.Text == "0333-XXXXXXX" && textBox3.Text != "" && textBox4.Text != "abc123@gmail.com")
            {

                
                    

                        textBox2.BackColor = Color.Red;

                        MessageBox.Show(this,
                                            "Invalid Data",
                                           "Exit",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Focus();
                        textBox1.BackColor = Color.White;
                        textBox2.BackColor = Color.White;
                        textBox3.BackColor = Color.White;


                        textBox4.Focus();
                        textBox4.BackColor = Color.White;
                    

                    // code
                




            }
            else if (textBox1.Text == "FullName" && textBox2.Text != "0333-XXXXXXX" && textBox3.Text != "" && textBox4.Text != "abc123@gmail.com")
            {




                        textBox1.BackColor = Color.Red;

                        MessageBox.Show(this,
                                            "Invalid Data",
                                           "Exit",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Focus();
                        textBox1.BackColor = Color.White;

                        textBox2.BackColor = Color.White;
                        textBox3.Focus();
                        textBox3.BackColor = Color.White;
                        textBox4.Focus();
                        textBox4.BackColor = Color.White;
                    

                    // code
                






            }
            else if (textBox1.Text == "FullName" && textBox2.Text == "0333-XXXXXXX" && textBox3.Text != "" && textBox4.Text != "abc123@gmail.com")
            {

           
                    
               



                        textBox1.BackColor = Color.Red;
                        textBox2.BackColor = Color.Red;

                        MessageBox.Show(this,
                                            "Invalid Data",
                                           "Exit",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Focus();
                        textBox1.BackColor = Color.White;

                        textBox2.BackColor = Color.White;
                        textBox3.Focus();
                        textBox3.BackColor = Color.White;
                        textBox4.Focus();
                        textBox4.BackColor = Color.White;

                    
       
                    // code
                



            }
            else if (textBox1.Text == "FullName" && textBox2.Text != "" && textBox3.Text == "" && textBox4.Text == "abc123@gmail.com")
            {
                textBox1.BackColor = Color.Red;
                textBox3.BackColor = Color.Red;
                textBox4.BackColor = Color.Red;
                MessageBox.Show(this,
                                    "Invalid Data",
                                   "Exit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                textBox1.BackColor = Color.White;

                textBox2.BackColor = Color.White;
                textBox3.Focus();
                textBox3.BackColor = Color.White;
                textBox4.Focus();
                textBox4.BackColor = Color.White;

            }

            else if (textBox1.Text == "FullName" && textBox2.Text == "0333-XXXXXXX" && textBox3.Text != "" && textBox4.Text == "abc123@gmail.com")
            {





                        textBox1.BackColor = Color.Red;
                        textBox2.BackColor = Color.Red;
                        textBox4.BackColor = Color.Red;
                        MessageBox.Show(this,
                                            "Invalid Data",
                                           "Exit",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Focus();
                        textBox1.BackColor = Color.White;

                        textBox2.BackColor = Color.White;
                        textBox3.Focus();
                        textBox3.BackColor = Color.White;
                        textBox4.Focus();
                        textBox4.BackColor = Color.White;









            }
            else if (textBox1.Text == "FullName" && textBox2.Text == "0333-XXXXXXX" && textBox3.Text == "" && textBox4.Text != "abc123@gmail.com")
            {




                textBox1.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;
                textBox3.BackColor = Color.Red;
                MessageBox.Show(this,
                                    "Invalid Data",
                                   "Exit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                textBox1.BackColor = Color.White;

                textBox2.BackColor = Color.White;
                textBox3.Focus();
                textBox3.BackColor = Color.White;
                textBox4.Focus();
                textBox4.BackColor = Color.White;


            }





            //Validation End



            else if (textBox1.Text != "" && textBox2.Text != "")
            {





                MessageBox.Show("OK! ");




                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-4DB2DSO;Initial Catalog=Connection;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[tbl_Login]

                           (
                           [username]
                           ,[password]
                           ,[repassword]
                        ,[email])

                    

                     VALUES
                           ('" + textBox1.Text + "'  , ' " + textBox2.Text + "' ,'" + textBox3.Text + "'  ,  '" + textBox4.Text + "' )", sqlcon);

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



        //error provider



        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {




            //s
            bool bStatus = true; if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Please enter your Name");

                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");


            }
            //e
        }


        //Validation

        private void txtEmptyString_Validated(object sender, EventArgs e)

        {

            bool bTest = txtEmptyStringIsValid();

            if (bTest == true)

            {
                this.errorProvider1.SetError(textBox1, "This field must contain text");
                this.errorProvider3.SetError(textBox2, "This field must contain text");
                this.errorProvider2.SetError(textBox3, "This field must contain text");
                this.errorProvider4.SetError(textBox4, "This field must contain text");


            }

            else

            {

                this.errorProvider1.SetError(textBox1, "");
                this.errorProvider3.SetError(textBox2, "");
                this.errorProvider2.SetError(textBox3, "");
                this.errorProvider4.SetError(textBox4, "");


            }
        }

        private bool txtEmptyStringIsValid()

        {

            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty && textBox3.Text == string.Empty && textBox4.Text == string.Empty)

            {

                return true;

            }

            else

            {

                return false;

            }
        }



       
        //end error provider

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {


                textBox1.Text = "FullName";
                textBox1.ForeColor = Color.Silver;

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "FullName")
            {


                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

            if (textBox2.Text == "0333-XXXXXXX")
            {

                textBox2.Text = "";

                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {



                textBox2.Text = "0333-XXXXXXX";

                textBox2.ForeColor = Color.Silver;


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {




            //s
            bool bStatus = true; if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Please enter your Name");

                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");


            }
            //e
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            //s

            bool bStatus = true;
            if (textBox2.Text == "")
            {
                errorProvider3.SetError(textBox2, "Please enter your Name");

                bStatus = false;
            }
            else
            {
                errorProvider3.SetError(textBox2, "");


            }
            //e
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsWhiteSpace(e.KeyChar)) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }


        }
        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && (!char.IsWhiteSpace(e.KeyChar)) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //s

            bool bStatus = true;
            if (textBox3.Text == "")
            {
                errorProvider3.SetError(textBox3, "Please enter your Name");

                bStatus = false;
            }
            else
            {
                errorProvider3.SetError(textBox3, "");


            }
            //e
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {


            bool bStatus = true;
            if (textBox4.Text == "")
            {
                errorProvider4.SetError(textBox4, "Please enter your Name");

                bStatus = false;
            }
            else
            {
                errorProvider4.SetError(textBox4, "");


            }
        }


        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (!char.IsLower(e.KeyChar) && !(e.KeyChar == 64) && !(e.KeyChar == 46)))
            {
                e.Handled = true;

            }


        }

        private void textBox4_Enter(object sender, EventArgs e)
        {

            if (textBox4.Text == "abc123@gmail.com")
            {

                textBox4.Text = "";

                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {



                textBox4.Text = "abc123@gmail.com";
            
                textBox4.ForeColor = Color.Silver;


            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {


                button1.Enabled = true;


               
            }
            else



            {

                
                button1.Enabled= false;
                

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1Login obj = new Form1Login();
            this.Hide();
            obj.ShowDialog();
            this.Close();
        }
    }
}
