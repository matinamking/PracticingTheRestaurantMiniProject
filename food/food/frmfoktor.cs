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
    public partial class frmfoktor : Form
    {
        foodEntities data = new foodEntities();
        
        public frmfoktor()
        {
            InitializeComponent();
        }

        private void frmfoktor_Load(object sender, EventArgs e)
        {
            
        }

        private void btnfo_Click(object sender, EventArgs e)
        {
            var q = from n in data.focktors
                    join a in data.customers
                    on n.id_customer equals a.ID
                    select new { a.name, a.family, a.phone, n.price, n.date_frosh };
            dataGridView1.DataSource = q.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var qury = (from tr in data.customers where tr.name.Contains(textBox1.Text) select tr);
            dataGridView1.DataSource = qury.ToList();
        }
    }
}
