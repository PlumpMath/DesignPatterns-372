using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_Iterator
{
    class CollectionList : AbstrachyCollection
    {
        List<Item> items = new List<Item>();
        public override Iterator CreateIterator()
        {
            return Iterator.CreateIterator(this);
        }

        public void Add(Item item)
        {
            items.Add(item);
        }

        public int Count() { return this.items.Count;  }

        public Item GetItemByID(int id)
        {
            return items[id];
        }
    }
}
