using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtLatte_Click(object sender, EventArgs e)
        {
            txtLatte.Text = "";
            txtLatte.Focus();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLatte.Checked == true)
            {

                txtLatte.Enabled = true;
            }
            if(chkLatte.Checked == false){
                txtLatte.Text = "0";
                txtLatte.Enabled = false;
              
            }
        }




        private void chkCappucciono_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkIcedLatte.Checked == true)
            {

                txtIcedLatte.Enabled = true;
            }
            if (chkIcedLatte.Checked == false)
            {

                txtIcedLatte.Enabled = false;
                txtIcedLatte.Text = "0";
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVelvet.Checked == true)
            {

                txtVelvet.Enabled = true;
            }
            if (chkVelvet.Checked == false)
            {

                txtVelvet.Enabled = false;
                txtVelvet.Text = "0";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAfrican.Text = "0";
            txtAmerican.Text = "0";
            txtBlack.Text = "0";
            txtBoston.Text = "0";
            txtCapuccino.Text = "0";
            txtCoffee.Text = "0";
            txtMarrito.Text = "0";
            txtLatte.Text = "0";
            txtEspresso.Text = "0";
            txtCreamy.Text = "0";
            txtSpecial.Text = "0";
            txtLagos.Text = "0";
            txtVelvet.Text = "0";
            txtVale.Text = "0";
            txtIcedCapuccino.Text = "0";
            txtIcedLatte.Text = "0";
           
            lblService.Text = "1.75";
            lblTax.Text = "0";
            lblCakeT.Text = "0";
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            Timer1.Start();


            txtAfrican.Text = "0";
            txtAmerican.Text = "0";
            txtBlack.Text = "0";
            txtBoston.Text = "0";
            txtCapuccino.Text = "0";
            txtCoffee.Text = "0";
            txtMarrito.Text = "0";
            txtLatte.Text = "0";
            txtEspresso.Text = "0";
            txtCreamy.Text = "0";
            txtSpecial.Text = "0";
            txtLagos.Text = "0";
            txtVelvet.Text = "0";
            txtVale.Text = "0";
            txtIcedCapuccino.Text = "0";
            txtIcedLatte.Text = "0";

            lblService.Text = "1.75";
            lblTax.Text = "0";
            lblCakeT.Text = "0";

            txtLatte.Enabled = false;
            txtEspresso.Enabled = false;
            txtIcedLatte.Enabled = false;
            txtVale.Enabled = false;
            txtCreamy.Enabled = false;
         
            txtCapuccino.Enabled = false;
            txtAfrican.Enabled = false;
            txtAmerican.Enabled = false;
            txtBoston.Enabled = false;
            txtIcedCapuccino.Enabled = false;
            txtCoffee.Enabled = false;
       
            txtVelvet.Enabled = false;
            txtBlack.Enabled = false;
            txtLagos.Enabled = false;
            txtSpecial.Enabled = false;
            txtCreamy.Enabled = false;
            txtMarrito.Enabled = false;
           
            txtBlack.Enabled = false;



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEspresso.Checked == true)
            {

                txtEspresso.Enabled = true;
            }
            if (chkEspresso.Checked == false)
            {

                txtEspresso.Enabled = false;
                txtEspresso.Text = "0";
            }
        }

        private void txtEspresso_Click(object sender, EventArgs e)
        {
            txtEspresso.Text = "";
            txtEspresso.Focus();
          
        }

        private void chkValeCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVale.Checked == true)
            {

                txtVale.Enabled = true;
            }
            if (chkVale.Checked == false)
            {
                txtVale.Text = "0";
                txtVale.Enabled = false;
              
            }
        }

        private void txtIcedLatte_Click(object sender, EventArgs e)
        {
            txtIcedLatte.Text = "";
            txtIcedLatte.Focus();
        }

        private void chkCapuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCapuccino.Checked == true)
            {

                txtCapuccino.Enabled = true;
            }
            if (chkCapuccino.Checked == false)
            {

                txtCapuccino.Enabled = false;
                txtCapuccino.Text = "0";
            }
        }

        private void txtCapuccino_Click(object sender, EventArgs e)
        {
            txtCapuccino.Text = "";
            txtCapuccino.Focus();
        }

        private void chkAfricanCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAfrican.Checked == true)
            {

                txtAfrican.Enabled = true;
            }
            if (chkAfrican.Checked == false)
            {

                txtAfrican.Enabled = false;
                txtAfrican.Text = "0";
            }
        }

        private void chkAmericanCoffe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAmerican.Checked == true)
            {

                txtAmerican.Enabled = true;
            }
            if (chkAmerican.Checked == false)
            {

                txtAmerican.Enabled = false;
                txtAmerican.Text = "0";
            }
        }

        private void chkIcedCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIcedCapuccino.Checked == true)
            {

                txtIcedCapuccino.Enabled = true;
            }
            if (chkIcedCapuccino.Checked == false)
            {

                txtIcedCapuccino.Enabled = false;
                txtIcedCapuccino.Text = "0";
            }
        }

        private void chkCofee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoffee.Checked == true)
            {

                txtCoffee.Enabled = true;
            }
            if (chkCoffee.Checked == false)
            {

                txtCoffee.Enabled = false;
                txtCoffee.Text = "0";
            }
        }

        private void txtVelvet_Click(object sender, EventArgs e)
        {
            txtVelvet.Text ="";
            txtVelvet.Focus();
                
        }

        private void chkMarrito_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMarrito.Checked == true)
            {

                txtMarrito.Enabled = true;
            }
            if (chkMarrito.Checked == false)
            {

                txtMarrito.Enabled = false;
                txtMarrito.Text = "0";
            }
        }

        private void txtMarrito_Click(object sender, EventArgs e)
        {
            txtMarrito.Text = "";
            txtMarrito.Focus();
        }

        private void chkCreamy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCreamy.Checked == true)
            {

                txtCreamy.Enabled = true;
            }
            if (chkCreamy.Checked == false)
            {

                txtCreamy.Enabled = false;
                txtCreamy.Text = "0";
            }
        }

        private void txtCreamy_Click(object sender, EventArgs e)
        {
            txtCreamy.Text = "";
            txtCreamy.Focus();
        }

        private void txtCoffee_Click(object sender, EventArgs e)
        {
            txtCoffee.Text = "";
            txtCoffee.Focus();

        }

        private void chkSpecial_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpecial.Checked == true)
            {

                txtSpecial.Enabled = true;
            }
            if (chkSpecial.Checked == false)
            {

                txtSpecial.Enabled = false;
                txtSpecial.Text = "0";
            }
        }

        private void txtSpecial_Click(object sender, EventArgs e)
        {
            txtSpecial.Text = "";
            txtSpecial.Focus();
        }

        private void chkLagos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLagos.Checked == true)
            {

                txtLagos.Enabled = true;
            }
            if (chkLagos.Checked == false)
            {

                txtLagos.Enabled = false;
                txtLagos.Text = "0";
            }
        }

        private void txtLagos_Click(object sender, EventArgs e)
        {
            txtLagos.Text = "";
            txtLagos.Focus();
        }

        private void chkBoston_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoston.Checked == true)
            {

                txtBoston.Enabled = true;
            }
            if (chkBoston.Checked == false)
            {

                txtBoston.Enabled = false;
                txtBoston.Text = "0";
            }
        }

        private void chkBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlack.Checked == true)
            {

                txtBlack.Enabled = true;
            }
            if (chkBlack.Checked == false)
            {

                txtBlack.Enabled = false;
                txtBlack.Text = "0";
            }
        }

        private void txtBlack_Click(object sender, EventArgs e)
        {
            txtBlack.Text = "";
            txtBlack.Focus();

        }

        private void txtBoston_Click(object sender, EventArgs e)
        {
            txtBoston.Text = "";
            txtBoston.Focus();
        }

        private void txtIcedCapuccino_Click(object sender, EventArgs e)
        {
            txtIcedCapuccino.Text = "";
            txtIcedCapuccino.Focus();
        }

        private void txtAmerican_Click(object sender, EventArgs e)
        {
            txtAmerican.Text = "";
            txtAmerican.Focus();
        }

        private void txtAfrican_Click(object sender, EventArgs e)
        {
            txtAfrican.Text = "";
            txtAfrican.Focus();
        }

        private void lblCakeT_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

          
        }

        private void txtLatte_Click_1(object sender, EventArgs e)
        {
            txtLatte.Text = "";
            txtLatte.Focus();

        }
        
        private void txtVale_Click(object sender, EventArgs e)
        {
            txtVale.Text = "";
            txtVale.Focus();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {

            rtfReceipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {

            rtfReceipt.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            //this code will open Text File

            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files(*.txt)|*,txt|All files (*.*)|*.*";
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)rtfReceipt.LoadFile(openFile.FileName,RichTextBoxStreamType.PlainText);
                

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Notepad Text";

            saveFile.Filter = "Text Files(*.txt)|*,txt|All files (*.*)|*.*";
            
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtfReceipt.Text);

            }


        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();

            rtfReceipt.AppendText(Environment.NewLine);
            rtfReceipt.AppendText("------------------------------------------------"+Environment.NewLine);
            rtfReceipt.AppendText("\t"+"Varanasi Cafe Store" + Environment.NewLine);
            rtfReceipt.AppendText("------------------------------------------------" + Environment.NewLine + Environment.NewLine);

            rtfReceipt.AppendText("Latte \t\t\t\t" + txtLatte.Text + Environment.NewLine);
            rtfReceipt.AppendText("Espresso \t\t\t" + txtEspresso.Text + Environment.NewLine);
            rtfReceipt.AppendText("Iced Latte \t\t\t" + txtIcedLatte.Text + Environment.NewLine);
            rtfReceipt.AppendText("Vale Coffe \t\t\t" + txtVale.Text + Environment.NewLine);
            rtfReceipt.AppendText("Capuccino \t\t\t" + txtCapuccino.Text + Environment.NewLine);
            rtfReceipt.AppendText("African Coffee \t\t\t" + txtAfrican.Text + Environment.NewLine);
            rtfReceipt.AppendText("American Coffee \t\t" + txtAmerican.Text + Environment.NewLine);
            rtfReceipt.AppendText("Iced-Capuccino \t\t" + txtIcedCapuccino.Text + Environment.NewLine);
            rtfReceipt.AppendText("Coffee Cake \t\t\t" + txtCoffee.Text + Environment.NewLine);
            rtfReceipt.AppendText("Red Velvet Cake \t\t" + txtVelvet.Text + Environment.NewLine);
            rtfReceipt.AppendText("Black Forest Cake \t\t" + txtBlack.Text + Environment.NewLine);
            rtfReceipt.AppendText("Boston Cake \t\t\t" + txtBoston.Text + Environment.NewLine);
            rtfReceipt.AppendText("Lagos Choclate Cake \t\t" + txtLagos.Text + Environment.NewLine);
            rtfReceipt.AppendText("Special Chocolate Cake \t" + txtSpecial.Text + Environment.NewLine);
            rtfReceipt.AppendText("Creamy Cake Cold \t\t" + txtCreamy.Text + Environment.NewLine);
            rtfReceipt.AppendText("Marrito Cake Cold \t\t" + txtMarrito.Text + Environment.NewLine);

            rtfReceipt.AppendText("---------------------------------------------------" + Environment.NewLine);

            rtfReceipt.AppendText("Tax : \t\t\t\t" + lblTax.Text + Environment.NewLine);
            rtfReceipt.AppendText("Service Charge \t\t" + lblService.Text + Environment.NewLine);
            rtfReceipt.AppendText("Sub Total Cost :\t\t"  + lblSub.Text + Environment.NewLine);
            rtfReceipt.AppendText("---------------------------------------------------"  + Environment.NewLine);
            rtfReceipt.AppendText("TOTAL Cost : \t\t" + lblTotal.Text + Environment.NewLine);
          
            rtfReceipt.AppendText("---------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText(lblTime.Text+ "\t\t" + lblDate.Text );













                 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double latte, ilatte, espresso, vale, capuccino, icapuccino, aCoffee, AmCoffee;
            double cCake, RCake, BlCake, BSCake, LagosCake, SpCake, CreamyCake, MarritoCake;
            double tax;


            // the proice is in dollar as foreigners mostky visit with Dollar in Varanasi 
            latte = 1.30; espresso = 1.40; ilatte = 1.50; vale = 2.10; capuccino = 2.0; icapuccino = 2.10; aCoffee = 1.20; AmCoffee = 1.30; 
           

            double latte_Coffee = Convert.ToDouble(txtLatte.Text);
            double espresso_Coffee = Convert.ToDouble(txtEspresso.Text) ;
            double ilatte_Coffee = Convert.ToDouble(txtIcedLatte.Text);
            double vale_Coffee = Convert.ToDouble(txtVale.Text) * vale;
            double capuccino_Coffee = Convert.ToDouble(txtCapuccino.Text) ;
            double icapuccino_Coffee = Convert.ToDouble(txtIcedCapuccino.Text);
            double aCoffee_Coffee = Convert.ToDouble(txtAfrican.Text);
            double AmCoffee_Coffee = Convert.ToDouble(txtAmerican.Text);


            //cake from here : - 
            cCake = 2.39; RCake = 2.20; BlCake = 3.00; BSCake = 3.30; LagosCake = 4.00; SpCake = 3.40; CreamyCake = 4.10; MarritoCake = 5.00; 

            double cCake_Cake = Convert.ToDouble(txtCoffee.Text) ;
            double RCake_Cake = Convert.ToDouble(txtVelvet.Text) ;
            double BlCake_Cake = Convert.ToDouble(txtBlack.Text) ;
            double BSCake_Cake = Convert.ToDouble(txtBoston.Text) ;
            double LagosCake_Cake = Convert.ToDouble(txtLagos.Text) ;
            double SpCake_Cake = Convert.ToDouble(txtSpecial.Text);
            double CreamyCake_Cake = Convert.ToDouble(txtCreamy.Text) ;
            double MarritoCake_Cake = Convert.ToDouble(txtMarrito.Text) ;


            Cafe eat_in_Cafev = new Cafe(latte_Coffee, espresso_Coffee, ilatte_Coffee, vale_Coffee, capuccino_Coffee, icapuccino_Coffee, aCoffee_Coffee,
                AmCoffee_Coffee, cCake_Cake, RCake_Cake, BlCake_Cake, BSCake_Cake, LagosCake_Cake, SpCake_Cake, CreamyCake_Cake, MarritoCake_Cake );

            double Cost_Of_Drink = (latte_Coffee * latte) + (espresso_Coffee *  espresso  ) + (ilatte_Coffee * ilatte ) + ( vale_Coffee * vale) + ( capuccino_Coffee *capuccino )
                +( icapuccino_Coffee * icapuccino ) + (aCoffee_Coffee * aCoffee) + (AmCoffee_Coffee * AmCoffee) ;
            lblSoft.Text = Convert.ToString(Cost_Of_Drink);
            double Cost_of_Cake = (cCake_Cake *cCake)+ (RCake_Cake*RCake)+ ( BlCake_Cake * BlCake) + ( BSCake_Cake *  BSCake) + (LagosCake_Cake * LagosCake) + (SpCake_Cake* SpCake)
                +  (CreamyCake_Cake * CreamyCake) +  (MarritoCake_Cake  * MarritoCake);
            lblCakeT.Text = Convert.ToString(Cost_of_Cake);

            double service_charge = Convert.ToDouble(lblService.Text);

            tax = Convert.ToDouble((Cost_Of_Drink + Cost_of_Cake)* 10/100);
            lblSub.Text = Convert.ToString(Cost_Of_Drink + Cost_of_Cake + service_charge);
            lblTax.Text = Convert.ToString(((Cost_Of_Drink + Cost_of_Cake + service_charge) + tax) /100);
            double iTax = Convert.ToDouble(lblTax.Text);
            lblTotal.Text = Convert.ToString(Cost_Of_Drink + Cost_of_Cake + iTax + service_charge);



           



        }

      
    }
}
