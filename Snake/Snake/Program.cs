using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.SetBufferSize(65, 20); // установить размер окна и убрать возможность перемотки

            // Отрисовка рамочки
            HorizontalLines lineUp = new HorizontalLines(0, 58, 0, '+');
            HorizontalLines lineDown = new HorizontalLines(0, 58, 14, '+');
            VerticalLines lineLeft = new VerticalLines(0, 0, 14, '+');
            VerticalLines lineRigth = new VerticalLines(58, 0, 14, '+');

            lineUp.Drow();
            lineDown.Drow();
            lineLeft.Drow();
            lineRigth.Drow();

            // Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGTH);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(200);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(200);
                snake.Move();
            }

            Console.ReadLine();
        }
    }
}
