using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sch_Click(object sender, EventArgs e)
        {
            Int32 year = 1;
            Int32[] startmoney = new Int32[21];
            Int32[] profit_bath = new Int32[21];
            Int32 profit_per = 1;
            Int32[] endyearmoney = new Int32[21];
            int countArr = 0;
            String strOutput = "";
            Int32 inputStartMoney = 0;
            int checkerr = 0;

            try
            {
                inputStartMoney = Convert.ToInt32(txt_money.Text);
            }
            catch (Exception)
            {
                checkerr = -1;
                MessageBox.Show("You must be enter right data , Error !!!");
            }

            if(checkerr == 0)
            {
                txtOutput.Text = "";
                strOutput = "";

                //for (year = 1; year <= 100; year++)
                //{
                //    textBox1.Text += "Year : " + year.ToString() + "\r\n";
                //}

                year = 1;
                while (year <= 10)
                {
                    profit_per = 5;
                    countArr = 0;
                    while (profit_per <= 50)
                    {
                        strOutput += "Year : " + year.ToString("N0");

                        if (year == 1)
                        {
                            startmoney[countArr] = inputStartMoney;
                        }

                        profit_bath[countArr] = (Int32)((decimal)(startmoney[countArr]) * (decimal)(profit_per) / (decimal)(100));
                        endyearmoney[countArr] = startmoney[countArr] + profit_bath[countArr];

                        strOutput += "[" +
                           " : startMonery = " + startmoney[countArr].ToString("N0") +
                           " : profit = " + profit_per.ToString("N0") + "%" + " (" + profit_bath[countArr].ToString("N0") + ") " +
                           " : endofMoney = " + endyearmoney[countArr].ToString("N0") + "]";

                        startmoney[countArr] = endyearmoney[countArr];
                        profit_per += 5;
                        countArr++;
                    }
                    strOutput += "\r\n";

                    year++;
                }
                txtOutput.Text = strOutput;
            }
        }

        private void txt_money_Enter(object sender, EventArgs e)
        {
            txt_money.SelectAll();
        }

        private void txt_month_Enter(object sender, EventArgs e)
        {
            txt_month.SelectAll();
        }

        private void txt_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
            {
                e.Handled = true;
                txt_month.Focus();
            }

            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txt_month_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                txt_money.Focus();
            }
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_money_Leave(object sender, EventArgs e)
        {
            Int32 input_money = 0; 
            try
            {
                input_money = Convert.ToInt32(txt_money.Text);
            }
            catch(Exception)
            {
                txt_money.Text = "";
            }
        }

        private void txt_month_Leave(object sender, EventArgs e)
        {
            Int32 input_month = 0;
            try
            {
                input_month = Convert.ToInt32(txt_month.Text);
            }
            catch (Exception)
            {
                txt_month.Text = "";
            }
        }
    }
}
