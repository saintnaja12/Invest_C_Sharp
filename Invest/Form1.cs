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
                DateTime starttime = System.DateTime.Now;

                //txtOutput.Text = "";
                lb_out.BeginUpdate();
                lb_out.Items.Clear();

                List<string> listOut = new List<string>();

                strOutput = "";

                //for (year = 1; year <= 100; year++)
                //{
                //    textBox1.Text += "Year : " + year.ToString() + "\r\n";
                //}

                year = 1;
                while (year <= 10)
                {
                    strOutput = "";
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

                    lb_out.Items.Add(strOutput);
                    //listOut.Add(strOutput);
                }
                //txtOutput.Text = strOutput;
                //lb_out.DataSource = listOut;
                lb_out.EndUpdate();

                DateTime endtime = System.DateTime.Now;
                System.TimeSpan usedtime = endtime - starttime;
                //MessageBox.Show("Used time = " + usedtime.TotalSeconds.ToString() + " sec.");
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

        private void lb_out_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 3) //Ctrl + C
            {
                copyclick();
            }
            else if(e.KeyChar == 1) //Ctrl + A
            {
                selectallrow();
            }
        }

        private void copyclick()
        {
            //String copytext = ""
            StringBuilder copytext = new StringBuilder("");

            foreach(object datarow in lb_out.SelectedItems)
            {
                copytext.Append(datarow.ToString());
                //copytext.Append("\r\n"); ใช้ Lenhth-2
                copytext.AppendLine();
            }
            copytext.Remove(copytext.Length-1, 1);
            Clipboard.SetText(copytext.ToString());
        }

        private void selectallrow()
        {
            lb_out.BeginUpdate();
            for(int i = 0; i < lb_out.Items.Count; i++)
            {
                lb_out.SetSelected(i, true);
            }
            lb_out.EndUpdate();
            /*int i = 0;
            while(i < lb_out.Items.Count)
            {
                i++;
            }*/
        }

        private void ctCopy_Click(object sender, EventArgs e)
        {
            copyclick();
        }

        private void ctSelectAll_Click(object sender, EventArgs e)
        {
            selectallrow();
        }
    }
}
