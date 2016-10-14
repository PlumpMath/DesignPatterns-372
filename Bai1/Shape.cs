using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bai1
{
    abstract class Shape
    {
      

        public delegate void HienThiKetQua(double area);
        protected ArrayList para = new ArrayList();

        public event HienThiKetQua hienThiKetQua;

        protected double area;
        abstract public void NhapThamSo();
        public void TinhDienTich()
        {
            area = Tinh();
            hienThiKetQua?.Invoke(area);
            //if (hienThiKetQua == null)
            //    hienThiKetQua(area);
        }

        protected abstract double Tinh();


    }
}
