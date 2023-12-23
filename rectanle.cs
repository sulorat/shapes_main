using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_2
{
    internal class rectangle : shape
    {
        private double a, b;
        internal void get_ab(double a,double b)
        {
            this.a = a;
            this.b = b;
        }
        protected override double perimetr_found()
        {
            perimetr = (a * 2) + (b * 2);
            return base.perimetr_found();
        }
        protected override double area_found()
        {
            area = a * b;
            return base.area_found();
        }
        public override void shape_found()
        {
            Console.WriteLine("Enter side A for rectangle");
            double side_a_rectangle = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side B for rectangle");
            double side_b_rectangle = double.Parse(Console.ReadLine());
            get_ab(side_a_rectangle, side_b_rectangle);
            Console.Clear();
            Console.WriteLine("Perimetr of rectangle: " + perimetr_found());
            Console.WriteLine("Area of rectangle: " + area_found());
        }
    }
}
