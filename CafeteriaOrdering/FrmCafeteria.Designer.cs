namespace CafeteriaOrdering
{
    partial class SelsCafeteria
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdoApp2 = new System.Windows.Forms.RadioButton();
            this.RdoApp1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RdoMain3 = new System.Windows.Forms.RadioButton();
            this.RdoMain2 = new System.Windows.Forms.RadioButton();
            this.RdoMain1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RdoDrink3 = new System.Windows.Forms.RadioButton();
            this.RdoDrink2 = new System.Windows.Forms.RadioButton();
            this.RdoDrink1 = new System.Windows.Forms.RadioButton();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnNewOrder = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TxtMain = new System.Windows.Forms.TextBox();
            this.TxtDrink = new System.Windows.Forms.TextBox();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.TxtTax = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtAppetizer = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appetizer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Main";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Drink";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subtotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tax (13%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdoApp2);
            this.groupBox1.Controls.Add(this.RdoApp1);
            this.groupBox1.Location = new System.Drawing.Point(389, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 190);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appetizers";
            // 
            // RdoApp2
            // 
            this.RdoApp2.AutoSize = true;
            this.RdoApp2.Location = new System.Drawing.Point(34, 119);
            this.RdoApp2.Name = "RdoApp2";
            this.RdoApp2.Size = new System.Drawing.Size(142, 29);
            this.RdoApp2.TabIndex = 1;
            this.RdoApp2.TabStop = true;
            this.RdoApp2.Text = "Salad $2.50";
            this.RdoApp2.UseVisualStyleBackColor = true;
            this.RdoApp2.CheckedChanged += new System.EventHandler(this.RdoApp2_CheckedChanged);
            // 
            // RdoApp1
            // 
            this.RdoApp1.AutoSize = true;
            this.RdoApp1.Location = new System.Drawing.Point(34, 57);
            this.RdoApp1.Name = "RdoApp1";
            this.RdoApp1.Size = new System.Drawing.Size(138, 29);
            this.RdoApp1.TabIndex = 0;
            this.RdoApp1.TabStop = true;
            this.RdoApp1.Text = "Soup $2.00";
            this.RdoApp1.UseVisualStyleBackColor = true;
            this.RdoApp1.CheckedChanged += new System.EventHandler(this.RdoApp1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdoMain3);
            this.groupBox2.Controls.Add(this.RdoMain2);
            this.groupBox2.Controls.Add(this.RdoMain1);
            this.groupBox2.Location = new System.Drawing.Point(737, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 190);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main Dishes";
            // 
            // RdoMain3
            // 
            this.RdoMain3.AutoSize = true;
            this.RdoMain3.Location = new System.Drawing.Point(26, 140);
            this.RdoMain3.Name = "RdoMain3";
            this.RdoMain3.Size = new System.Drawing.Size(153, 29);
            this.RdoMain3.TabIndex = 2;
            this.RdoMain3.TabStop = true;
            this.RdoMain3.Text = "Steak $15.00";
            this.RdoMain3.UseVisualStyleBackColor = true;
            this.RdoMain3.CheckedChanged += new System.EventHandler(this.RdoMain3_CheckedChanged);
            // 
            // RdoMain2
            // 
            this.RdoMain2.AutoSize = true;
            this.RdoMain2.Location = new System.Drawing.Point(26, 87);
            this.RdoMain2.Name = "RdoMain2";
            this.RdoMain2.Size = new System.Drawing.Size(178, 29);
            this.RdoMain2.TabIndex = 1;
            this.RdoMain2.TabStop = true;
            this.RdoMain2.Text = "Lasagna $11.75";
            this.RdoMain2.UseVisualStyleBackColor = true;
            this.RdoMain2.CheckedChanged += new System.EventHandler(this.RdoMain2_CheckedChanged);
            // 
            // RdoMain1
            // 
            this.RdoMain1.AutoSize = true;
            this.RdoMain1.Location = new System.Drawing.Point(26, 40);
            this.RdoMain1.Name = "RdoMain1";
            this.RdoMain1.Size = new System.Drawing.Size(174, 29);
            this.RdoMain1.TabIndex = 0;
            this.RdoMain1.TabStop = true;
            this.RdoMain1.Text = "Chicken $10.50";
            this.RdoMain1.UseVisualStyleBackColor = true;
            this.RdoMain1.CheckedChanged += new System.EventHandler(this.RdoMain1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RdoDrink3);
            this.groupBox3.Controls.Add(this.RdoDrink2);
            this.groupBox3.Controls.Add(this.RdoDrink1);
            this.groupBox3.Location = new System.Drawing.Point(532, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 207);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Drinks";
            // 
            // RdoDrink3
            // 
            this.RdoDrink3.AutoSize = true;
            this.RdoDrink3.Location = new System.Drawing.Point(22, 152);
            this.RdoDrink3.Name = "RdoDrink3";
            this.RdoDrink3.Size = new System.Drawing.Size(138, 29);
            this.RdoDrink3.TabIndex = 2;
            this.RdoDrink3.TabStop = true;
            this.RdoDrink3.Text = "Juice $1.30";
            this.RdoDrink3.UseVisualStyleBackColor = true;
            this.RdoDrink3.CheckedChanged += new System.EventHandler(this.RdoDrink3_CheckedChanged);
            // 
            // RdoDrink2
            // 
            this.RdoDrink2.AutoSize = true;
            this.RdoDrink2.Location = new System.Drawing.Point(22, 95);
            this.RdoDrink2.Name = "RdoDrink2";
            this.RdoDrink2.Size = new System.Drawing.Size(144, 29);
            this.RdoDrink2.TabIndex = 1;
            this.RdoDrink2.TabStop = true;
            this.RdoDrink2.Text = "Water $1.00";
            this.RdoDrink2.UseVisualStyleBackColor = true;
            this.RdoDrink2.CheckedChanged += new System.EventHandler(this.RdoDrink2_CheckedChanged);
            // 
            // RdoDrink1
            // 
            this.RdoDrink1.AutoSize = true;
            this.RdoDrink1.Location = new System.Drawing.Point(22, 44);
            this.RdoDrink1.Name = "RdoDrink1";
            this.RdoDrink1.Size = new System.Drawing.Size(138, 29);
            this.RdoDrink1.TabIndex = 0;
            this.RdoDrink1.TabStop = true;
            this.RdoDrink1.Text = "Soda $1.25";
            this.RdoDrink1.UseVisualStyleBackColor = true;
            this.RdoDrink1.CheckedChanged += new System.EventHandler(this.RdoDrink1_CheckedChanged);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(228, 545);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(185, 54);
            this.BtnCalculate.TabIndex = 9;
            this.BtnCalculate.Text = "Calculate Bill";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnNewOrder
            // 
            this.BtnNewOrder.Location = new System.Drawing.Point(489, 545);
            this.BtnNewOrder.Name = "BtnNewOrder";
            this.BtnNewOrder.Size = new System.Drawing.Size(195, 54);
            this.BtnNewOrder.TabIndex = 10;
            this.BtnNewOrder.Text = "New Order";
            this.BtnNewOrder.UseVisualStyleBackColor = true;
            this.BtnNewOrder.Click += new System.EventHandler(this.BtnNewOrder_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(763, 545);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(181, 54);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TxtMain
            // 
            this.TxtMain.Location = new System.Drawing.Point(171, 84);
            this.TxtMain.Name = "TxtMain";
            this.TxtMain.Size = new System.Drawing.Size(100, 29);
            this.TxtMain.TabIndex = 12;
            this.TxtMain.TextChanged += new System.EventHandler(this.TxtMain_TextChanged);
            // 
            // TxtDrink
            // 
            this.TxtDrink.Location = new System.Drawing.Point(171, 151);
            this.TxtDrink.Name = "TxtDrink";
            this.TxtDrink.Size = new System.Drawing.Size(100, 29);
            this.TxtDrink.TabIndex = 13;
            this.TxtDrink.TextChanged += new System.EventHandler(this.TxtDrink_TextChanged);
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Location = new System.Drawing.Point(171, 218);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(100, 29);
            this.TxtSubtotal.TabIndex = 14;
            this.TxtSubtotal.TextChanged += new System.EventHandler(this.TxtSubtotal_TextChanged);
            // 
            // TxtTax
            // 
            this.TxtTax.Location = new System.Drawing.Point(171, 276);
            this.TxtTax.Name = "TxtTax";
            this.TxtTax.Size = new System.Drawing.Size(100, 29);
            this.TxtTax.TabIndex = 15;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(171, 371);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 29);
            this.TxtTotal.TabIndex = 16;
            // 
            // TxtAppetizer
            // 
            this.TxtAppetizer.Location = new System.Drawing.Point(171, 28);
            this.TxtAppetizer.Name = "TxtAppetizer";
            this.TxtAppetizer.Size = new System.Drawing.Size(100, 29);
            this.TxtAppetizer.TabIndex = 17;
            this.TxtAppetizer.TextChanged += new System.EventHandler(this.TxtAppetizer_TextChanged);
            // 
            // SelsCafeteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 641);
            this.Controls.Add(this.TxtAppetizer);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtTax);
            this.Controls.Add(this.TxtSubtotal);
            this.Controls.Add(this.TxtDrink);
            this.Controls.Add(this.TxtMain);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnNewOrder);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SelsCafeteria";
            this.Text = "Sels Cafeteria";
            this.Load += new System.EventHandler(this.TxtAppetizer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdoApp2;
        private System.Windows.Forms.RadioButton RdoApp1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RdoMain3;
        private System.Windows.Forms.RadioButton RdoMain2;
        private System.Windows.Forms.RadioButton RdoMain1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RdoDrink3;
        private System.Windows.Forms.RadioButton RdoDrink2;
        private System.Windows.Forms.RadioButton RdoDrink1;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnNewOrder;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox TxtMain;
        private System.Windows.Forms.TextBox TxtDrink;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.TextBox TxtTax;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.TextBox TxtAppetizer;
    }
}

