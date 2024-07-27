using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace food
{
    public partial class frmeditsbtfood : Form
    {
        public int code = 0;
        public foodEntities data = new foodEntities();
        public frmeditsbtfood()
        {
            InitializeComponent();
        }

        private void frmeditsbtfood_Load(object sender, EventArgs e)
        {

        }

        private void btnsbt_Click(object sender, EventArgs e)
        {
            if (txtnamefood.Text == ""||txtpricefood.Text=="")
            {
                MessageBox.Show("لطفا نام و نام خانوادگی را وارد کنید");
            }
            else
            {
                var qury = (from o in data.foods where o.ID == code select o).SingleOrDefault();
                qury.name_food = txtnamefood.Text;
                qury.price = txtpricefood.Text;
                
                data.SaveChanges();
                MessageBox.Show("ویرایش با موفقیت انجام شد");
                this.Close();
            }
        }
    }
}
