using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfNov6th
{
    public partial class Form1 : Form
    {
        double celsius = 1;
        double fahrenheit = 1;
        int SelectedIndex0 = 0;
        int SelectedIndex1 = 1;
        int SelectedIndex2 = 2;
        int SelectedIndex3 = 3;
        int SelectedIndex4 = 4;
        int SelectedIndex5 = 5;
        int SelectedIndex6 = 6;
        int SelectedIndex7 = 7;
        int SelectedIndex8 = 8;
        int SelectedIndex9 = 9;
        double dollar = 1;
        double yen = 1;
        double euro = 1;
        double canadian = 1;
        double pound = 1;
        double aussie = 1;
        double miles = 1;
        double kilos = 1;
        double meters = 1;
        double inches = 1;
        int testNumber = 1;
        int alphabetLength = 0;
        string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O",
            "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        bool done = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Temp_Click(object sender, EventArgs e)
        {
            if (rdoTempConverter1.Checked)
            {
                if(txtInput1.Text != "")
                {
                    celsius = Convert.ToDouble(txtInput1.Text);
                    rtbOutput.Text += "\n" + ((celsius * 9 / 5) + 32);
                }
                
                if (txtInput2.Text != "")
                { 
                    celsius = Convert.ToDouble(txtInput2.Text);
                    rtbOutput.Text += "\n" + ((celsius * 9/5) + 32);
                }
            }
            
            else if (rdoTempConverter2.Checked)
            {
                if (txtInput1.Text != "")
                {
                    fahrenheit = Convert.ToDouble(txtInput1.Text);
                    rtbOutput.Text += "\n" + ((fahrenheit - 32) * 5/9);
                }
                if (txtInput1.Text != "")
                {
                     fahrenheit = Convert.ToDouble(txtInput2.Text);
                     rtbOutput.Text += "\n" + ((fahrenheit - 32) * 5/9);
                }
            }
            
        }

        private void btn_Money_Click(object sender, EventArgs e)
        {
            if (cmbMoneyConverter.SelectedIndex == 0)
            {
                if(txtInput1.Text != "")
                {
                    yen = Convert.ToDouble(txtInput1.Text);
                    rtbOutput.Text += "\n" + (yen * 149.79);
                }
                if (txtInput2.Text != "")
                {
                     yen = Convert.ToDouble(txtInput2.Text);
                     rtbOutput.Text += "\n" + (yen * 149.79);
                }
            }
            else if (cmbMoneyConverter.SelectedIndex == 1)
            {
                if (txtInput1.Text != "")
                {
                    dollar = Convert.ToDouble(txtInput1.Text);
                    rtbOutput.Text += "\n" + (dollar * 0.0067);
                }
                if (txtInput2.Text != "")
                {
                    dollar = Convert.ToDouble(txtInput2.Text);
                    rtbOutput.Text += "\n" + (dollar * 0.0067);
                }
               
            }
            else if (cmbMoneyConverter.SelectedIndex == 2)
            {
                if (txtInput1.Text != "")
                {
                    euro = Convert.ToDouble(txtInput1.Text);
                    rtbOutput.Text += "\n" + (euro * 0.93);
                }
                if (txtInput2.Text != "")
                {
                    euro = Convert.ToDouble(txtInput2.Text);
                    rtbOutput.Text += "\n" + (euro * 0.93);
                }
                
            }
            else if (cmbMoneyConverter.SelectedIndex == 3)
            {
                if (txtInput1.Text != "")
                {
                    dollar = Convert.ToDouble(txtInput1.Text);
                    rtbOutput.Text += "\n" + (dollar * 1.07);
                }
                if (txtInput2.Text != "")
                {
                    dollar = Convert.ToDouble(txtInput2.Text);
                    rtbOutput.Text += "\n" + (dollar * 1.07);
                }
                
            }
            else if (cmbMoneyConverter.SelectedIndex == 4)
            {
                if (txtInput1.Text != "")
                {
                    canadian = Convert.ToDouble(txtInput1.Text);
                    rtbOutput.Text += "\n" + (canadian * 0.73);
                }
                if (txtInput2.Text != "")
                {
                    canadian = Convert.ToDouble(txtInput2.Text);
                    rtbOutput.Text += "\n" + (canadian * 0.73);
                }
                
            }
            else if (cmbMoneyConverter.SelectedIndex == 5)
            {
                if (txtInput1.Text != "")
                {
                    dollar = Convert.ToDouble(txtInput1.Text);
                    rtbOutput.Text += "\n" + (dollar * 1.37);
                }
                if (txtInput2.Text != "")
                {
                    dollar = Convert.ToDouble(txtInput2.Text);
                    rtbOutput.Text += "\n" + (dollar * 1.37);
                }
                
            }
            else if (cmbMoneyConverter.SelectedIndex == 6)
            {
                if (txtInput1.Text != "")
                {
                    pound = Convert.ToDouble(txtInput1.Text);
                    rtbOutput.Text += "\n" + (pound * 1.24);
                }
                if (txtInput2.Text != "")
                {
                    pound = Convert.ToDouble(txtInput2.Text);
                    rtbOutput.Text += "\n" + (pound * 1.24);
                }
                
            }
            else if (cmbMoneyConverter.SelectedIndex == 7)
            {
                if (txtInput1.Text != "")
                {
                    dollar = Convert.ToDouble(txtInput1.Text);
                    rtbOutput.Text += "\n" + (dollar * 0.81);
                }
                if (txtInput2.Text != "")
                {
                    dollar = Convert.ToDouble(txtInput2.Text);
                    rtbOutput.Text += "\n" + (dollar * 0.81);
                }
                
            }
            else if (cmbMoneyConverter.SelectedIndex == 8)
            {
                if (txtInput1.Text != "")
                { 
                    aussie = Convert.ToDouble(txtInput1.Text);
                    rtbOutput.Text += "\n" + (aussie * 0.65);
                }
                if (txtInput2.Text != "")
                { 
                    aussie = Convert.ToDouble(txtInput2.Text);
                    rtbOutput.Text += "\n" + (aussie * 0.65);
                }
            }
            else if (cmbMoneyConverter.SelectedIndex == 9)
            {
                if (txtInput1.Text != "")
                {
                    dollar = Convert.ToDouble(txtInput1.Text);
                    rtbOutput.Text += "\n" + (dollar * 1.54);
                }
                if (txtInput2.Text != "")
                {
                    dollar = Convert.ToDouble(txtInput2.Text);
                    rtbOutput.Text += "\n" + (dollar * 1.54);
                }
                
            }

        }

        private void btn_Distance_Click(object sender, EventArgs e)
        {
            if (chkMileToKilo.Checked)
            {
                miles = Convert.ToDouble(txtInput1.Text);
                rtbOutput.Text += "\n" + (miles * 1.60934);
            }
            if (chkMeterToInch.Checked)
            {
                meters = Convert.ToDouble(txtInput1.Text);
                rtbOutput.Text += "\n" + (meters * 0.0254);
            }
        }

        private void btn_ConvertDistance2_Click(object sender, EventArgs e)
        {
            if (chkKiloToMiles.Checked)
            {
                kilos = Convert.ToDouble(txtInput1.Text);
                rtbOutput.Text += "\n" + (kilos * 0.621371);
            }
            if (chkInchToMeter.Checked)
            {
                inches = Convert.ToDouble(txtInput1.Text);
                rtbOutput.Text += "\n" + (inches * 39.3701);
            }
        }

        private void cmbMoneyConverter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtInput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInput2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoTempConverter1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoTempConverter2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_TextInput_Click(object sender, EventArgs e)
        {
            rtbOutput.LoadFile("C:/Users/lemonade/source/repos/weekOfNovember6/weekOfNovember6/bin/test.txt", RichTextBoxStreamType.PlainText);
        }

        private void btn_TxtFunction_Click(object sender, EventArgs e)
        {
            testNumber = Convert.ToInt32(txtInput1.Text);
            /*string function = "C:/Users/lemonade/source/repos/weekOfNovember6/weekOfNovember6/bin/test.txt";
            string rep1 = function.Replace(' ');
            rtbOutput.Text = rep1;*/
        }

        private void btn_Alphabet_Click(object sender, EventArgs e)
        {
            while(!done)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    rtbOutput.Text = alphabet[alphabetLength];
                    alphabetLength++;  
                }
            }
            
        }
    }
}
