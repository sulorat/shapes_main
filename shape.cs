using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_2
{
    internal class shape
    {
        protected double area;
        protected double perimetr;
        protected virtual double perimetr_found()
        {
            return perimetr;
        }
        protected virtual double area_found()
        {
            return area;
        }
        public virtual void shape_found()
        {

        }
        public virtual  void piramid_found()
        {

        }
    }
}
