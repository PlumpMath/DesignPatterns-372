using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_MVVM
{
    class ViewModel
    {
        protected DesignPatternDB entity;
        private BindingSource ob_BindingList;


        private int currentIndex = -1;
        public delegate void CurrentIndexChanged(Student stu);
        public event CurrentIndexChanged currentIndexChangedEvent;

        public ViewModel()
        {
            entity = new DesignPatternDB();
            ob_BindingList = new BindingSource();
        }

        public int CurrentIndex
        {
            get { return this.currentIndex; }
            set
            {
                this.currentIndex = value;
                if (currentIndexChangedEvent != null & this.currentIndex >= 0)
                    currentIndexChangedEvent((Student)ob_BindingList[currentIndex]);
            }
        }
        public BindingSource GetObjectBindingSource()
        {
            ob_BindingList.DataSource = entity.Students.ToList();
            return ob_BindingList;
        }
        public int Update(Student stu)
        {
            Student old_stu = entity.Students.FirstOrDefault(n => n.ID == stu.ID);
            old_stu.Name = stu.Name;
            old_stu.Phone = stu.Phone;
            old_stu.Address = stu.Address;

            entity.Entry(old_stu).State = System.Data.Entity.EntityState.Modified;
            int num = entity.SaveChanges();
            if (num > 0)
            {
                ob_BindingList[currentIndex] = old_stu;
                ob_BindingList.ResetCurrentItem();
            }
            return num;
        }
        public int Delete(Student stu)
        {

            entity.Students.Remove(stu);
            int res = entity.SaveChanges();
            if (res > 0)
            {
                ob_BindingList.Remove(stu);
                ob_BindingList.ResetBindings(false);
            }
            return res;
        }

        public int Add(Student stu)
        {
            entity.Students.Add(stu);
            int res = entity.SaveChanges();
            if (res > 0)
            {
                ob_BindingList.Add(stu);
            }
            return res;
        }
    }
}
