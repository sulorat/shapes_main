using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_2
{
    internal class piramid : shape
    {
        triangle triangle = new triangle();
        square square = new square();
        private double type;
        private void get_type(double type)
        {
            this.type = type;
        }
        private double area_piramid(double l, double r)
        {
            area = Math.PI * r * (r + l);
            return base.area_found();
        }
        public override void shape_found()
        {
            Console.WriteLine("Enter apopheme");
            double l = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter radius of circle");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of piramida: " + area_piramid(l, radius));

        }
    }
}
