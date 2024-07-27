
namespace food
{
    partial class frmsbtfood
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
            this.txtnamefood = new System.Windows.Forms.TextBox();
            this.txtpricefood = new System.Windows.Forms.TextBox();
            this.btnsbt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdlist = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_food = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnamefood
            // 
            this.txtnamefood.Location = new System.Drawing.Point(13, 29);
            this.txtnamefood.Name = "txtnamefood";
            this.txtnamefood.Size = new System.Drawing.Size(154, 22);
            this.txtnamefood.TabIndex = 0;
            // 
            // txtpricefood
            // 
            this.txtpricefood.Location = new System.Drawing.Point(13, 75);
            this.txtpricefood.Name = "txtpricefood";
            this.txtpricefood.Size = new System.Drawing.Size(154, 22);
            this.txtpricefood.TabIndex = 1;
            // 
            // btnsbt
            // 
            this.btnsbt.Location = new System.Drawing.Point(17, 134);
            this.btnsbt.Name = "btnsbt";
            this.btnsbt.Size = new System.Drawing.Size(218, 88);
            this.btnsbt.TabIndex = 2;
            this.btnsbt.Text = "ثبت";
            this.btnsbt.UseVisualStyleBackColor = true;
            this.btnsbt.Click += new System.EventHandler(this.btnsbt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "اسم غذا";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "قیمت غذا";
            // 
            // grdlist
            // 
            this.grdlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name_food,
            this.price});
            this.grdlist.Location = new System.Drawing.Point(274, 12);
            this.grdlist.Name = "grdlist";
            this.grdlist.RowHeadersWidth = 51;
            this.grdlist.RowTemplate.Height = 24;
            this.grdlist.Size = new System.Drawing.Size(422, 239);
            this.grdlist.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // name_food
            // 
            this.name_food.DataPropertyName = "name_food";
            this.name_food.HeaderText = "اسم غذا";
            this.name_food.MinimumWidth = 6;
            this.name_food.Name = "name_food";
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "قیمت";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            // 
            // frmsbtfood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 259);
            this.Controls.Add(this.grdlist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsbt);
            this.Controls.Add(this.txtpricefood);
            this.Controls.Add(this.txtnamefood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmsbtfood";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن غذا";
            this.Load += new System.EventHandler(this.frmsbtfood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnamefood;
        private System.Windows.Forms.TextBox txtpricefood;
        private System.Windows.Forms.Button btnsbt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_food;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}