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
    public partial class frmsbtcustomer : Form
    {
        foodEntities data = new foodEntities();
        public frmsbtcustomer()
        {
            InitializeComponent();
        }

        private void btnsbt_Click(object sender, EventArgs e)
        {
            if (txtfamily.Text == "" || txtfhone.Text == ""|| txtname.Text=="")
            {
                MessageBox.Show("لطفا نام و نام خانوادگی را وارد کنید");
            }
            else
            {
                customer username = new customer();
                username.name = txtname.Text;
                username.family = txtfamily.Text;
                username.phone = txtfhone.Text;


                data.customers.Add(username);
                data.SaveChanges();

                MessageBox.Show("ثبت با موفقیت انجام شد");
            }
            grdlist.DataSource = data.customers.ToList();
        }

        private void frmsbtcustomer_Load(object sender, EventArgs e)
        {
            grdlist.DataSource = data.customers.ToList();
        }
    }
}
