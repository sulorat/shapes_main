using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_2
{
    internal class triangle : shape
    {
        private double a, b, c, h;
        private int type;
        private void get_a_b_c_h(double a, double b, double c, double h)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.h = h;
        }
        private void get_b(double b)
        {
            this.b = b;
        }
        private void get_a(double a)
        {
            this.a = a;
        }
        private void get_h(double h)
        {
            this.h = h;
        }

        private void get_type(int type)
        {
            this.type = type;
        }
        protected override double perimetr_found()
        {
            perimetr = a + b + c;
            return base.perimetr_found();
        }
        protected override double area_found()
        {
            if (type == 1)
            {
                area = (a * h) / 2;
                return base.area_found();
            }
            if (type == 2)
            {
                area = (a * b) / 2;
                return base.area_found();
            }
            if (type == 3)
            {
                area = (Math.Pow(a, 2) * Math.Sqrt(3)) / 4;
                return base.area_found();
            }
            return base.area_found();
        }
        public override void shape_found()
        {
            Console.WriteLine("Enter side 1 for triangle");
            double side_a_triangle = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side 2 for triangle");
            double side_b_triangle = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side 3 for triangle");
            double side_c_triangle = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height for triangle");
            double height = double.Parse(Console.ReadLine());
            get_a_b_c_h(side_a_triangle, side_b_triangle, side_c_triangle, height);
            if ((side_a_triangle > 0) && (side_b_triangle > 0) && (side_c_triangle > 0))
            {
                if ((side_a_triangle + side_b_triangle <= side_c_triangle) || (side_c_triangle + side_b_triangle <= side_a_triangle) || (side_a_triangle + side_c_triangle <= side_b_triangle))
                {
                    Console.Clear();
                    Console.WriteLine("Triangle is not exist");
                    Console.WriteLine("Press any button to continue");
                    Console.ReadKey();
                    return;
                }
                if ((side_a_triangle > side_b_triangle) && (side_a_triangle > side_c_triangle))
                {
                    if (Math.Pow(side_b_triangle, 2) + Math.Pow(side_c_triangle, 2) == Math.Pow(side_a_triangle, 2))
                    {
                        get_type(2);
                    }
                }
                if ((side_b_triangle > side_a_triangle) && (side_b_triangle > side_c_triangle))
                {
                    if (Math.Pow(side_a_triangle, 2) + Math.Pow(side_c_triangle, 2) == Math.Pow(side_b_triangle, 2))
                    {
                        get_type(2);
                        get_b(side_c_triangle);
                    }
                }
                if ((side_c_triangle > side_b_triangle) && (side_c_triangle > side_a_triangle))
                {
                    if (Math.Pow(side_b_triangle, 2) + Math.Pow(side_a_triangle, 2) == Math.Pow(side_c_triangle, 2))
                    {
                        get_type(2);
                    }
                }
                else if ((side_c_triangle == side_b_triangle) && (side_c_triangle == side_a_triangle))
                {
                    get_type(3);
                }
                else if ((Math.Pow(side_a_triangle, 2) + Math.Pow(side_b_triangle, 2)) > Math.Pow(side_c_triangle, 2))
                {
                    get_type(1);
                }
                else if ((Math.Pow(side_b_triangle, 2) + Math.Pow(side_c_triangle, 2)) > Math.Pow(side_a_triangle, 2))
                {
                    get_type(1);
                }
                else if ((Math.Pow(side_a_triangle, 2) + Math.Pow(side_c_triangle, 2)) > Math.Pow(side_b_triangle, 2))
                {
                    get_type(1);
                }
                Console.Clear();
                Console.WriteLine("Perimetr of triangle: " + perimetr_found());
                Console.WriteLine("Area of triangle: " + area_found());
            }
        }
        public override void piramid_found()
        {
            get_type(1);
            Console.WriteLine("Enter side of footing triangle");
            get_a(double.Parse(Console.ReadLine()));
            Console.WriteLine("Enter height of footing triangle");
            get_h(double.Parse(Console.ReadLine()));
            double s_triangle_1 = area_found();
            Console.WriteLine("Enter apopheme");
            get_h(double.Parse(Console.ReadLine()));
            double s_triangle_2 = area_found();
            Console.WriteLine("Area of piramida: " + (s_triangle_1 + 3 * s_triangle_2));
        }
    }
}
