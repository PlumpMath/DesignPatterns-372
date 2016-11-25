using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_Iterator
{
    class Iterator : AbstractIterator
    {
        CollectionList collection;
        int current = 0;

        protected static Iterator instance;
        private Iterator(CollectionList collection)
        {
            this.collection = collection;
        }

        public static Iterator CreateIterator (CollectionList collection)
        {
            if (instance == null)
                instance = new Iterator(collection);
            return instance;

        }
        public override Item CurrentItem()
        {
            return collection.GetItemByID(current);
        }

        public override Item First()
        {
            current = 0;
            return collection.GetItemByID(0);
        }

        public override bool isLast()
        {
            if (current >= collection.Count()-1)
                return true;
            return false;
        }

        public override Item Last()
        {
            return collection.GetItemByID(collection.Count() - 1);
        }

        public override Item Next()
        {
            if(!isLast())
            {
                current++;
                return collection.GetItemByID(current);
            }
            return null;
        }

        public override Item Prev()
        {
            if (current == 0)
                return null;
            current--;
            return this.collection.GetItemByID(current);
        }
    }
}
