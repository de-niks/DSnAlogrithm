using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class RobotBoundedINCircle
    {
        public static bool IsRobotBounded(string instructions)
        {
            int posX = 0;
            int posY = 0;

            char direction = 'N';

            foreach (char instruction in instructions)
            {
                if (instruction == 'G')
                {

                    if (direction == 'N')
                        posY++;
                    else if (direction == 'S')
                        posY--;
                    else if (direction == 'E')
                        posX++;
                    else if (direction == 'W')
                        posX--;
                }

                if (instruction == 'L')
                {
                    if (direction == 'N')
                        direction = 'W';
                    else if (direction == 'W')
                        direction = 'S';
                    else if (direction == 'S')
                        direction = 'E';
                    else if (direction == 'E')
                        direction = 'N';
                }

                if (instruction == 'R')
                {

                    if (direction == 'N')
                        direction = 'E';
                    else if (direction == 'E')
                        direction = 'S';
                    else if (direction == 'S')
                        direction = 'W';
                    else if (direction == 'W')
                        direction = 'N';

                }

            }

            if(posX == 0 && posY == 0)
                return true;

            if (direction == 'N')
                return false;

            return true;
        }
    }
}
