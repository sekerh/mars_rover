using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            string[] planeSizes = firstLine.Split(' ');
            Plane plane = new Plane(Int32.Parse(planeSizes[0]), Int32.Parse(planeSizes[1]));

            string secondLine, thirdLine;

            while (true) 
            { 
                secondLine = Console.ReadLine();
                string[] roverLocations = secondLine.Split(' ');
                Rover rover = new Rover(Int32.Parse(roverLocations[0]), Int32.Parse(roverLocations[1]), roverLocations[2]);

                thirdLine = Console.ReadLine();
                char[] path = thirdLine.ToCharArray();
                rover.Walk(plane, path);
                Console.WriteLine(rover.XCoordinate + " " + rover.YCoordinate + " " + rover.Orientation.ToString());
            }
        }

    }
}
