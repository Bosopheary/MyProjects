namespace CaffeeShope
{
    partial class Cashierform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashierform));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btclose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btoder = new System.Windows.Forms.Button();
            this.btcustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btproduct = new System.Windows.Forms.Button();
            this.btdasboad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btlogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customeradddata1 = new CaffeeShope.Customeradddata();
            this.cashierOrderform1 = new CaffeeShope.CashierOrderform();
            this.adminAddProduct2 = new CaffeeShope.AdminAddProduct();
            this.adminAddProduct1 = new CaffeeShope.AdminAddProduct();
            this.adminDasshbord1 = new CaffeeShope.AdminDasshbord();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btclose);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(1, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1552, 59);
            this.panel3.TabIndex = 3;
            // 
            // btclose
            // 
            this.btclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btclose.Location = new System.Drawing.Point(1502, 5);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(39, 40);
            this.btclose.TabIndex = 2;
            this.btclose.Text = "X";
            this.btclose.UseVisualStyleBackColor = true;
            this.btclose.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "COFFEE SHOP MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.btoder);
            this.panel1.Controls.Add(this.btcustomer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btproduct);
            this.panel1.Controls.Add(this.btdasboad);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btlogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 710);
            this.panel1.TabIndex = 4;
            // 
            // btoder
            // 
            this.btoder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btoder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btoder.Location = new System.Drawing.Point(54, 400);
            this.btoder.Name = "btoder";
            this.btoder.Size = new System.Drawing.Size(210, 58);
            this.btoder.TabIndex = 7;
            this.btoder.Text = "Orders";
            this.btoder.UseVisualStyleBackColor = false;
            this.btoder.Click += new System.EventHandler(this.btoder_Click);
            // 
            // btcustomer
            // 
            this.btcustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btcustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btcustomer.Location = new System.Drawing.Point(56, 502);
            this.btcustomer.Name = "btcustomer";
            this.btcustomer.Size = new System.Drawing.Size(210, 54);
            this.btcustomer.TabIndex = 5;
            this.btcustomer.Text = "Customers";
            this.btcustomer.UseVisualStyleBackColor = false;
            this.btcustomer.Click += new System.EventHandler(this.btcustomer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(11, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username :   Admin";
            // 
            // btproduct
            // 
            this.btproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btproduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btproduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btproduct.Location = new System.Drawing.Point(56, 320);
            this.btproduct.Name = "btproduct";
            this.btproduct.Size = new System.Drawing.Size(210, 58);
            this.btproduct.TabIndex = 4;
            this.btproduct.Text = "Add Products ";
            this.btproduct.UseVisualStyleBackColor = false;
            this.btproduct.Click += new System.EventHandler(this.btproduct_Click);
            // 
            // btdasboad
            // 
            this.btdasboad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btdasboad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdasboad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btdasboad.Location = new System.Drawing.Point(54, 252);
            this.btdasboad.Name = "btdasboad";
            this.btdasboad.Size = new System.Drawing.Size(212, 56);
            this.btdasboad.TabIndex = 3;
            this.btdasboad.Text = "Dashboard";
            this.btdasboad.UseVisualStyleBackColor = false;
            this.btdasboad.Click += new System.EventHandler(this.btdasboad_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btlogout
            // 
            this.btlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btlogout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btlogout.Location = new System.Drawing.Point(54, 655);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(212, 52);
            this.btlogout.TabIndex = 2;
            this.btlogout.Text = "LOGOUT";
            this.btlogout.UseVisualStyleBackColor = false;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(72, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cashier\'sPortal ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.customeradddata1);
            this.panel2.Controls.Add(this.cashierOrderform1);
            this.panel2.Controls.Add(this.adminAddProduct2);
            this.panel2.Controls.Add(this.adminAddProduct1);
            this.panel2.Controls.Add(this.adminDasshbord1);
            this.panel2.Location = new System.Drawing.Point(356, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1197, 710);
            this.panel2.TabIndex = 5;
            // 
            // customeradddata1
            // 
            this.customeradddata1.Location = new System.Drawing.Point(4, 3);
            this.customeradddata1.Name = "customeradddata1";
            this.customeradddata1.Size = new System.Drawing.Size(1197, 710);
            this.customeradddata1.TabIndex = 4;
            // 
            // cashierOrderform1
            // 
            this.cashierOrderform1.Location = new System.Drawing.Point(3, 3);
            this.cashierOrderform1.Name = "cashierOrderform1";
            this.cashierOrderform1.Size = new System.Drawing.Size(1197, 710);
            this.cashierOrderform1.TabIndex = 3;
            this.cashierOrderform1.Load += new System.EventHandler(this.cashierOrderform1_Load);
            // 
            // adminAddProduct2
            // 
            this.adminAddProduct2.Location = new System.Drawing.Point(0, 0);
            this.adminAddProduct2.Name = "adminAddProduct2";
            this.adminAddProduct2.Size = new System.Drawing.Size(1197, 710);
            this.adminAddProduct2.TabIndex = 2;
            // 
            // adminAddProduct1
            // 
            this.adminAddProduct1.Location = new System.Drawing.Point(3, 0);
            this.adminAddProduct1.Name = "adminAddProduct1";
            this.adminAddProduct1.Size = new System.Drawing.Size(8, 8);
            this.adminAddProduct1.TabIndex = 1;
            // 
            // adminDasshbord1
            // 
            this.adminDasshbord1.Location = new System.Drawing.Point(3, 0);
            this.adminDasshbord1.Name = "adminDasshbord1";
            this.adminDasshbord1.Size = new System.Drawing.Size(1205, 702);
            this.adminDasshbord1.TabIndex = 0;
            // 
            // Cashierform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 787);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cashierform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btcustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btproduct;
        private System.Windows.Forms.Button btdasboad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btoder;
        private System.Windows.Forms.Panel panel2;
        private AdminDasshbord adminDasshbord1;
        private AdminAddProduct adminAddProduct1;
        private AdminAddProduct adminAddProduct2;
        private CashierOrderform cashierOrderform1;
        private Customeradddata customeradddata1;
    }
}