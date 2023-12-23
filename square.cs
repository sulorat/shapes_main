using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_2
{
    internal class square : shape
    {
        private double a;
        private void get_a(double a)
        {
            this.a = a;
        }
        protected override double perimetr_found()
        {
            perimetr = a * 4;
            return base.perimetr_found();
        }
        protected override double area_found()
        {
            area = Math.Pow(a, 2);
            return base.area_found();
        }
        public override void shape_found()
        {
            Console.WriteLine("Enter side A for square ");
            double side_square = double.Parse(Console.ReadLine());
            get_a(side_square);
            Console.Clear();
            Console.WriteLine("Perimetr of square: " + perimetr_found());
            Console.WriteLine("Area of square: " + area_found());
        }
        public override void piramid_found()
        {

            Console.WriteLine("Enter side of square");
            double side_a_square = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter apopheme ");
            double height = double.Parse(Console.ReadLine());
            get_a(side_a_square);
            Console.WriteLine("Area of piramida: " + 0.5*perimetr_found() * height + area_found());
        }
    }
}
