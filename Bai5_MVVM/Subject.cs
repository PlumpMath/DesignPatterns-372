using System.Collections;

namespace Bai5_MVVM
{
    class Subject
    {
        public Student student;
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
                IObserver temp = (IObserver)ob;
                temp.AddStudent(student);
            }
        }
    }
}
