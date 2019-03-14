using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp4
{

    class Coordinate
    {

        public int X { get; set; } //Left
        public int Y { get; set; } //Top
    }

    class Asteroids
    {
        Random ran = new Random();


        public Coordinate spawnAsteroid(int width, int height)  //necessary?
        {
            Coordinate ast = new Coordinate();
            ast.Y = ran.Next(0, height);
            ast.X = width;
            Console.SetCursorPosition(ast.X, ast.Y);
            Console.Write("O");
            return ast;
        }

        //


        public List<Coordinate> AsteroidMover(List<Coordinate> AsteroidList)
        {
            
            Coordinate ast = new Coordinate();
            for (int i = 0; i < AsteroidList.Count; i++)
            {
                ast = AsteroidList[i];
                ast.X -= 1;
                if (ast.X == 0)
                {
                    AsteroidList.RemoveAt(i);
                    Console.SetCursorPosition(ast.X + 1, ast.Y);
                    Console.Write(" ");
                    continue;
                }
                AsteroidList.RemoveAt(i);
                AsteroidList.Insert(i, ast);
                Console.SetCursorPosition(ast.X + 1, ast.Y);
                Console.Write(" ");
                Console.SetCursorPosition(ast.X, ast.Y);
                Console.Write("O");
            }
            return AsteroidList;
        }

    }



    
    
    
    //Spawn Asteroid














}
