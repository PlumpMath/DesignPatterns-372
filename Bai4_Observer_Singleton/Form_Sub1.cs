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
    public partial class Form_Sub1 : Form,IObserver
    {
        public Form_Sub1()
        {
            InitializeComponent();
        }
        Subject sub;
        private void Form_Sub1_Load(object sender, EventArgs e)
        {
            sub = Subject.CreateSubject();
            sub.Attach(this);
        }

        public void Update(Color color)
        {
            btn_form1.BackColor = color;
        }

        private void btn_detach_Click(object sender, EventArgs e)
        {
            sub.Detach(this);
        }
    }
}
