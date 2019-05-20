using PractiseMay18.FigureTask;
using PractiseMay18.Humans;
using PractiseMay18.Mammals;
using PractiseMay18.CalculatorTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay18
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circleFirst = new Circle(2.365, -4.859, 5.5);
            Circle circleSecond = new Circle(2.365, -4.859, 7.8);
            Circle circleThird = new Circle(2.365, -4.859, 10.5);
            Circle circleFourth = new Circle(2.365, -4.859, 20.5);
            Square squareFirst = new Square(8.45, 8.69, 10.0);
            Square squareSecond = new Square(8.45, 8.69, 20.0);
            Square squareThird = new Square(8.45, 8.69, 30.0);
            Triangle triangleFirst = new Triangle(-5.36, -9.96, 20.0, 5.0);
            Triangle triangleSecond = new Triangle(-5.36, -9.96, 10.0, 6.0);
            Triangle triangleThird = new Triangle(-5.36, -9.96, 30.0, 7.0);
            Figure[] figures = new Figure[] { circleFirst, circleSecond, circleThird, circleFourth,
                                              squareFirst, squareSecond, squareThird,
                                              triangleFirst, triangleSecond, triangleThird};
            foreach (var item in figures)
            {
                //if (item is Circle)
                //{
                //    Circle circle = (Circle)item;
                //    circle.Draw();
                //}

                //if (item is Square square)
                //{
                //    square.Draw();
                //}

                //if (item is Triangle triangle)
                //{
                //    triangle = item as Triangle;
                //    triangle.Draw();
                //}

                item.Draw();
            }
            
            Arboreal arborealBaby = new Arboreal(2);
            Arboreal arborealAdult = new Arboreal(25);
            Aquatic aquaticBaby = new Aquatic(4);
            Aquatic aquaticAdult = new Aquatic(38);
            Aerial arialBaby = new Aerial(1);
            Aerial arialAdult = new Aerial(51);
            Subterranean subterraneanBaby = new Subterranean(8);
            Subterranean subterraneanAdult = new Subterranean(41);
            Terrestrial terrestrialBaby = new Terrestrial(5);
            Terrestrial terrestrialAdult = new Terrestrial(27);
            Mammal[] mammals = new Mammal[] { arborealBaby, arborealAdult , aquaticBaby,
                aquaticAdult , arialBaby , arialAdult , subterraneanBaby , subterraneanAdult, terrestrialBaby,terrestrialAdult};
            Feeder feeder = new Feeder();
            feeder.Feed(mammals);
            foreach (var item in mammals)
            {
                item.Move();
            }

            Ukrainian vasia = new Ukrainian("Vasia");
            English john = new English("John");
            vasia.SayHello();
            john.SayHello();

            Calculator calculator = new Calculator(45.51, 9.5);
            calculator.LaunchCalculation();
        }
    }
}
