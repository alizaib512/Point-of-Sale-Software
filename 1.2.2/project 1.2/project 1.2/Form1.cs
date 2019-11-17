using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1._2
{
    public partial class Form1 : Form
    {
        // private string mstrClsTitle = "frmRexcel";
        int number;
        public Form1()
        {
            InitializeComponent();

            this.FormClosing += frmRexcel_FormClosing;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                textBox1.BackColor = Color.LightGray;
                textBox2.BackColor = Color.LightGray;

                MessageBox.Show("Invalid data");


                textBox1.Focus();
                textBox1.BackColor = Color.White;
                textBox2.Focus();
                textBox2.BackColor = Color.White;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {



           


            //code

            if (textBox1.Text == "FullName"   && textBox2.Text == "0333-XXXXXXX"  && textBox3.Text == "" && textBox4.Text == "")
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




                
            }






            else if (textBox1.Text != "FullName"  && textBox2.Text == "0333-XXXXXXX" && textBox3.Text == "" && textBox4.Text == "")
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

            else if (textBox1.Text != "FullName"  && textBox2.Text != "0333-XXXXXXX" && textBox3.Text == "" && textBox4.Text == "")
            {

                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "" && textBox4.Text == "") {

                    
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


            else if (textBox1.Text != "FullName" && textBox2.Text != "0333-XXXXXXX" && textBox3.Text != "" && textBox4.Text == "")
            {


                if (Int32.TryParse(textBox3.Text, out number))
                {
                    if (number >=120)
                    {

                        textBox3.BackColor = Color.Red;
                        textBox4.BackColor = Color.Red;
                        MessageBox.Show(this,
                                            "Invalid Data ,(Age less than 120)",
                                           "Exit",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox3.Focus();
                        textBox3.BackColor = Color.White;
                        textBox4.BackColor = Color.White;
                        textBox3.Clear();

                    }
                    else
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
                    }

                    // code
                }
                



               
                
            }

            else if (textBox1.Text != "FullName" && textBox2.Text != "0333-XXXXXXX" && textBox3.Text != "" && textBox4.Text != "")
            {

                if (Int32.TryParse(textBox3.Text, out number))
                {
                    if (number >= 120)
                    {

                        textBox3.BackColor = Color.Red;
                        MessageBox.Show(this,
                                            "Invalid Data ,(Age less than 120)",
                                           "Exit",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox3.Focus();
                        textBox3.BackColor = Color.White;
                        textBox3.Clear();
                    }
                    else
                    {

                        textBox1.Focus();
                        textBox1.BackColor = Color.White;
                        textBox2.BackColor = Color.White;
                        textBox3.BackColor = Color.White;
                        textBox4.BackColor = Color.White;
                        MessageBox.Show("OK! ");
                    }

                    // code
                }


             

            }



            else if (textBox1.Text != "FullName" && textBox2.Text == "0333-XXXXXXX" && textBox3.Text != "" && textBox4.Text == "")
            {





                if (Int32.TryParse(textBox3.Text, out number))
                {
                    if (number >= 120)
                    {

                        textBox3.BackColor = Color.Red;
                        textBox2.BackColor = Color.Red;
                        textBox4.BackColor = Color.Red;
                        MessageBox.Show(this,
                                            "Invalid Data ,(Age less than 120)",
                                           "Exit",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox3.Focus();
                        textBox3.BackColor = Color.White;
                        textBox2.BackColor = Color.White;
                        textBox4.BackColor = Color.White;
                        textBox3.Clear();
                    }
                    else
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
                    }

                    // code
                }


               

            }
            else if (textBox1.Text == "FullName" && textBox2.Text != "0333-XXXXXXX" && textBox3.Text == "" && textBox4.Text != "")
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
            else if (textBox1.Text != "FullName" && textBox2.Text == "0333-XXXXXXX" && textBox3.Text == "" && textBox4.Text != "")
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
            else if (textBox1.Text != "FullName" && textBox2.Text != "0333-XXXXXXX" && textBox3.Text == "" && textBox4.Text != "")
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
            else if (textBox1.Text != "FullName" && textBox2.Text == "0333-XXXXXXX" && textBox3.Text != "" && textBox4.Text != "")
            {

                if (Int32.TryParse(textBox3.Text, out number))
                {
                    if (number >= 120)
                    {

                        textBox3.BackColor = Color.Red;
                       
                        textBox2.BackColor = Color.Red;
                        MessageBox.Show(this,
                                            "Invalid Data ,(Age less than 120)",
                                           "Exit",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Focus();
                        
                        textBox2.BackColor = Color.White;
                        textBox3.BackColor = Color.White;
                        textBox3.Clear();
                    }
                    else
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
                    }

                    // code
                }


              

            }
            else if (textBox1.Text == "FullName" && textBox2.Text != "0333-XXXXXXX" && textBox3.Text != "" && textBox4.Text != "")
            {


                if (Int32.TryParse(textBox3.Text, out number))
                {
                    if (number >= 120)
                    {

                        textBox3.BackColor = Color.Red;
                        textBox1.BackColor = Color.Red;

                       // textBox2.BackColor = Color.Red;
                        MessageBox.Show(this,
                                            "Invalid Data ,(Age less than 120)",
                                           "Exit",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Focus();

                        textBox2.BackColor = Color.White;
                        textBox1.BackColor = Color.White;
                        textBox3.BackColor = Color.White;
                        textBox3.Clear();
                    }
                    else
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
                    }

                    // code
                }






            }
            else if (textBox1.Text == "FullName" && textBox2.Text == "0333-XXXXXXX" && textBox3.Text != "" && textBox4.Text != "")
            {


                if (Int32.TryParse(textBox3.Text, out number))
                {
                    if (number >= 120)
                    {

                        textBox1.BackColor = Color.Red;
                        textBox2.BackColor = Color.Red;
                        

                         textBox3.BackColor = Color.Red;
                        MessageBox.Show(this,
                                            "Invalid Data ,(Age less than 120)",
                                           "Exit",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Focus();

                        textBox1.BackColor = Color.White;
                        textBox2.BackColor = Color.White;
                        textBox3.BackColor = Color.White;

                       
                        textBox3.Clear();
                    }
                    else
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

                    }

                    // code
                }



            }
            else if (textBox1.Text == "FullName" && textBox2.Text != "" && textBox3.Text == "" && textBox4.Text == "")
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

            else if (textBox1.Text == "FullName"  && textBox2.Text == "0333-XXXXXXX"  && textBox3.Text != "" && textBox4.Text == "")
            {


                if (Int32.TryParse(textBox3.Text, out number))
                {
                    if (number >= 120)
                    {

                        textBox1.BackColor = Color.Red;
                        textBox2.BackColor = Color.Red;


                        textBox3.BackColor = Color.Red;
                        textBox4.BackColor = Color.Red;
                        MessageBox.Show(this,
                                            "Invalid Data ,(Age less than 120)",
                                           "Exit",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Focus();

                        textBox1.BackColor = Color.White;
                        textBox2.BackColor = Color.White;
                        textBox3.BackColor = Color.White;
                        textBox4.BackColor = Color.White;


                        textBox3.Clear();
                    }
                    else
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

                    // code
                }







               

            }
            else if (textBox1.Text == "FullName" && textBox2.Text == "0333-XXXXXXX" && textBox3.Text == "" && textBox4.Text != "")
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





        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {



            //start
            if (comboBox1.Text != "")
            {
                string sc = comboBox1.SelectedItem.ToString();

                listBox1.Items.Remove("");
                listBox1.Items.Add(comboBox1.SelectedItem);
                listBox1.Items.Remove("");
                // comboBox4.Items.Remove(comboBox4.SelectedItem);
                // comboBox1.Items.Remove(comboBox1.SelectedItem);
            }
            else if (comboBox1.Text == "")
            {

                MessageBox.Show("Select Medicine !");

            }

            //end

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            //st


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }



        //end

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

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

            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty && textBox3.Text == string.Empty  && textBox4.Text == string.Empty)

            {

                return true;

            }

            else

            {

                return false;

            }
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsWhiteSpace(e.KeyChar)) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && (!char.IsWhiteSpace(e.KeyChar)) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
                
            }

       


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (!char.IsLower(e.KeyChar) && !(e.KeyChar == 64)&& !(e.KeyChar == 46)))
            {
                e.Handled = true;

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

        private void Form1_Load(object sender, EventArgs e)

        {
            timer1.Start();
            label5.Text = DateTime.Now.ToLongTimeString();
            label6.Text = DateTime.Now.ToLongDateString();


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void frmRexcel_FormClosing(object sender, FormClosingEventArgs e)
        {

            
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            {

                
                switch (MessageBox.Show(this,
                                    "Are you sure you want to close the Application?",
                                   "Exit",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {

                    
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void errorProvider1_RightToLeftChanged(object sender, EventArgs e)
        {

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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "" )
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

       

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Remove(e);
            listBox1.Refresh();
            

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
           
        }
    }
}
    
