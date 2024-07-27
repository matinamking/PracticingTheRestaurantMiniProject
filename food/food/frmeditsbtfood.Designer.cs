
namespace food
{
    partial class frmeditsbtfood
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsbt = new System.Windows.Forms.Button();
            this.txtpricefood = new System.Windows.Forms.TextBox();
            this.txtnamefood = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "قیمت غذا";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "اسم غذا";
            // 
            // btnsbt
            // 
            this.btnsbt.Location = new System.Drawing.Point(12, 110);
            this.btnsbt.Name = "btnsbt";
            this.btnsbt.Size = new System.Drawing.Size(218, 23);
            this.btnsbt.TabIndex = 7;
            this.btnsbt.Text = "ثبت";
            this.btnsbt.UseVisualStyleBackColor = true;
            this.btnsbt.Click += new System.EventHandler(this.btnsbt_Click);
            // 
            // txtpricefood
            // 
            this.txtpricefood.Location = new System.Drawing.Point(12, 69);
            this.txtpricefood.Name = "txtpricefood";
            this.txtpricefood.Size = new System.Drawing.Size(154, 22);
            this.txtpricefood.TabIndex = 6;
            // 
            // txtnamefood
            // 
            this.txtnamefood.Location = new System.Drawing.Point(12, 23);
            this.txtnamefood.Name = "txtnamefood";
            this.txtnamefood.Size = new System.Drawing.Size(154, 22);
            this.txtnamefood.TabIndex = 5;
            // 
            // frmeditsbtfood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 152);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsbt);
            this.Controls.Add(this.txtpricefood);
            this.Controls.Add(this.txtnamefood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmeditsbtfood";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش غذا";
            this.Load += new System.EventHandler(this.frmeditsbtfood_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnsbt;
        public System.Windows.Forms.TextBox txtpricefood;
        public System.Windows.Forms.TextBox txtnamefood;
    }
}