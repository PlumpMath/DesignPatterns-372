using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_Observer_Singleton
{
    interface IObserver
    {
        void Update(Color color);
    }
}
