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
    public partial class Form1 : Form,IObserver
    {
        Subject sub;
        ViewModel vm = new ViewModel();
        BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            vm.currentIndexChangedEvent += DisplayCurrenRow;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource = vm.GetObjectBindingSource();
            dg.DataSource = bindingSource;
            if (bindingSource.Count >= 0)
                vm.CurrentIndex = 0;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            sub = Subject.CreateSubject();
            sub.Attach(this);
        }
        private void DisplayCurrenRow(Student stu)
        {
            txtID.Text = stu.ID.ToString();
            txtName.Text = stu.Name.ToString();
            txtPhone.Text = stu.Phone;
            txtAdd.Text = stu.Address;
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < bindingSource.Count)
                vm.CurrentIndex = e.RowIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.ID = int.Parse(txtID.Text);
            stu.Name = txtName.Text;
            stu.Phone = txtPhone.Text;
            stu.Address = txtAdd.Text;
           
            vm.Update(stu);
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            Form_New_Student f = new Form_New_Student();
            f.ShowDialog();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
              DialogResult res = MessageBox.Show("Xác nhận xóa sinh viên?", "Xác nhận",
             MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (vm.CurrentIndex >= 0 && res == DialogResult.Yes)
            {
                Student stu = new Student();
                stu = (Student)bindingSource[vm.CurrentIndex];
                vm.Delete(stu);
                if (vm.CurrentIndex == 0 && bindingSource.Count == 0)
                    vm.CurrentIndex = -1;

                dg.Refresh();   
            }
        }

        public void AddStudent(Student student)
        {
            vm.Add(student);
            dg.Rows[bindingSource.Count - 1].Selected = true;
            vm.CurrentIndex = bindingSource.Count - 1;
        }
    }
}
