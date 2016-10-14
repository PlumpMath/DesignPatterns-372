using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_Observer_Singleton
{
    public partial class Form_Config : Form
    {
        public Form_Config()
        {
            InitializeComponent();
        }

        Subject sub;
        private void Form_Config_Load(object sender, EventArgs e)
        {
            sub = Subject.CreateSubject();

            List<Color> ls = new List<Color>();
            foreach (PropertyInfo property in typeof(Color).GetProperties())
            {
                if (property.PropertyType == typeof(Color))
                {
                    ls.Add((Color)property.GetValue(null));
                }
            }

            cb_color.DataSource = ls;
            cb_color.DisplayMember = "Name";
            cb_color.ValueMember = "Name";
        }

        private void btn_red_Click(object sender, EventArgs e)
        {
            sub.state = btn_red.BackColor;
            sub.Notify();
        }

        private void btn_green_Click(object sender, EventArgs e)
        {
            sub.state = btn_green.BackColor;
            sub.Notify();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sub.state = button3.BackColor;
            sub.Notify();
        }

      

        private void cb_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            string colorName = cb_color.SelectedValue.ToString();
            Color select_cl = Color.FromName(colorName);
            sub.state = select_cl;
            sub.Notify();
        }
    }
}
