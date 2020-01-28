// ===============================
// AUTHOR       : Carl Nathan Mier
// EMAIL        : carlnathanmier@gmail.com
// CREATE DATE  : January 28, 2020
// PURPOSE      : Luxoft exam task
//==================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        public string convertTime(string aTime)
        {
            //split the time string into hours, minutes, and seconds
            var time = aTime.Split(':');
            
            var yellowLamp = int.Parse(time[2]) % 2 == 0 ? "Y" : "O";

            var hours = int.Parse(time[0]);
            string firstLine = "";
            #region get this first line
            switch (hours / 5)
            {
                case 0: 
                    firstLine = "OOOO";
                    break;
                case 1:
                    firstLine = "ROOO";
                    hours -= 5;
                    break;
                case 2:
                    firstLine = "RROO";
                    hours -= 10;
                    break;
                case 3:
                    firstLine = "RRRO";
                    hours -= 15;
                    break;
                case 4:
                    firstLine = "RRRR";
                    hours -= 20;
                    break;
                default:
                    throw new Exception("hours input is out of bounds!");
            }
            #endregion

            string secondLine = "";
            #region get the second line
            switch (hours)
            {
                case 0: secondLine = "OOOO";
                    break;
                case 1: secondLine = "ROOO";
                    break;
                case 2: secondLine = "RROO";
                    break;
                case 3: secondLine = "RRRO";
                    break;
                case 4: secondLine = "RRRR";
                    break;
            }
            #endregion
            
            var minutes = int.Parse(time[1]);
            string thirdLine = "";
            #region get the third line
            switch (minutes / 5)
            {
                case 0:
                    thirdLine = "OOOOOOOOOOO";
                    break;
                case 1:
                    thirdLine = "YOOOOOOOOOO";
                    minutes -= 5;
                    break;
                case 2:
                    thirdLine = "YYOOOOOOOOO";
                    minutes -= 10;
                    break;
                case 3:
                    thirdLine = "YYROOOOOOOO";
                    minutes -= 15;
                    break;
                case 4:
                    thirdLine = "YYRYOOOOOOO";
                    minutes -= 20;
                    break;
                case 5:
                    thirdLine = "YYRYYOOOOOO";
                    minutes -= 25;
                    break;
                case 6:
                    thirdLine = "YYRYYROOOOO";
                    minutes -= 30;
                    break;
                case 7:
                    thirdLine = "YYRYYRYOOOO";
                    minutes -= 35;
                    break;
                case 8:
                    thirdLine = "YYRYYRYYOOO";
                    minutes -= 40;
                    break;
                case 9:
                    thirdLine = "YYRYYRYYROO";
                    minutes -= 45;
                    break;
                case 10:
                    thirdLine = "YYRYYRYYRYO";
                    minutes -= 50;
                    break;
                case 11:
                    thirdLine = "YYRYYRYYRYY";
                    minutes -= 55;
                    break;
                default:
                    throw new Exception("minutes input is out of bounds!");

            }
            #endregion

            string fourthLine = "";
            #region get the fourth line
            switch (minutes)
            {
                case 0:
                    fourthLine = "OOOO";
                break;
                case 1:
                    fourthLine = "YOOO";
                    break;
                case 2:
                    fourthLine = "YYOO";
                    break;
                case 3:
                    fourthLine = "YYYO";
                    break;
                case 4:
                    fourthLine = "YYYY";
                    break;
            }
            #endregion

            //combine them all together, then return the result
            return $"{yellowLamp}\r\n{firstLine}\r\n{secondLine}\r\n{thirdLine}\r\n{fourthLine}";

            //look, ma! no loops! (or complex expensive algorithms)

        }
    }
}
