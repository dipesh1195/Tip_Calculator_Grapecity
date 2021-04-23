
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Button1 = new System.Windows.Forms.Button();
            this.tippercentage = new System.Windows.Forms.NumericUpDown();
            this.no_of_people = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalperperson = new System.Windows.Forms.Label();
            this.tipperperson = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tippercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_of_people)).BeginInit();
            this.SuspendLayout();
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Location = new System.Drawing.Point(12, 12);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.Button1);
            this.SplitContainer1.Panel1.Controls.Add(this.tippercentage);
            this.SplitContainer1.Panel1.Controls.Add(this.no_of_people);
            this.SplitContainer1.Panel1.Controls.Add(this.label3);
            this.SplitContainer1.Panel1.Controls.Add(this.tip);
            this.SplitContainer1.Panel1.Controls.Add(this.amount);
            this.SplitContainer1.Panel1.Controls.Add(this.label1);
            this.SplitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel1_Paint);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.totalperperson);
            this.SplitContainer1.Panel2.Controls.Add(this.tipperperson);
            this.SplitContainer1.Panel2.Controls.Add(this.label5);
            this.SplitContainer1.Panel2.Controls.Add(this.label6);
            this.SplitContainer1.Panel2.Controls.Add(this.label4);
            this.SplitContainer1.Panel2.Controls.Add(this.label2);
            this.SplitContainer1.Panel2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SplitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel2_Paint);
            this.SplitContainer1.Size = new System.Drawing.Size(765, 436);
            this.SplitContainer1.SplitterDistance = 255;
            this.SplitContainer1.TabIndex = 6;
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button1.Location = new System.Drawing.Point(29, 260);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(193, 56);
            this.Button1.TabIndex = 13;
            this.Button1.Text = "Calculate";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tippercentage
            // 
            this.tippercentage.Location = new System.Drawing.Point(29, 113);
            this.tippercentage.Name = "tippercentage";
            this.tippercentage.Size = new System.Drawing.Size(150, 27);
            this.tippercentage.TabIndex = 12;
            // 
            // no_of_people
            // 
            this.no_of_people.Location = new System.Drawing.Point(29, 184);
            this.no_of_people.Name = "no_of_people";
            this.no_of_people.Size = new System.Drawing.Size(150, 27);
            this.no_of_people.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(29, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number Of People";
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tip.Location = new System.Drawing.Point(29, 90);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(46, 20);
            this.tip.TabIndex = 8;
            this.tip.Text = "Tip %";
            // 
            // amount
            // 
            this.amount.Cursor = System.Windows.Forms.Cursors.Default;
            this.amount.Location = new System.Drawing.Point(29, 48);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(125, 27);
            this.amount.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "BIll Amount";
            // 
            // totalperperson
            // 
            this.totalperperson.AutoSize = true;
            this.totalperperson.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalperperson.Location = new System.Drawing.Point(238, 228);
            this.totalperperson.Name = "totalperperson";
            this.totalperperson.Size = new System.Drawing.Size(59, 40);
            this.totalperperson.TabIndex = 4;
            this.totalperperson.Text = "$ 0";
            this.totalperperson.Click += new System.EventHandler(this.Label8_Click);
            // 
            // tipperperson
            // 
            this.tipperperson.AutoSize = true;
            this.tipperperson.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tipperperson.Location = new System.Drawing.Point(238, 147);
            this.tipperperson.Name = "tipperperson";
            this.tipperperson.Size = new System.Drawing.Size(54, 37);
            this.tipperperson.TabIndex = 4;
            this.tipperperson.Text = "$ 0";
            this.tipperperson.Click += new System.EventHandler(this.Label7_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(52, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "per person";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(52, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "per person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 455);
            this.Controls.Add(this.SplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bill Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tippercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_of_people)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tippercentage;
        private System.Windows.Forms.NumericUpDown no_of_people;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalperperson;
        private System.Windows.Forms.Label tipperperson;
        private System.Windows.Forms.Button Button1;
    }
}

