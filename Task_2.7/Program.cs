using System;

namespace Task_2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputMenu();
            int figureNumber = int.Parse(Console.ReadLine());
            switch (figureNumber)
            {
                case (int)FigureTypes.Line:
                    var Line = new Line();
                    Line.Draw();
                    break;
                case (int)FigureTypes.Circle:
                    var Circle = new Circle();
                    Circle.Draw();
                    break;
                case (int)FigureTypes.Ring:
                    var Ring = new Ring();
                    Ring.Draw();
                    break;
                case (int)FigureTypes.Rectangle:
                    var Rectangle = new Rectangle();
                    Rectangle.Draw();
                    break;
                default:
                    Console.WriteLine("Input correct figure number");
                    break;
            }
            Console.ReadKey();
        }

        enum FigureTypes
        {
            Line=1,
            Circle=2,
            Ring=3,
            Rectangle=4
        }

        static void OutputMenu() // Вывод меню
        {
            Console.WriteLine(
                "Input figure number:" + '\n' +
                "1:Line" + '\n' +
                "2:Circle" + '\n' +
                "3:Ring" + '\n' +
                "4:Rectangle");
        }
    }
}
