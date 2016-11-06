using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_MVVM
{
    abstract class AbstrackViewModel<T> where T : class
    {
        protected DbSet<T> objectDbSet;
        BindingSource objectBindingList;

        private int currentIndex = -1;

        protected DesignPatternDB db;

        public delegate void CurrentIndexChanged(T t);
        public event CurrentIndexChanged currentIndexChangedEvent;

        public AbstrackViewModel()
        {
            db =  DesignPatternDB.ConnectDB();
            objectBindingList = new BindingSource();
            LoadObjectSet();
        }
        abstract protected void LoadObjectSet();
        abstract protected bool isExits(T t);
        abstract protected void setNewInfoFrom(T o);

        public int CurrentIndex
        {
            get { return currentIndex; }
            set
            {
                currentIndex = value;
                if (currentIndexChangedEvent != null & currentIndex >= 0)
                    currentIndexChangedEvent((T)objectBindingList[currentIndex]);
            }
        }

        public int Add(T o)
        {
            if (!isExits(o))
            {
                objectDbSet.Add(o);
                int res = db.SaveChanges();
                if(res > 0)
                    objectBindingList.Add(o);
                return res;
            }
            else
            return -1;
        }

        public int Delete(T o)
        {

            objectBindingList.Remove(o);
            objectDbSet.Remove(o);
            int res = db.SaveChanges();
            if (res > 0)
            {
                objectBindingList.Remove(o);
                objectBindingList.ResetBindings(false);
                
            }
            return res;
        }

        public int Update(T o)
        {
            setNewInfoFrom(o);
           // db.Entry(o).State = EntityState.Modified;
            int num = db.SaveChanges();
            if (num > 0)
            {
                objectBindingList[currentIndex] = o;
                objectBindingList.ResetCurrentItem();
            }
            return num;
        }

        public BindingSource GetObjectBindingSource()
        {
            objectBindingList.DataSource = objectDbSet.ToList();
            if (objectBindingList.Count >= 0)
                currentIndex = 0;
            return objectBindingList;
        }

    }
}
