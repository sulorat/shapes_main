using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_2
{
    internal class circle : shape
    {
        private double r;
        internal void get_r(double r)
        {
            this.r = r;
        }
        protected override double perimetr_found()
        {
            perimetr = 2 * (Math.PI * r);
            return base.perimetr_found();
        }
        protected override double area_found()
        {
            area = Math.PI * Math.Pow(r, 2);
            return base.area_found();
        }
        public override void shape_found()
        {
            Console.WriteLine("Enter radius circle");
            double circl_radius = double.Parse(Console.ReadLine());
            get_r(circl_radius);
            Console.Clear();
            Console.WriteLine("Perimentr of circle: " + perimetr_found());
            Console.WriteLine("Area of circle: " + area_found());
        }
    }
}
