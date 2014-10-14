using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


struct Object
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;

}
class JustCars
{
    static void PrintOnPosition(int x, int y, char c, ConsoleColor color=ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }
    
    static void Main()
    {
        double speed = 100.0;
        double acceleration = 0.5;
        int playfieldWidth = 5;
        int livesCount = 5;
        Console.BufferHeight = Console.WindowHeight=20;
        Console.BufferWidth = Console.WindowWidth=30;
        Object userCar = new Object();
        userCar.x = 2;
        userCar.y = Console.WindowHeight - 1;
        userCar.c = '@';
        userCar.color = ConsoleColor.Yellow;
        Random randomGenerator = new Random();
        List<Object> cars = new List<Object>();




        while(true)
        {
            speed+=acceleration;
            if(speed>400)
            {
                speed = 400;
            }
            bool hitted = false;
            {
                Object newCar = new Object();
                newCar.color = ConsoleColor.Green;
                newCar.x = randomGenerator.Next(0, playfieldWidth);
                newCar.y = 0;
                newCar.c = '#';
                cars.Add(newCar);
            }
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
               // while (Console.KeyAvailable) Console.ReadKey(true);
                {

                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (userCar.x - 1 >= 0)
                    {
                        userCar.x = userCar.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (userCar.x + 1 < playfieldWidth)
                    {
                        userCar.x = userCar.x + 1;
                    }
                }

            }

            //Move our car(key passed)
            //Move cars
            List<Object> newList = new List<Object>();
            for (int i = 0; i < cars.Count; i++)
            {
                Object oldCar = cars[i];
                Object newCar = new Object();
                newCar.x = oldCar.x;
                newCar.y = oldCar.y+1;
                newCar.c = oldCar.c;
                newCar.color = oldCar.color;
                if(newCar.y==userCar.y && newCar.x==userCar.x)
                {
                    livesCount--;
                    hitted = true;
                    speed += 50;
                    if (speed > 400)
                    {
                        speed = 400;
                    }
                    if(livesCount<=0)
                    {
                        PrintStringOnPosition(8, 10, "GAME OVER!!!", ConsoleColor.Red);
                        PrintStringOnPosition(8, 12, "Press [enter] to exit", ConsoleColor.Red);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                if(newCar.y<Console.WindowHeight)
                {
                    newList.Add(newCar);
                }               
            }
            cars = newList;
            //Check if other cars ate hitting us
            //
            //Clear the console
            Console.Clear();
            if (hitted)
            {
                cars.Clear();
                PrintOnPosition(userCar.x, userCar.y, 'X', ConsoleColor.Red);
            }
            else
            {
                PrintOnPosition(userCar.x, userCar.y, userCar.c, userCar.color);
            }
            //Redraw palyfield
           
            foreach (Object car in cars)
            {
                PrintOnPosition(car.x, car.y, car.c, car.color);
            }
            
            //Draw info
            PrintStringOnPosition(8,4,"Lives: "+ livesCount,ConsoleColor.White);
            PrintStringOnPosition(8, 5, "Speed: " + speed, ConsoleColor.White);
            PrintStringOnPosition(8, 6, "Acceleration: " + acceleration, ConsoleColor.White);


            //Slow down program
            //Console.Beep();
            Thread.Sleep((int)(600-speed));

        }

    }

    private static void PrintStringOnPosition()
    {
        throw new NotImplementedException();
    }
}

