
namespace DB_Example
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtB_name_update = new System.Windows.Forms.TextBox();
            this.txtB_update_buy = new System.Windows.Forms.TextBox();
            this.txtB_update_sale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_sale = new System.Windows.Forms.TextBox();
            this.tB_buy = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 115);
            this.button1.TabIndex = 0;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(28, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 548);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtB_update_sale);
            this.groupBox2.Controls.Add(this.txtB_update_buy);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtB_name_update);
            this.groupBox2.Location = new System.Drawing.Point(482, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 548);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 115);
            this.button2.TabIndex = 0;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtB_name_update
            // 
            this.txtB_name_update.Location = new System.Drawing.Point(91, 58);
            this.txtB_name_update.Name = "txtB_name_update";
            this.txtB_name_update.Size = new System.Drawing.Size(185, 31);
            this.txtB_name_update.TabIndex = 1;
            // 
            // txtB_update_buy
            // 
            this.txtB_update_buy.Location = new System.Drawing.Point(91, 214);
            this.txtB_update_buy.Name = "txtB_update_buy";
            this.txtB_update_buy.Size = new System.Drawing.Size(185, 31);
            this.txtB_update_buy.TabIndex = 2;
            // 
            // txtB_update_sale
            // 
            this.txtB_update_sale.Location = new System.Drawing.Point(91, 144);
            this.txtB_update_sale.Name = "txtB_update_sale";
            this.txtB_update_sale.Size = new System.Drawing.Size(185, 31);
            this.txtB_update_sale.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "sale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "buy";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tB_sale);
            this.groupBox3.Controls.Add(this.tB_buy);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.tB_name);
            this.groupBox3.Location = new System.Drawing.Point(919, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 548);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insert";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "buy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "sale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "name";
            // 
            // tB_sale
            // 
            this.tB_sale.Location = new System.Drawing.Point(91, 144);
            this.tB_sale.Name = "tB_sale";
            this.tB_sale.Size = new System.Drawing.Size(185, 31);
            this.tB_sale.TabIndex = 3;
            // 
            // tB_buy
            // 
            this.tB_buy.Location = new System.Drawing.Point(91, 214);
            this.tB_buy.Name = "tB_buy";
            this.tB_buy.Size = new System.Drawing.Size(185, 31);
            this.tB_buy.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(91, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 115);
            this.button3.TabIndex = 0;
            this.button3.Text = "Insert";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tB_name
            // 
            this.tB_name.Location = new System.Drawing.Point(91, 58);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(185, 31);
            this.tB_name.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 33);
            this.comboBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1630, 741);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB_update_sale;
        private System.Windows.Forms.TextBox txtB_update_buy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtB_name_update;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tB_sale;
        private System.Windows.Forms.TextBox tB_buy;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

