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
    public partial class Form1Login : Form
    {
        
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-4DB2DSO;Initial Catalog=Connection;Integrated Security=True");
        public Form1Login()
        {
            InitializeComponent();
            button3.Enabled = false;
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        private void button3_Click(object sender, EventArgs e)
        {


            //Valdation 


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


            //code for user name match











            //matching code



            else if (textBox1.Text != "FullName" && textBox2.Text == "0333-XXXXXXX" && textBox3.Text == "" && textBox4.Text == "abc123@gmail.com")
            {



                //username matching code

                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-4DB2DSO;Initial Catalog=Connection;Integrated Security=True");
                string query = "Select * from dbo.tbl_login Where  username= '" + textBox1.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable tab = new DataTable();
                sda.Fill(tab);

                if (tab.Rows.Count == 1)
                {

                    label2.ForeColor = Color.Green;
                    label2.Text = "OK!";




                    textBox3.BackColor = Color.Red;
                    textBox2.BackColor = Color.Red;
                    textBox4.BackColor = Color.Red;
                    MessageBox.Show(this,
                                        "Invalid Data! username matched",
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
                else
                {
                    textBox1.BackColor = Color.Red;
                    textBox3.BackColor = Color.Red;
                    textBox2.BackColor = Color.Red;
                    textBox4.BackColor = Color.Red;
                    MessageBox.Show(this,
                                        "Invalid Data! Incorrect userName",
                                       "Exit",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                    textBox1.Clear();
                    textBox1.BackColor = Color.White;

                    textBox2.BackColor = Color.White;
                    textBox3.Focus();
                    textBox3.BackColor = Color.White;
                    textBox4.Focus();
                    textBox4.BackColor = Color.White;
                    this.errorProvider3.SetError(textBox2, "");


                }

                //matching
            }








            else if (textBox1.Text != "FullName" && textBox2.Text != "0333-XXXXXXX" && textBox3.Text == "" && textBox4.Text == "abc123@gmail.com")
            {





                //matching

                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-4DB2DSO;Initial Catalog=Connection;Integrated Security=True");
                string query = "Select * from dbo.tbl_login Where  username= '" + textBox1.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable tab = new DataTable();
                sda.Fill(tab);

                if (tab.Rows.Count == 1)
                {

                    label2.ForeColor = Color.Green;
                    label2.Text = "OK!";




                    textBox3.BackColor = Color.Red;
                    textBox4.BackColor = Color.Red;
                    MessageBox.Show(this,
                         "Invalid Data! username matched,  ",
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
                else
                {
                    textBox3.BackColor = Color.Red;
                    textBox4.BackColor = Color.Red;
                    MessageBox.Show(this,
                        "Invalid Data! Invalid username",
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

                //matching


            }


            else if (textBox1.Text != "FullName" && textBox2.Text != "0333-XXXXXXX" && textBox3.Text != "" && textBox4.Text == "abc123@gmail.com")
            {


                //matching
                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-4DB2DSO;Initial Catalog=Connection;Integrated Security=True");
                string query = "Select * from dbo.tbl_login Where  username= '" + textBox1.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable tab = new DataTable();
                sda.Fill(tab);

                if (tab.Rows.Count == 1)
                {

                    label2.ForeColor = Color.Green;
                    label2.Text = "OK!";




                    textBox4.BackColor = Color.Red;
                    MessageBox.Show(this,
                              "Invalid Data! username,Password matched",
                             "Exit",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBox1.Focus();
                    textBox1.BackColor = Color.White;
                    textBox2.BackColor = Color.White;
                    textBox3.BackColor = Color.White;


                    textBox4.Focus();
                    textBox4.BackColor = Color.White;


                }
                else
                {
                    textBox4.BackColor = Color.Red;
                    textBox1.BackColor = Color.Red;
                    MessageBox.Show(this,
                           "Invalid Data! Invalid username",
                          "Exit",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);


                    textBox1.Focus();
                    textBox1.Clear();
                    textBox1.BackColor = Color.White;
                    textBox2.BackColor = Color.White;
                    textBox3.BackColor = Color.White;


                    textBox4.Focus();
                    textBox4.BackColor = Color.White;



                }

                //mached


                // code
            }









            else if (textBox1.Text != "FullName" && textBox2.Text != "0333-XXXXXXX" && textBox3.Text != "" && textBox4.Text != "abc123@gmail.com")
            {
                //matching
                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-4DB2DSO;Initial Catalog=Connection;Integrated Security=True");
                string query1 = "Select * from dbo.tbl_login Where  username= '" + textBox1.Text.Trim() + "' ";
                string query2 = "Select * from dbo.tbl_login Where password= '" + textBox2.Text.Trim() + "'";
                string query3 = "Select * from dbo.tbl_login Where repassword= '" + textBox3.Text.Trim() + "'";
                string query4 = "Select * from dbo.tbl_login Where email= '" + textBox4.Text.Trim() + "'";

                string query5 = "Select * from dbo.tbl_login Where  username= '" + textBox1.Text.Trim() + "' and password= '" + textBox2.Text.Trim() + "' and  repassword= '" + textBox3.Text.Trim() + "'and  email= '" + textBox4.Text.Trim() + "'";

                SqlDataAdapter sda1 = new SqlDataAdapter(query1, sqlcon);
                SqlDataAdapter sda2 = new SqlDataAdapter(query2, sqlcon);
                SqlDataAdapter sda3 = new SqlDataAdapter(query3, sqlcon);
                SqlDataAdapter sda4 = new SqlDataAdapter(query4, sqlcon);
                SqlDataAdapter sda5 = new SqlDataAdapter(query5, sqlcon);
                DataTable tab1 = new DataTable();
                DataTable tab2 = new DataTable();
                DataTable tab3 = new DataTable();
                DataTable tab4 = new DataTable();
                DataTable tab5 = new DataTable();
                sda1.Fill(tab1);
                sda2.Fill(tab2);
                sda3.Fill(tab3);
                sda4.Fill(tab4);
                sda5.Fill(tab5);





                if (tab5.Rows.Count == 1)
                {

                    MessageBox.Show(this,
                            "Welcome main",
                            "Exit",
                             MessageBoxButtons.OK, MessageBoxIcon.Question);



                    Form2 obj1 = new Form2();

                    this.Hide();
                    obj1.ShowDialog();
                    this.Close();
                }
                else if (tab1.Rows.Count == 0 )
                {
                    
                    string[] intArray;

                    // allocating memory for 5 integers. 
                    intArray = new string[5];


                    intArray[0] =" phone MAtched";
                    intArray[1] ="password MAtched";
                    intArray[2] ="email MAtched";

                    if (tab2.Rows.Count == 0)
                    {


                        intArray[0] = " phone not MAtched";

                    }


                        if (tab3.Rows.Count == 0) {


                        intArray[1] = "password not MAtched";
                    }
                    if ( tab4.Rows.Count == 0)
                    {

                        intArray[2] = "email not MAtched";


                    }


                   
                    textBox1.BackColor = Color.Red;
                   // string b = intArray[0] + intArray[1] + intArray[2];
                    MessageBox.Show(this,
                              "Invalid Data!" + intArray[0]+ "," + intArray[1] +"," + intArray[2],
                             "Exit",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);


                    textBox1.Focus();                                                    //worked
                    textBox1.Clear();


                    textBox1.BackColor = Color.White;
                    textBox2.BackColor = Color.White;
                    textBox3.BackColor = Color.White;


                    textBox4.Focus();
                    textBox4.BackColor = Color.White;

                }

                else if (tab1.Rows.Count == 0 && tab2.Rows.Count == 0 && tab3.Rows.Count == 1 && tab4.Rows.Count == 1)
                {

                    textBox1.BackColor = Color.Red;
                    textBox2.BackColor = Color.Red;

                    MessageBox.Show(this,
                              "Invalid Data! ,Password,email matched",
                             "Exit",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);


                    textBox1.Focus();                                                    //worked
                    textBox1.Clear();
                    textBox2.Clear();

                    textBox1.BackColor = Color.White;
                    textBox2.BackColor = Color.White;
                    textBox3.BackColor = Color.White;


                    textBox4.Focus();
                    textBox4.BackColor = Color.White;
                }
                else if (tab1.Rows.Count == 0 && tab2.Rows.Count == 0 && tab3.Rows.Count == 0 && tab4.Rows.Count == 1)
                {
                    textBox1.BackColor = Color.Red;
                    textBox2.BackColor = Color.Red;
                    textBox3.BackColor = Color.Red;

                    MessageBox.Show(this,
                             "Invalid Data! email matched",
                            "Exit",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);


                    textBox1.Focus();
                    textBox1.Clear();                                                           //worked  
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox1.BackColor = Color.White;
                    textBox2.BackColor = Color.White;
                    textBox3.BackColor = Color.White;


                    textBox4.Focus();
                    textBox4.BackColor = Color.White;

                }
                

                else if (tab1.Rows.Count == 0 && tab2.Rows.Count == 0 && tab3.Rows.Count == 0 && tab4.Rows.Count == 0)
                {

                    textBox1.BackColor = Color.Red;
                    textBox2.BackColor = Color.Red;
                    textBox3.BackColor = Color.Red;
                    textBox4.BackColor = Color.Red;



                                                                                                //worked
                    MessageBox.Show(this,
                         "Invalid",
                         "Exit",
                          MessageBoxButtons.OK, MessageBoxIcon.Question);
                    textBox1.Focus();
                    textBox1.Clear();
                    textBox1.BackColor = Color.White;
                    textBox2.Focus();
                    textBox2.BackColor = Color.White;
                    textBox2.Clear();
                    textBox3.Focus();
                    textBox3.Clear();
                    textBox3.BackColor = Color.White;

                    textBox4.Focus();
                    textBox4.Clear();
                    textBox4.BackColor = Color.White;




                }
                else if (tab1.Rows.Count == 1 && tab2.Rows.Count == 0 && tab3.Rows.Count == 1 && tab4.Rows.Count == 0)
                {

                    
                    textBox2.BackColor = Color.Red;
                   
                    textBox4.BackColor = Color.Red;



                    //worked
                    MessageBox.Show(this,
                         "Invalid,Name ,pasword matched",
                         "Exit",
                          MessageBoxButtons.OK, MessageBoxIcon.Question);
                    textBox1.Focus();
                    textBox1.Clear();
                    textBox1.BackColor = Color.White;
                    textBox2.Clear();
                    textBox2.BackColor = Color.White;
                    textBox3.Clear();
                    textBox3.BackColor = Color.White;
                    textBox4.Clear();
                    textBox4.BackColor = Color.White;



                }
                else if (tab1.Rows.Count == 0 && tab2.Rows.Count == 1 && tab3.Rows.Count == 0 && tab4.Rows.Count == 1)
                {

                    textBox1.BackColor = Color.Red;
                 
                    textBox3.BackColor = Color.Red;
              



                    //worked
                    MessageBox.Show(this,
                         "Invalid! phone ,email matched ",
                         "Exit",
                          MessageBoxButtons.OK, MessageBoxIcon.Question);
                    textBox1.Focus();
                    textBox1.Clear();
                    textBox1.BackColor = Color.White;
                    textBox2.Clear();
                    textBox2.BackColor = Color.White;
                    textBox3.Clear();
                    textBox3.BackColor = Color.White;
                    textBox4.Clear();
                    textBox4.BackColor = Color.White;



                }
                else if (tab1.Rows.Count == 1 && tab2.Rows.Count == 0 && tab3.Rows.Count == 0 && tab4.Rows.Count == 0)
                {

                    textBox2.BackColor = Color.Red;
                    textBox3.BackColor = Color.Red;
                    textBox4.BackColor = Color.Red;

                    MessageBox.Show(this,
                              "Invalid Data! ,username matched",
                             "Exit",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);


                    textBox2.Focus();                                                    //worked
                    textBox2.Clear();
                    textBox3.Focus();
                    textBox3.Clear();
                    textBox4.Focus();
                    textBox4.Clear();

                    textBox1.BackColor = Color.White;
                    textBox2.BackColor = Color.White;
                    textBox3.BackColor = Color.White;
          
                    textBox4.Focus();
                    textBox4.BackColor = Color.White;
                }
                else if (tab1.Rows.Count == 1 && tab2.Rows.Count == 1 && tab3.Rows.Count == 0 && tab4.Rows.Count == 0)
                {

              
                    textBox3.BackColor = Color.Red;
                    textBox4.BackColor = Color.Red;

                    MessageBox.Show(this,
                              "Invalid Data! ,username,phone matched",
                             "Exit",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);


                   
                    textBox3.Focus();
                    textBox3.Clear();
                    textBox4.Focus();
                    textBox4.Clear();

                    textBox1.BackColor = Color.White;
                    textBox2.BackColor = Color.White;
                    textBox3.BackColor = Color.White;

                    textBox4.Focus();
                    textBox4.BackColor = Color.White;
                }


             
                else
                {
                    MessageBox.Show(this,
                             "Invalid Data! ",
                            "Exit",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);


                }


          
            
            

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




            //Validation end






        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSignup obj1 = new FormSignup();

            this.Hide();
            obj1.ShowDialog();
            this.Close();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3_Click(this, new EventArgs());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
       

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {



                textBox4.Text = "abc123@gmail.com";

                textBox4.ForeColor = Color.Silver;


            }
        }
        private void textBox4_Enter_1(object sender, EventArgs e)
        {

            if (textBox4.Text == "abc123@gmail.com")
            {

                textBox4.Text = "";

                textBox4.ForeColor = Color.Black;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 obj1 = new Form2();

            this.Hide();
            obj1.ShowDialog();
            this.Close();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


           

            if (checkBox1.CheckState == CheckState.Checked)
            {


                button3.Enabled = true;



            }
            else



            {


                button3.Enabled = false;


            }
        }



        //error provider

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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {



          
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-4DB2DSO;Initial Catalog=Connection;Integrated Security=True");
            string query = "Select * from dbo.tbl_login Where  repassword= '" + textBox3.Text.Trim() + "'" ;
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtab = new DataTable();
            sda.Fill(dtab);

            if (dtab.Rows.Count == 1)
            {

                label8.ForeColor = Color.Green;
                label8.Text = "OK!";

               

            }
            else
            {

                label8.ForeColor = Color.Red;
                label8.Text = "Invalid!";



            }

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-4DB2DSO;Initial Catalog=Connection;Integrated Security=True");
            string query = "Select * from dbo.tbl_login Where  username= '" + textBox1.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable tab = new DataTable();
            sda.Fill(tab);

            if (tab.Rows.Count == 1)
            {

                label2.ForeColor = Color.Green;
                label2.Text = "OK!";



            }
            else
            {

                label2.ForeColor = Color.Red;
                label2.Text = "Invalid!";



            }


        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //end error provider

    }
}
