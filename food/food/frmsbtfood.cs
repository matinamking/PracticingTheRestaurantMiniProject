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
    public partial class frmsbtfood : Form
    {
        foodEntities data = new foodEntities();
        public frmsbtfood()
        {
            InitializeComponent();
        }

        private void btnsbt_Click(object sender, EventArgs e)
        {
            if (txtnamefood.Text == "" || txtpricefood.Text == "" )
            {
                MessageBox.Show("لطفا تمامی اطلاعات را بدرستی وارد کنید");
            }
            else
            {
                food username = new food();
                username.name_food = txtnamefood.Text;
                username.price = txtpricefood.Text;
                

                data.foods.Add(username);
                data.SaveChanges();

                MessageBox.Show("ثبت با موفقیت انجام شد");

            }
            grdlist.DataSource = data.foods.ToList();
        }

        private void frmsbtfood_Load(object sender, EventArgs e)
        {
            grdlist.DataSource = data.foods.ToList();
        }
    }
}
