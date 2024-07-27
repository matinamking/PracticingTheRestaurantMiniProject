
namespace food
{
    partial class frmsbtcustomer
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtfamily = new System.Windows.Forms.TextBox();
            this.txtfhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsbt = new System.Windows.Forms.Button();
            this.grdlist = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).BeginInit();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(13, 44);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(174, 22);
            this.txtname.TabIndex = 0;
            // 
            // txtfamily
            // 
            this.txtfamily.Location = new System.Drawing.Point(13, 90);
            this.txtfamily.Name = "txtfamily";
            this.txtfamily.Size = new System.Drawing.Size(174, 22);
            this.txtfamily.TabIndex = 1;
            // 
            // txtfhone
            // 
            this.txtfhone.Location = new System.Drawing.Point(12, 133);
            this.txtfhone.Name = "txtfhone";
            this.txtfhone.Size = new System.Drawing.Size(174, 22);
            this.txtfhone.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "نام";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "نام خانوادگی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "شماره تلفن";
            // 
            // btnsbt
            // 
            this.btnsbt.Location = new System.Drawing.Point(31, 193);
            this.btnsbt.Name = "btnsbt";
            this.btnsbt.Size = new System.Drawing.Size(267, 23);
            this.btnsbt.TabIndex = 6;
            this.btnsbt.Text = "ثبت";
            this.btnsbt.UseVisualStyleBackColor = true;
            this.btnsbt.Click += new System.EventHandler(this.btnsbt_Click);
            // 
            // grdlist
            // 
            this.grdlist.AllowUserToAddRows = false;
            this.grdlist.AllowUserToDeleteRows = false;
            this.grdlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.family,
            this.phone});
            this.grdlist.Location = new System.Drawing.Point(338, 12);
            this.grdlist.Name = "grdlist";
            this.grdlist.ReadOnly = true;
            this.grdlist.RowHeadersWidth = 51;
            this.grdlist.RowTemplate.Height = 24;
            this.grdlist.Size = new System.Drawing.Size(611, 204);
            this.grdlist.TabIndex = 7;
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
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "اسم";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 70;
            // 
            // family
            // 
            this.family.DataPropertyName = "family";
            this.family.HeaderText = "فامیل";
            this.family.MinimumWidth = 6;
            this.family.Name = "family";
            this.family.ReadOnly = true;
            this.family.Width = 70;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "شماره تلفن";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // frmsbtcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 228);
            this.Controls.Add(this.grdlist);
            this.Controls.Add(this.btnsbt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfhone);
            this.Controls.Add(this.txtfamily);
            this.Controls.Add(this.txtname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmsbtcustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن مشتری";
            this.Load += new System.EventHandler(this.frmsbtcustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtfamily;
        private System.Windows.Forms.TextBox txtfhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsbt;
        private System.Windows.Forms.DataGridView grdlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn family;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
    }
}