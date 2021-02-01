using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rover
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public Orientation Orientation { get; set; }

        public Rover(int x, int y, string orientation)
        {
            this.XCoordinate = x;
            this.YCoordinate = y;
            
            switch (orientation)
            {
                case "N": 
                    this.Orientation = Orientation.N;
                    break;
                case "S":
                    this.Orientation = Orientation.S;
                    break;
                case "E":
                    this.Orientation = Orientation.E;
                    break;
                case "W":
                    this.Orientation = Orientation.W;
                    break;
                default:
                    throw new Exception("Wrong orientation is entered");
            }
        }

        public void Walk(Plane plane, char[] path)
        {
            foreach (var command in path)
            {
                ProcessCommand(plane, command);
            }
        }

        public void ProcessCommand(Plane plane, char command)
        {
            switch (command)
            {
                case 'L':
                    RotateLeft();
                    break;
                case 'R':
                    RotateRight();
                    break;
                case 'M':
                    Move(plane);
                    break;
                default:
                    throw new Exception("Wrong command is entered");
            }
        }


        public void Move(Plane plane)
        {
            switch (this.Orientation)
            {
                case Orientation.N:
                    this.YCoordinate++;
                    break;
                case Orientation.S:
                    this.YCoordinate--;
                    break;
                case Orientation.E:
                    this.XCoordinate++;
                    break;
                case Orientation.W:
                    this.XCoordinate--;
                    break;
                default:
                    break;
            }

            ValidateCoordinates(plane);
        }

        public void RotateLeft() 
        {
            switch (this.Orientation) 
            {
                case Orientation.N:
                    this.Orientation = Orientation.W;
                    break;
                case Orientation.E:
                    this.Orientation = Orientation.N;
                    break;
                case Orientation.S:
                    this.Orientation = Orientation.E;
                    break;
                case Orientation.W:
                    this.Orientation = Orientation.S;
                    break;
                default:
                    throw new Exception("Wrong rotation is entered");
            }
        }

        public void RotateRight()
        {
            switch (this.Orientation)
            {
                case Orientation.N:
                    this.Orientation = Orientation.E;
                    break;
                case Orientation.E:
                    this.Orientation = Orientation.S;
                    break;
                case Orientation.S:
                    this.Orientation = Orientation.W;
                    break;
                case Orientation.W:
                    this.Orientation = Orientation.N;
                    break;
                default:
                    throw new Exception("Wrong rotation is entered");
            }
        }

        public void ValidateCoordinates(Plane plane)
        {
            if (this.XCoordinate > plane.XSize || this.XCoordinate < 0 
                || this.YCoordinate > plane.YSize || this.YCoordinate < 0)
            {
                throw new Exception("Outside of the plane");
            }
        }

    }
}
