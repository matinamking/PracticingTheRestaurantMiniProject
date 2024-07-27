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
    public partial class frm1 : Form
    {
        int code = 0;
        int c = 0;
        int b = 0;
        int a = 0;
        foodEntities data = new foodEntities();
        public frm1()
        {
            InitializeComponent();
        }

        private void btnfoodadd_Click(object sender, EventArgs e)
        {
            frmsbtfood frm_sbtf = new frmsbtfood();
            frm_sbtf.ShowDialog();
            grdlist.DataSource = data.foods.ToList();
        }

        private void btnfoodedit_Click(object sender, EventArgs e)
        {

            frmeditsbtfood frm_editf = new frmeditsbtfood();
            if (grdlist.RowCount == 0)
            {
                MessageBox.Show("رکوردی برای ویرایش وجود ندارد");
            }
            frm_editf.code = Convert.ToInt32(grdlist.CurrentRow.Cells["ID"].Value.ToString());
            frm_editf.txtnamefood.Text = grdlist.CurrentRow.Cells["name_food"].Value.ToString();
            frm_editf.txtpricefood.Text = grdlist.CurrentRow.Cells["price"].Value.ToString();
            frm_editf.ShowDialog();
            data = frm_editf.data;
            grdlist.DataSource = data.foods.ToList();
        }

        private void btnfac_Click(object sender, EventArgs e)
        {
            frmfoktor frm_foktor = new frmfoktor();
            frm_foktor.ShowDialog();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            frmsbtcustomer frm_sbtc = new frmsbtcustomer();
            frm_sbtc.ShowDialog();
        }

        private void btnsbtnahayi_Click(object sender, EventArgs e)
        {
            
            frmsbtnahayi frm_sbtn = new frmsbtnahayi();
            frm_sbtn.txtprice.Text = txtprice.Text;
            frm_sbtn.ShowDialog();
        }

        private void btnsbtfood_Click(object sender, EventArgs e)
        {
            if (grdlist.RowCount == 0)
            {
                MessageBox.Show("رکوردی برای ثبت غذا وجود ندارد");
            }
            code = Convert.ToInt32(grdlist.CurrentRow.Cells["ID"].Value.ToString());
            txtfood.Text = grdlist.CurrentRow.Cells["name_food"].Value.ToString();
            c = Convert.ToInt32( grdlist.CurrentRow.Cells["price"].Value.ToString());
            b = Convert.ToInt32(numtedad.Value);
            a = Convert.ToInt32(txtprice.Text);
            txtprice.Text =Convert.ToString( (c * b) + a);
            
            
        }

        private void frm1_Load(object sender, EventArgs e)
        {
            grdlist.DataSource = data.foods.ToList();
        }

        private void txtserch_TextChanged(object sender, EventArgs e)
        {
            var qury = (from tr in data.foods where tr.name_food.Contains(txtserch.Text) select tr);
            grdlist.DataSource = qury.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtfood.Text = "";
            txtprice.Text = "0";
        }
    }
}
