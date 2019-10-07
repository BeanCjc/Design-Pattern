using System;
using VisitorPattern.One;
using VisitorPattern.Two;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------TemplateMethodPattern--------------------");
            Console.WriteLine();

            Console.WriteLine("--------------------one--------------------");
            ShapeVisitor shapeVisitor = new CustomConcreteVisitor();
            var app = new AppStructure(shapeVisitor);
            ShapeElement rectangle = new RectangleConcreteElement();
            rectangle.Draw();//执行自己的操作
            app.Process(rectangle);//执行新的操作
            ShapeElement circle = new CircleConcreteElement();
            circle.Draw();//执行自己的操作
            app.Process(circle);//执行新的操作
            ShapeElement line = new LineConcreteElement();
            line.Draw();//执行自己的操作
            app.Process(line);//执行新的操作
            Console.WriteLine();



            Console.WriteLine("--------------------two--------------------");
            StoragePlatformStructure storagePlatform = new StoragePlatformStructure();
            Visitor sizeVisitor = new SizeConcreteVisitor();
            Visitor stateVisitor = new StateConcreteVisitor();
            var television = new TelevisionConcreteElement();
            var computer = new ComputerConcreteElement();
            storagePlatform.Attach(television);
            storagePlatform.Attach(computer);
            storagePlatform.Operate(sizeVisitor);
            storagePlatform.Operate(stateVisitor);
            Console.ReadKey();
        }
    }
}
