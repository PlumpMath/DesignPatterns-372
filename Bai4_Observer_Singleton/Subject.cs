using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_Observer_Singleton
{
    class Subject
    {
        public Color state;
        ArrayList observers = new ArrayList();

        ///Singleton
        private static Subject sub;
        protected Subject() { }
        public static Subject CreateSubject()
        {
            if (sub == null)
                sub = new Subject();
            return sub;
        }

        public void Attach(IObserver iob)
        {
            observers.Add(iob);
        }
        public void Detach(IObserver iob)
        {
            observers.Remove(iob);
        }
        public void Notify()
        {
            foreach (var ob in observers)
            {
                IObserver temp = (IObserver) ob;
                temp.Update(state);
            }
        }

    }
}
