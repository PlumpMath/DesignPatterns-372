using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8_Iterator
{
    public partial class IteratorApp : Form
    {
        Iterator iterator;
        public IteratorApp()
        {
            InitializeComponent();
        }

        private void IteratorApp_Load(object sender, EventArgs e)
        {
            CollectionList colection = new CollectionList();
            for (int i = 0; i<= 10; i++)
            {
                Item item = new Item("Item #" + Convert.ToString(i));
                colection.Add(item);
            }
            iterator = Iterator.CreateIterator(colection);

            txt_Item.Text = iterator.First().Name;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            txt_Item.Text = iterator.First().Name;

            if (iterator.isLast())
                lb_isLastItem.Text = "This is last item!";
            else
                lb_isLastItem.Text = "This is first item!";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            

            if (iterator.isLast())
                lb_isLastItem.Text = "This is last item!";
            else
            {
                lb_isLastItem.Text = "This is a normal item";
                txt_Item.Text = iterator.Next().Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = iterator.Prev();
           if (item == null)
            {
                lb_isLastItem.Text = "This is first item";
            }
           else
            {
                lb_isLastItem.Text = "This is a normal item";
                txt_Item.Text = item.Name;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var item = iterator.Last();
            lb_isLastItem.Text = "This is last item";
            txt_Item.Text = item.Name;
        }
    }
}
