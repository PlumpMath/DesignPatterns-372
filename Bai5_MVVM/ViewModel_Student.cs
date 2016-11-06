using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_MVVM
{
    class ViewModel_Student : AbstrackViewModel<Student>
    {
        protected override bool isExits(Student t)
        {
            var ob = db.Students.Where(s => s.Name.Equals(t.Name) || s.Phone.Equals(t.Phone)).ToList();
            if (ob.Count > 0)
                return true;
            else
            return false;
        }

        protected override void LoadObjectSet()
        {
            objectDbSet = db.Students;
        }

        protected override void setNewInfoFrom(Student o)
        {
            var old = db.Students.FirstOrDefault(s => s.ID == o.ID);
            old.Name = o.Name;
            old.Phone = o.Phone;
            old.Address = o.Address;
        }

        public ViewModel_Student() : base (){ }
    }
}
