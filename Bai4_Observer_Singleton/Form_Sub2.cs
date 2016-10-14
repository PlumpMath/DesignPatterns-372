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
    public partial class Form_Sub2 : Form,IObserver
    {
        public Form_Sub2()
        {
            InitializeComponent();
        }
        Subject sub;
        private void Form_Sub2_Load(object sender, EventArgs e)
        {
            sub = Subject.CreateSubject();
            sub.Attach(this);
        }

        public void Update(Color color)
        {
            btn_form2.BackColor = color;
        }
    }
}
