using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_Observer_Singleton
{
    public partial class FormKhoiDong : Form
    {
        public FormKhoiDong()
        {
            InitializeComponent();
        }

        private void FormKhoiDong_Load(object sender, EventArgs e)
        {
            Form_Config f_cf = new Form_Config();
            f_cf.Show();
            f_cf.MdiParent = this;

            Form_Sub1 f_sub1 = new Form_Sub1();
            f_sub1.MdiParent = this;
            f_sub1.Show();


            Form_Sub2 f_sub2 = new Form_Sub2();
            f_sub2.MdiParent = this;
            f_sub2.Show();
        }
    }
}
