namespace Invest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_money = new System.Windows.Forms.TextBox();
            this.btn_sch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_month = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_out = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_money
            // 
            this.txt_money.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_money.Location = new System.Drawing.Point(99, 419);
            this.txt_money.Name = "txt_money";
            this.txt_money.Size = new System.Drawing.Size(178, 22);
            this.txt_money.TabIndex = 0;
            this.txt_money.Enter += new System.EventHandler(this.txt_money_Enter);
            this.txt_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_money_KeyPress);
            this.txt_money.Leave += new System.EventHandler(this.txt_money_Leave);
            // 
            // btn_sch
            // 
            this.btn_sch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_sch.Location = new System.Drawing.Point(1001, 419);
            this.btn_sch.Name = "btn_sch";
            this.btn_sch.Size = new System.Drawing.Size(75, 23);
            this.btn_sch.TabIndex = 2;
            this.btn_sch.Text = "&Search";
            this.btn_sch.UseVisualStyleBackColor = true;
            this.btn_sch.Click += new System.EventHandler(this.btn_sch_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Money";
            // 
            // txt_month
            // 
            this.txt_month.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_month.Location = new System.Drawing.Point(437, 419);
            this.txt_month.Name = "txt_month";
            this.txt_month.Size = new System.Drawing.Size(178, 22);
            this.txt_month.TabIndex = 1;
            this.txt_month.Enter += new System.EventHandler(this.txt_month_Enter);
            this.txt_month.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_month_KeyPress);
            this.txt_month.Leave += new System.EventHandler(this.txt_month_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Invest/Month";
            // 
            // lb_out
            // 
            this.lb_out.FormattingEnabled = true;
            this.lb_out.ItemHeight = 16;
            this.lb_out.Location = new System.Drawing.Point(515, 12);
            this.lb_out.Name = "lb_out";
            this.lb_out.Size = new System.Drawing.Size(561, 388);
            this.lb_out.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 450);
            this.Controls.Add(this.lb_out);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_month);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sch);
            this.Controls.Add(this.txt_money);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_money;
        private System.Windows.Forms.Button btn_sch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_month;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_out;
    }
}

