namespace CaffeeShope
{
    partial class AdminAddProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pibimage = new System.Windows.Forms.PictureBox();
            this.btimport = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.pbimage = new System.Windows.Forms.PictureBox();
            this.cbstatus = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.btupdates = new System.Windows.Forms.Button();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.btclear = new System.Windows.Forms.Button();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.btdelet = new System.Windows.Forms.Button();
            this.tbproductname = new System.Windows.Forms.TextBox();
            this.tbproductID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1227, 359);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data of Product";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(25, 40);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 303);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btimport);
            this.panel2.Controls.Add(this.btadd);
            this.panel2.Controls.Add(this.pbimage);
            this.panel2.Controls.Add(this.cbstatus);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cbtype);
            this.panel2.Controls.Add(this.btupdates);
            this.panel2.Controls.Add(this.tbprice);
            this.panel2.Controls.Add(this.btclear);
            this.panel2.Controls.Add(this.tbStock);
            this.panel2.Controls.Add(this.btdelet);
            this.panel2.Controls.Add(this.tbproductname);
            this.panel2.Controls.Add(this.tbproductID);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1227, 330);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.pibimage);
            this.panel3.Location = new System.Drawing.Point(1004, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(121, 100);
            this.panel3.TabIndex = 26;
            // 
            // pibimage
            // 
            this.pibimage.Location = new System.Drawing.Point(-3, 0);
            this.pibimage.Name = "pibimage";
            this.pibimage.Size = new System.Drawing.Size(121, 100);
            this.pibimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibimage.TabIndex = 24;
            this.pibimage.TabStop = false;
            // 
            // btimport
            // 
            this.btimport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btimport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btimport.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btimport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btimport.Location = new System.Drawing.Point(1024, 148);
            this.btimport.Name = "btimport";
            this.btimport.Size = new System.Drawing.Size(87, 38);
            this.btimport.TabIndex = 25;
            this.btimport.Text = "Import";
            this.btimport.UseVisualStyleBackColor = false;
            this.btimport.Click += new System.EventHandler(this.button2_Click);
            // 
            // btadd
            // 
            this.btadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btadd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.ForeColor = System.Drawing.Color.White;
            this.btadd.Location = new System.Drawing.Point(126, 243);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(132, 55);
            this.btadd.TabIndex = 18;
            this.btadd.Text = "ADD";
            this.btadd.UseVisualStyleBackColor = false;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // pbimage
            // 
            this.pbimage.Location = new System.Drawing.Point(290, -301);
            this.pbimage.Name = "pbimage";
            this.pbimage.Size = new System.Drawing.Size(121, 100);
            this.pbimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimage.TabIndex = 22;
            this.pbimage.TabStop = false;
            // 
            // cbstatus
            // 
            this.cbstatus.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbstatus.FormattingEnabled = true;
            this.cbstatus.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cbstatus.Location = new System.Drawing.Point(626, 124);
            this.cbstatus.Name = "cbstatus";
            this.cbstatus.Size = new System.Drawing.Size(238, 29);
            this.cbstatus.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(470, -166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 38);
            this.button1.TabIndex = 23;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cbtype
            // 
            this.cbtype.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Items.AddRange(new object[] {
            "Meal",
            "Drinks"});
            this.cbtype.Location = new System.Drawing.Point(194, 135);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(247, 29);
            this.cbtype.TabIndex = 10;
            // 
            // btupdates
            // 
            this.btupdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btupdates.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btupdates.ForeColor = System.Drawing.Color.White;
            this.btupdates.Location = new System.Drawing.Point(318, 243);
            this.btupdates.Name = "btupdates";
            this.btupdates.Size = new System.Drawing.Size(132, 55);
            this.btupdates.TabIndex = 21;
            this.btupdates.Text = "UPDATE";
            this.btupdates.UseVisualStyleBackColor = false;
            this.btupdates.Click += new System.EventHandler(this.btupdates_Click);
            // 
            // tbprice
            // 
            this.tbprice.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbprice.Location = new System.Drawing.Point(626, 73);
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(238, 28);
            this.tbprice.TabIndex = 9;
            // 
            // btclear
            // 
            this.btclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btclear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btclear.ForeColor = System.Drawing.Color.White;
            this.btclear.Location = new System.Drawing.Point(657, 243);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(132, 55);
            this.btclear.TabIndex = 20;
            this.btclear.Text = "CLEAR";
            this.btclear.UseVisualStyleBackColor = false;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // tbStock
            // 
            this.tbStock.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStock.Location = new System.Drawing.Point(626, 37);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(238, 28);
            this.tbStock.TabIndex = 8;
            // 
            // btdelet
            // 
            this.btdelet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btdelet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelet.ForeColor = System.Drawing.Color.White;
            this.btdelet.Location = new System.Drawing.Point(484, 243);
            this.btdelet.Name = "btdelet";
            this.btdelet.Size = new System.Drawing.Size(132, 55);
            this.btdelet.TabIndex = 19;
            this.btdelet.Text = "DELETE";
            this.btdelet.UseVisualStyleBackColor = false;
            this.btdelet.Click += new System.EventHandler(this.btdelet_Click);
            // 
            // tbproductname
            // 
            this.tbproductname.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbproductname.Location = new System.Drawing.Point(203, 88);
            this.tbproductname.Name = "tbproductname";
            this.tbproductname.Size = new System.Drawing.Size(238, 28);
            this.tbproductname.TabIndex = 7;
            // 
            // tbproductID
            // 
            this.tbproductID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbproductID.Location = new System.Drawing.Point(203, 37);
            this.tbproductID.Name = "tbproductID";
            this.tbproductID.Size = new System.Drawing.Size(238, 28);
            this.tbproductID.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(554, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "ProductName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(554, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price($):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(557, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stock:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "ProductID:";
            // 
            // AdminAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddProduct";
            this.Size = new System.Drawing.Size(1244, 702);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbproductID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbstatus;
        private System.Windows.Forms.ComboBox cbtype;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.TextBox tbproductname;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.PictureBox pbimage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btupdates;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.Button btdelet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pibimage;
        private System.Windows.Forms.Button btimport;
    }
}
