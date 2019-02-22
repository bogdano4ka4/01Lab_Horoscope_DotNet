using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Poberezhets.Tools.ViewTypes
{
    internal enum ViewHoroscope
    {
        Monkey,
        Cock,
        Dog,
        Pig,
        Rat,
        Bull,
        Tiger,
        Cat,
        Dragon,
        Snake,
        Horse,
        Goat
    }
    internal interface IChinaHoroscope
    {
        string GiveHoroscope( DateTime date);
    }
}
