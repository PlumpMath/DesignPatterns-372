using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_MVVM
{
    public partial class Form_Product : Form
    {
        Subject sub;
        //ViewModel vm = new ViewModel();
        ViewModel_Product vm = new ViewModel_Product();
        BindingSource bindingSource = new BindingSource();



        public Form_Product()
        {
            InitializeComponent();
            vm.currentIndexChangedEvent += DisplayCurrenRow;
        }

        private void Form_Product_Load(object sender, EventArgs e)
        {
            bindingSource = vm.GetObjectBindingSource();
            dg.DataSource = bindingSource;
            if (bindingSource.Count >= 0)
                vm.CurrentIndex = 0;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

  
        }
        private void DisplayCurrenRow(Product pro)
        {
            txtID.Text = pro.ID.ToString();
            txtName.Text = pro.Name;
            txtPrice.Text = pro.Price.ToString();
            txtDes.Text = pro.Description;
        }

     

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Price = decimal.Parse(txtPrice.Text);
            product.Description = txtDes.Text;
            product.Name = txtName.Text;

            int t = vm.Add(product);
            if (t == -1)
                MessageBox.Show("Đã có sản phẩm tên " + txtName.Text);
            else
            {
                dg.Rows[bindingSource.Count - 1].Selected = true;
                vm.CurrentIndex = bindingSource.Count - 1;
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < bindingSource.Count)
                vm.CurrentIndex = e.RowIndex;
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Xác nhận xóa?", "Thông báo",
             MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (vm.CurrentIndex >= 0 && res == DialogResult.Yes)
            {
                Product pro = new Product();
                pro = (Product)bindingSource[vm.CurrentIndex];
                vm.Delete(pro);
                if (vm.CurrentIndex == 0 && bindingSource.Count == 0)
                    vm.CurrentIndex = -1;

                dg.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
            pro.ID = int.Parse(txtID.Text);
            pro.Name = txtName.Text;
            pro.Price = decimal.Parse(txtPrice.Text);
            pro.Description = txtDes.Text;
            int t = vm.Update(pro);
            if (t <= 0)
                MessageBox.Show("Không có gì để cập nhật!");
            else
                MessageBox.Show("Cập nhật thành công!");
        }
    }
}
