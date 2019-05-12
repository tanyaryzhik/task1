using PractiseMay11.FigureTask;
using PractiseMay11.PlantsTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circle circleFirst = new Circle(2.365, -4.859, 5.5);
            //Circle circleSecond = new Circle(2.365, -4.859, 7.8);
            //Circle circleThird = new Circle(2.365, -4.859, 10.5);
            //Circle circleFourth = new Circle(2.365, -4.859, 20.5);
            //Square squareFirst = new Square(8.45, 8.69, 10.0);
            //Square squareSecond = new Square(8.45, 8.69, 20.0);
            //Square squareThird = new Square(8.45, 8.69, 30.0);
            //Triangle triangleFirst = new Triangle(-5.36, -9.96, 20.0, 5.0);
            //Triangle triangleSecond = new Triangle(-5.36, -9.96, 10.0, 6.0);
            //Triangle triangleThird = new Triangle(-5.36, -9.96, 30.0, 7.0);
            //Figure[] figures = new Figure[] { circleFirst, circleSecond, circleThird, circleFourth,
            //                                  squareFirst, squareSecond, squareThird,
            //                                  triangleFirst, triangleSecond, triangleThird};
            //foreach (var item in figures)
            //{
            //    if (item is Circle)
            //    {
            //        Circle circle = (Circle)item;
            //        circle.Draw();
            //    }

            //    if (item is Square square)
            //    {
            //        square.Draw();
            //    }

            //    if (item is Triangle triangle)
            //    {
            //        triangle = item as Triangle;
            //        triangle.Draw();
            //    }
            //}

            Tree oak = new Tree("Oak", 200, 100);
            Tree palm = new Tree("Palm", 500, 100);
            Tree pine = new Tree("Pine", 600, 300);
            Flower rose = new Flower("Rose", 80, 2);
            Flower dandelion = new Flower("Dandelion", 10, 2);
            Flower violet = new Flower("Violet", 10, 9);
            Plant[] plants = { oak, palm, pine, rose, dandelion, violet };
            Worker worker = new Worker();
            new Gallery(plants, worker).Execute();
        }
    }
}
