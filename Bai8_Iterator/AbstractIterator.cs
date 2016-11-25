using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_Iterator
{
    abstract class AbstractIterator
    {
        abstract public Item First();
        abstract public Item Last();
        abstract public Item Next();
        abstract public Item Prev();
        abstract public bool isLast();
        abstract public Item CurrentItem();
    }
}
