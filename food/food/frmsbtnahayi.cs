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
    public partial class frmsbtnahayi : Form
    {
        foodEntities data = new foodEntities();
        public frmsbtnahayi()
        {
            InitializeComponent();
        }

        private void frmsbtnahayi_Load(object sender, EventArgs e)
        {
            grdlist.DataSource = data.customers.ToList();
            
        }

        private void btnsbt_Click(object sender, EventArgs e)
        {
            if (txtprice.Text == "" || textBox1.Text == ""||textBox2.Text=="")
            {
                MessageBox.Show("لطفا تمامی اطلاعات را بدرستی وارد کنید");
            }
            else
            {
                focktor username = new focktor();
                username.price =Convert.ToInt32( txtprice.Text);
                username.date_frosh =textBox1.Text ;
                username.id_customer =Convert.ToInt32( textBox2.Text);


                data.focktors.Add(username);
                data.SaveChanges();

                MessageBox.Show("ثبت با موفقیت انجام شد");

            }
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
