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
    public partial class Form_New_Student : Form
    {
        public Form_New_Student()
        {
            InitializeComponent();
        }
        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.Name = txtName.Text;
            stu.Address = txtAdd.Text;
            stu.Phone = txtPhone.Text;

            sub.student = stu;
            sub.Notify();
            
        }
        Subject sub;
        private void Form_New_Student_Load(object sender, EventArgs e)
        {
            sub = Subject.CreateSubject();
        }
    }
}
