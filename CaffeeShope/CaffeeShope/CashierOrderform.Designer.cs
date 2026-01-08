namespace CaffeeShope
{
    partial class CashierOrderform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrderform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Cashier_menutable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btcancel = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.productname = new System.Windows.Forms.Label();
            this.lblproductname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudquantity = new System.Windows.Forms.NumericUpDown();
            this.cbproductid = new System.Windows.Forms.ComboBox();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.byrecipt = new System.Windows.Forms.Button();
            this.btpay = new System.Windows.Forms.Button();
            this.tbamount = new System.Windows.Forms.TextBox();
            this.lblchange = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.Cashier_orderstable = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cashier_menutable)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudquantity)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cashier_orderstable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Cashier_menutable);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 341);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu";
            // 
            // Cashier_menutable
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Cashier_menutable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Cashier_menutable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Cashier_menutable.DefaultCellStyle = dataGridViewCellStyle10;
            this.Cashier_menutable.EnableHeadersVisualStyles = false;
            this.Cashier_menutable.Location = new System.Drawing.Point(3, 54);
            this.Cashier_menutable.Name = "Cashier_menutable";
            this.Cashier_menutable.RowHeadersWidth = 51;
            this.Cashier_menutable.RowTemplate.Height = 24;
            this.Cashier_menutable.Size = new System.Drawing.Size(798, 260);
            this.Cashier_menutable.TabIndex = 3;
            this.Cashier_menutable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btcancel);
            this.panel2.Controls.Add(this.btRemove);
            this.panel2.Controls.Add(this.btadd);
            this.panel2.Controls.Add(this.price);
            this.panel2.Controls.Add(this.lblprice);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.productname);
            this.panel2.Controls.Add(this.lblproductname);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nudquantity);
            this.panel2.Controls.Add(this.cbproductid);
            this.panel2.Controls.Add(this.cbtype);
            this.panel2.Location = new System.Drawing.Point(3, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 327);
            this.panel2.TabIndex = 1;
            // 
            // btcancel
            // 
            this.btcancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btcancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancel.ForeColor = System.Drawing.Color.White;
            this.btcancel.Location = new System.Drawing.Point(560, 246);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(173, 55);
            this.btcancel.TabIndex = 21;
            this.btcancel.Text = "CANCEL";
            this.btcancel.UseVisualStyleBackColor = false;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btRemove.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.ForeColor = System.Drawing.Color.White;
            this.btRemove.Location = new System.Drawing.Point(309, 246);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(173, 55);
            this.btRemove.TabIndex = 20;
            this.btRemove.Text = "REMOVE";
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btadd
            // 
            this.btadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btadd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.ForeColor = System.Drawing.Color.White;
            this.btadd.Location = new System.Drawing.Point(62, 246);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(173, 55);
            this.btadd.TabIndex = 19;
            this.btadd.Text = "ADD";
            this.btadd.UseVisualStyleBackColor = false;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(88, 165);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(77, 24);
            this.price.TabIndex = 10;
            this.price.Text = "Price($):";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(166, 165);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(40, 24);
            this.lblprice.TabIndex = 9;
            this.lblprice.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(489, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Quantity:";
            // 
            // productname
            // 
            this.productname.AutoSize = true;
            this.productname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname.Location = new System.Drawing.Point(42, 104);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(134, 24);
            this.productname.TabIndex = 7;
            this.productname.Text = "Product Name:";
            // 
            // lblproductname
            // 
            this.lblproductname.AutoSize = true;
            this.lblproductname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductname.Location = new System.Drawing.Point(184, 104);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(113, 24);
            this.lblproductname.TabIndex = 6;
            this.lblproductname.Text = "Test Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "ProductID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            // 
            // nudquantity
            // 
            this.nudquantity.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudquantity.Location = new System.Drawing.Point(582, 104);
            this.nudquantity.Name = "nudquantity";
            this.nudquantity.Size = new System.Drawing.Size(217, 28);
            this.nudquantity.TabIndex = 2;
            // 
            // cbproductid
            // 
            this.cbproductid.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbproductid.FormattingEnabled = true;
            this.cbproductid.Location = new System.Drawing.Point(582, 33);
            this.cbproductid.Name = "cbproductid";
            this.cbproductid.Size = new System.Drawing.Size(217, 29);
            this.cbproductid.TabIndex = 1;
            this.cbproductid.SelectedIndexChanged += new System.EventHandler(this.cbproductid_SelectedIndexChanged);
            // 
            // cbtype
            // 
            this.cbtype.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Items.AddRange(new object[] {
            "Meal",
            "Drinks"});
            this.cbtype.Location = new System.Drawing.Point(154, 33);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(217, 29);
            this.cbtype.TabIndex = 0;
            this.cbtype.SelectedIndexChanged += new System.EventHandler(this.cbtype_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.byrecipt);
            this.panel4.Controls.Add(this.btpay);
            this.panel4.Controls.Add(this.tbamount);
            this.panel4.Controls.Add(this.lblchange);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.lbltotalprice);
            this.panel4.Controls.Add(this.Cashier_orderstable);
            this.panel4.Location = new System.Drawing.Point(848, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 688);
            this.panel4.TabIndex = 2;
            // 
            // byrecipt
            // 
            this.byrecipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.byrecipt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byrecipt.ForeColor = System.Drawing.Color.White;
            this.byrecipt.Location = new System.Drawing.Point(28, 607);
            this.byrecipt.Name = "byrecipt";
            this.byrecipt.Size = new System.Drawing.Size(268, 55);
            this.byrecipt.TabIndex = 23;
            this.byrecipt.Text = "RECEIPT";
            this.byrecipt.UseVisualStyleBackColor = false;
            this.byrecipt.Click += new System.EventHandler(this.byrecipt_Click);
            // 
            // btpay
            // 
            this.btpay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btpay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpay.ForeColor = System.Drawing.Color.White;
            this.btpay.Location = new System.Drawing.Point(28, 526);
            this.btpay.Name = "btpay";
            this.btpay.Size = new System.Drawing.Size(268, 55);
            this.btpay.TabIndex = 22;
            this.btpay.Text = "PAY";
            this.btpay.UseVisualStyleBackColor = false;
            this.btpay.Click += new System.EventHandler(this.btpay_Click);
            // 
            // tbamount
            // 
            this.tbamount.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbamount.Location = new System.Drawing.Point(176, 432);
            this.tbamount.Name = "tbamount";
            this.tbamount.Size = new System.Drawing.Size(135, 28);
            this.tbamount.TabIndex = 16;
            this.tbamount.TextChanged += new System.EventHandler(this.tbamount_TextChanged);
            this.tbamount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbamount_KeyDown);
            // 
            // lblchange
            // 
            this.lblchange.AutoSize = true;
            this.lblchange.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchange.Location = new System.Drawing.Point(166, 477);
            this.lblchange.Name = "lblchange";
            this.lblchange.Size = new System.Drawing.Size(20, 24);
            this.lblchange.TabIndex = 15;
            this.lblchange.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(61, 477);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 24);
            this.label12.TabIndex = 14;
            this.label12.Text = "Change($):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(61, 427);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 24);
            this.label11.TabIndex = 13;
            this.label11.Text = "Amount($):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(73, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Price($):";
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.AutoSize = true;
            this.lbltotalprice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalprice.Location = new System.Drawing.Point(151, 387);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(40, 24);
            this.lbltotalprice.TabIndex = 11;
            this.lbltotalprice.Text = "100";
            // 
            // Cashier_orderstable
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Cashier_orderstable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.Cashier_orderstable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Cashier_orderstable.DefaultCellStyle = dataGridViewCellStyle12;
            this.Cashier_orderstable.EnableHeadersVisualStyles = false;
            this.Cashier_orderstable.Location = new System.Drawing.Point(3, 27);
            this.Cashier_orderstable.Name = "Cashier_orderstable";
            this.Cashier_orderstable.RowHeadersWidth = 51;
            this.Cashier_orderstable.RowTemplate.Height = 24;
            this.Cashier_orderstable.Size = new System.Drawing.Size(324, 333);
            this.Cashier_orderstable.TabIndex = 0;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // CashierOrderform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CashierOrderform";
            this.Size = new System.Drawing.Size(1197, 710);
            this.Load += new System.EventHandler(this.Customersdata_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cashier_menutable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudquantity)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cashier_orderstable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView Cashier_menutable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbproductid;
        private System.Windows.Forms.ComboBox cbtype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudquantity;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label productname;
        private System.Windows.Forms.Label lblproductname;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btpay;
        private System.Windows.Forms.TextBox tbamount;
        private System.Windows.Forms.Label lblchange;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbltotalprice;
        private System.Windows.Forms.DataGridView Cashier_orderstable;
        private System.Windows.Forms.Button byrecipt;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
