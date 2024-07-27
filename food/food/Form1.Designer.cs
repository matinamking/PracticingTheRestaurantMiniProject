
namespace food
{
    partial class frm1
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
            this.txtserch = new System.Windows.Forms.TextBox();
            this.btnsbtfood = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numtedad = new System.Windows.Forms.NumericUpDown();
            this.txtfood = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsbtnahayi = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnfoodadd = new System.Windows.Forms.Button();
            this.btnfoodedit = new System.Windows.Forms.Button();
            this.btnfac = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.grdlist = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_food = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numtedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).BeginInit();
            this.SuspendLayout();
            // 
            // txtserch
            // 
            this.txtserch.Location = new System.Drawing.Point(11, 63);
            this.txtserch.Name = "txtserch";
            this.txtserch.Size = new System.Drawing.Size(607, 22);
            this.txtserch.TabIndex = 1;
            this.txtserch.TextChanged += new System.EventHandler(this.txtserch_TextChanged);
            // 
            // btnsbtfood
            // 
            this.btnsbtfood.Location = new System.Drawing.Point(11, 432);
            this.btnsbtfood.Name = "btnsbtfood";
            this.btnsbtfood.Size = new System.Drawing.Size(301, 32);
            this.btnsbtfood.TabIndex = 2;
            this.btnsbtfood.Text = "ثبت غذا";
            this.btnsbtfood.UseVisualStyleBackColor = true;
            this.btnsbtfood.Click += new System.EventHandler(this.btnsbtfood_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "تعداد";
            // 
            // numtedad
            // 
            this.numtedad.Location = new System.Drawing.Point(143, 407);
            this.numtedad.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numtedad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numtedad.Name = "numtedad";
            this.numtedad.Size = new System.Drawing.Size(120, 22);
            this.numtedad.TabIndex = 4;
            this.numtedad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtfood
            // 
            this.txtfood.Location = new System.Drawing.Point(319, 108);
            this.txtfood.Multiline = true;
            this.txtfood.Name = "txtfood";
            this.txtfood.Size = new System.Drawing.Size(300, 290);
            this.txtfood.TabIndex = 5;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(451, 406);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(119, 22);
            this.txtprice.TabIndex = 6;
            this.txtprice.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "قیمت";
            // 
            // btnsbtnahayi
            // 
            this.btnsbtnahayi.Location = new System.Drawing.Point(318, 432);
            this.btnsbtnahayi.Name = "btnsbtnahayi";
            this.btnsbtnahayi.Size = new System.Drawing.Size(301, 32);
            this.btnsbtnahayi.TabIndex = 8;
            this.btnsbtnahayi.Text = "ثبت نهایی";
            this.btnsbtnahayi.UseVisualStyleBackColor = true;
            this.btnsbtnahayi.Click += new System.EventHandler(this.btnsbtnahayi_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(321, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "حذف لیست غذاهای انتخابی";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "غذاهای درخواستی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "لیست غذا ها";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "جستجو";
            // 
            // btnfoodadd
            // 
            this.btnfoodadd.Location = new System.Drawing.Point(13, 12);
            this.btnfoodadd.Name = "btnfoodadd";
            this.btnfoodadd.Size = new System.Drawing.Size(136, 37);
            this.btnfoodadd.TabIndex = 13;
            this.btnfoodadd.Text = "افزودن غذا";
            this.btnfoodadd.UseVisualStyleBackColor = true;
            this.btnfoodadd.Click += new System.EventHandler(this.btnfoodadd_Click);
            // 
            // btnfoodedit
            // 
            this.btnfoodedit.Location = new System.Drawing.Point(155, 12);
            this.btnfoodedit.Name = "btnfoodedit";
            this.btnfoodedit.Size = new System.Drawing.Size(127, 37);
            this.btnfoodedit.TabIndex = 14;
            this.btnfoodedit.Text = "ویرایش غذا";
            this.btnfoodedit.UseVisualStyleBackColor = true;
            this.btnfoodedit.Click += new System.EventHandler(this.btnfoodedit_Click);
            // 
            // btnfac
            // 
            this.btnfac.Location = new System.Drawing.Point(288, 11);
            this.btnfac.Name = "btnfac";
            this.btnfac.Size = new System.Drawing.Size(137, 37);
            this.btnfac.TabIndex = 15;
            this.btnfac.Text = "نمایش فاکتور";
            this.btnfac.UseVisualStyleBackColor = true;
            this.btnfac.Click += new System.EventHandler(this.btnfac_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.Location = new System.Drawing.Point(431, 12);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(188, 36);
            this.btncustomer.TabIndex = 16;
            this.btncustomer.Text = "افزودن مشتری";
            this.btncustomer.UseVisualStyleBackColor = true;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // grdlist
            // 
            this.grdlist.AllowUserToAddRows = false;
            this.grdlist.AllowUserToDeleteRows = false;
            this.grdlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name_food,
            this.price});
            this.grdlist.Location = new System.Drawing.Point(-2, 108);
            this.grdlist.Name = "grdlist";
            this.grdlist.ReadOnly = true;
            this.grdlist.RowHeadersWidth = 51;
            this.grdlist.RowTemplate.Height = 24;
            this.grdlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdlist.Size = new System.Drawing.Size(315, 290);
            this.grdlist.TabIndex = 17;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // name_food
            // 
            this.name_food.DataPropertyName = "name_food";
            this.name_food.HeaderText = "اسم غذا";
            this.name_food.MinimumWidth = 6;
            this.name_food.Name = "name_food";
            this.name_food.ReadOnly = true;
            this.name_food.Width = 60;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "قیمت";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 476);
            this.Controls.Add(this.grdlist);
            this.Controls.Add(this.btncustomer);
            this.Controls.Add(this.btnfac);
            this.Controls.Add(this.btnfoodedit);
            this.Controls.Add(this.btnfoodadd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnsbtnahayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtfood);
            this.Controls.Add(this.numtedad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsbtfood);
            this.Controls.Add(this.txtserch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "رستوران";
            this.Load += new System.EventHandler(this.frm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numtedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtserch;
        private System.Windows.Forms.Button btnsbtfood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numtedad;
        private System.Windows.Forms.TextBox txtfood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsbtnahayi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnfoodadd;
        private System.Windows.Forms.Button btnfoodedit;
        private System.Windows.Forms.Button btnfac;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.DataGridView grdlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_food;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.TextBox txtprice;
    }
}

